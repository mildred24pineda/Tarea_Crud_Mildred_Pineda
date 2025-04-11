using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Tarea_crud_
{
    public partial class FormEditarTarea : Form
    {
        public string Carnet => comboBoxCarnet.SelectedItem?.ToString();
        public decimal Nota1 => decimal.Parse(textBoxNota1.Text);
        public decimal Nota2 => decimal.Parse(textBoxNota2.Text);
        public decimal Nota3 => decimal.Parse(textBoxNota3.Text);
        public decimal Nota4 => decimal.Parse(textBoxNota4.Text);

        public FormEditarTarea()
        {
            InitializeComponent();
            ConfigurarInterfaz();
            CargarAlumnos();
            this.Text = "Agregar Nueva Tarea";
        }

        private void ConfigurarInterfaz()
        {
            this.ClientSize = new Size(350, 300);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.LightSteelBlue;
            this.Font = new Font("Segoe UI", 9, FontStyle.Regular);

            // Estilo de controles
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.BackColor = Color.White;
                    textBox.TextAlign = HorizontalAlignment.Right;
                }
                else if (control is Label label)
                {
                    label.Font = new Font(label.Font, FontStyle.Bold);
                }
            }
        }

        private void CargarAlumnos()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    var cmd = new SqlCommand("SELECT Carnet FROM Tb_alumnos ORDER BY Carnet", conn as SqlConnection);
                    conn.Open();
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBoxCarnet.Items.Add(reader["Carnet"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar alumnos: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatos()
        {
            if (comboBoxCarnet.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un alumno", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxCarnet.Focus();
                return false;
            }

            if (!decimal.TryParse(textBoxNota1.Text, out decimal n1) || n1 < 0 || n1 > 100 ||
                !decimal.TryParse(textBoxNota2.Text, out decimal n2) || n2 < 0 || n2 > 100 ||
                !decimal.TryParse(textBoxNota3.Text, out decimal n3) || n3 < 0 || n3 > 100 ||
                !decimal.TryParse(textBoxNota4.Text, out decimal n4) || n4 < 0 || n4 > 100)
            {
                MessageBox.Show("Las notas deben ser valores entre 0 y 100", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}