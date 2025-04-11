using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Tarea_crud_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigureUI();
        }

        private void ConfigureUI()
        {
            // Configuración general del formulario
            this.Text = "SISTEMA DE GESTIÓN DE ALUMNOS Y TAREAS";
            this.BackColor = Color.LightSteelBlue;
            this.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            this.Size = new Size(900, 650);

            // Configurar DataGridView de alumnos
            ConfigureDataGridView(dataGridViewAlumnos);
            ConfigureDataGridView(dataGridViewTareas);

            // Configurar controles de búsqueda
            ConfigureSearchControls();

            // Configurar botones
            ConfigureButtons();

            // Cargar datos iniciales
            LoadAlumnos();
            LoadTareas();
        }

        private void ConfigureDataGridView(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.Fixed3D;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
        }

        private void ConfigureSearchControls()
        {
            // Configurar ComboBox de sección
            comboBoxSeccion.Items.AddRange(new object[] { "Todas", "A", "B", "C" });
            comboBoxSeccion.SelectedIndex = 0;
            comboBoxSeccion.DropDownStyle = ComboBoxStyle.DropDownList;

            // Configurar campo de búsqueda de alumnos
            textBuscarAlumno.Text = "Buscar por carnet o nombre";
            textBuscarAlumno.ForeColor = SystemColors.GrayText;
            textBuscarAlumno.Enter += (s, e) => {
                if (textBuscarAlumno.Text == "Buscar por carnet o nombre")
                {
                    textBuscarAlumno.Text = "";
                    textBuscarAlumno.ForeColor = SystemColors.WindowText;
                }
            };
            textBuscarAlumno.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(textBuscarAlumno.Text))
                {
                    textBuscarAlumno.Text = "Buscar por carnet o nombre";
                    textBuscarAlumno.ForeColor = SystemColors.GrayText;
                }
            };
        }

        private void ConfigureButtons()
        {
            // Configurar colores y eventos de los botones
            buttonAgregar.BackColor = Color.LightGreen;
            buttonEditar.BackColor = Color.PeachPuff;
            buttonEliminar.BackColor = Color.MistyRose;
            buttonBuscarAlumno.BackColor = Color.LightSalmon;
            buttonAgregarTarea.BackColor = Color.Thistle;
            buttonBuscarTarea.BackColor = Color.LightSalmon;

            // Asignar eventos
            buttonBuscarAlumno.Click += (s, e) => SearchAlumnos();
            buttonBuscarTarea.Click += (s, e) => SearchTareas();
            buttonAgregar.Click += (s, e) => AddStudent();
            buttonEditar.Click += (s, e) => EditStudent();
            buttonEliminar.Click += (s, e) => DeleteStudent();
            buttonAgregarTarea.Click += (s, e) => AddTask();
            comboBoxSeccion.SelectedIndexChanged += (s, e) => SearchAlumnos();
        }

        private void SearchAlumnos()
        {
            string searchTerm = textBuscarAlumno.Text == "Buscar por carnet o nombre" ? "" : textBuscarAlumno.Text.Trim();
            string seccion = comboBoxSeccion.SelectedItem?.ToString() ?? "";
            LoadAlumnos(searchTerm, seccion);
        }

        private void SearchTareas()
        {
            string carnet = textBuscarTarea.Text.Trim();
            LoadTareas(carnet);
        }

        private void LoadAlumnos(string filtro = "", string seccion = "")
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = "SELECT Carnet, Nombre, Apellido, Seccion, Correo FROM Tb_alumnos WHERE 1=1";

                    if (!string.IsNullOrEmpty(filtro) && filtro != "Buscar por carnet o nombre")
                    {
                        query += @" AND (Carnet LIKE @busqueda 
                                      OR Nombre LIKE @busqueda 
                                      OR Apellido LIKE @busqueda)";
                    }

                    if (!string.IsNullOrEmpty(seccion) && seccion != "Todas")
                    {
                        query += " AND Seccion = @seccion";
                    }

                    SqlDataAdapter da = new SqlDataAdapter(query, conn as SqlConnection);

                    if (!string.IsNullOrEmpty(filtro) && filtro != "Buscar por carnet o nombre")
                    {
                        da.SelectCommand.Parameters.AddWithValue("@busqueda", $"%{filtro}%");
                    }

                    if (!string.IsNullOrEmpty(seccion) && seccion != "Todas")
                    {
                        da.SelectCommand.Parameters.AddWithValue("@seccion", seccion);
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewAlumnos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar alumnos: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTareas(string carnet = "")
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string query = @"SELECT t.id_tarea, t.Carnet, a.Nombre + ' ' + a.Apellido as Estudiante,   
                                          t.nota1, t.nota2, t.nota3, t.nota4  
                                          FROM tareas t  
                                          INNER JOIN Tb_alumnos a ON t.Carnet = a.Carnet";

                    if (!string.IsNullOrEmpty(carnet))
                    {
                        query += " WHERE t.Carnet = @carnet";
                    }

                    SqlDataAdapter da = new SqlDataAdapter(query, conn as SqlConnection);

                    if (!string.IsNullOrEmpty(carnet))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@carnet", carnet);
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewTareas.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tareas: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddStudent()
        {
            using (var formEditar = new FormEditarAlumno())
            {
                if (formEditar.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        using (var conn = DatabaseHelper.GetConnection())
                        {
                            var cmd = new SqlCommand(
                                "INSERT INTO Tb_alumnos (Carnet, Nombre, Apellido, Seccion, Correo) " +
                                "VALUES (@Carnet, @Nombre, @Apellido, @Seccion, @Correo)",
                                conn as SqlConnection);

                            cmd.Parameters.AddWithValue("@Carnet", formEditar.Carnet);
                            cmd.Parameters.AddWithValue("@Nombre", formEditar.Nombre);
                            cmd.Parameters.AddWithValue("@Apellido", formEditar.Apellido);
                            cmd.Parameters.AddWithValue("@Seccion", formEditar.Seccion);
                            cmd.Parameters.AddWithValue("@Correo", formEditar.Correo);

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                textBuscarAlumno.Text = formEditar.Carnet;
                                LoadAlumnos(formEditar.Carnet);
                                MessageBox.Show("Alumno agregado correctamente", "Éxito",
                                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (SqlException ex) when (ex.Number == 2627)
                    {
                        MessageBox.Show("Error: El carnet ya existe", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void EditStudent()
        {
            if (dataGridViewAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un alumno primero", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fila = dataGridViewAlumnos.SelectedRows[0];
            using (var formEditar = new FormEditarAlumno(
                carnet: fila.Cells["Carnet"].Value.ToString(),
                nombre: fila.Cells["Nombre"].Value.ToString(),
                apellido: fila.Cells["Apellido"].Value.ToString(),
                seccion: fila.Cells["Seccion"].Value.ToString(),
                correo: fila.Cells["Correo"].Value.ToString()))
            {
                if (formEditar.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        using (var conn = DatabaseHelper.GetConnection())
                        {
                            var cmd = new SqlCommand(
                                "UPDATE Tb_alumnos SET " +
                                "Nombre = @Nombre, " +
                                "Apellido = @Apellido, " +
                                "Seccion = @Seccion, " +
                                "Correo = @Correo " +
                                "WHERE Carnet = @Carnet",
                                conn as SqlConnection);

                            cmd.Parameters.AddWithValue("@Carnet", formEditar.Carnet);
                            cmd.Parameters.AddWithValue("@Nombre", formEditar.Nombre);
                            cmd.Parameters.AddWithValue("@Apellido", formEditar.Apellido);
                            cmd.Parameters.AddWithValue("@Seccion", formEditar.Seccion);
                            cmd.Parameters.AddWithValue("@Correo", formEditar.Correo);

                            conn.Open();
                            cmd.ExecuteNonQuery();

                            LoadAlumnos(textBuscarAlumno.Text);
                            MessageBox.Show("Cambios guardados correctamente", "Éxito",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al actualizar: {ex.Message}", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DeleteStudent()
        {
            if (dataGridViewAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un alumno primero", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var carnet = dataGridViewAlumnos.SelectedRows[0].Cells["Carnet"].Value.ToString();

            if (MessageBox.Show($"¿Está seguro que desea eliminar al alumno con carnet {carnet}?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var conn = DatabaseHelper.GetConnection())
                    {
                        var cmd = new SqlCommand(
                            "DELETE FROM Tb_alumnos WHERE Carnet = @Carnet",
                            conn as SqlConnection);
                        cmd.Parameters.AddWithValue("@Carnet", carnet);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        LoadAlumnos(textBuscarAlumno.Text);
                        MessageBox.Show("Alumno eliminado correctamente", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddTask()
        {
            using (var formTarea = new FormEditarTarea())
            {
                if (formTarea.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        using (var conn = DatabaseHelper.GetConnection())
                        {
                            var cmd = new SqlCommand(
                                "INSERT INTO tareas (Carnet, nota1, nota2, nota3, nota4) " +
                                "VALUES (@Carnet, @nota1, @nota2, @nota3, @nota4)",
                                conn as SqlConnection);

                            cmd.Parameters.AddWithValue("@Carnet", formTarea.Carnet);
                            cmd.Parameters.AddWithValue("@nota1", formTarea.Nota1);
                            cmd.Parameters.AddWithValue("@nota2", formTarea.Nota2);
                            cmd.Parameters.AddWithValue("@nota3", formTarea.Nota3);
                            cmd.Parameters.AddWithValue("@nota4", formTarea.Nota4);

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                textBuscarTarea.Text = formTarea.Carnet;
                                LoadTareas(formTarea.Carnet);
                                MessageBox.Show("Tarea agregada correctamente", "Éxito",
                                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar tarea: {ex.Message}", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}