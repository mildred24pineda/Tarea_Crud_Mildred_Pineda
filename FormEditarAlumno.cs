using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tarea_crud_
{
    public partial class FormEditarAlumno : Form
    {
        public string Carnet => textBoxCarnet.Text;
        public string Nombre => textBoxNombre.Text;
        public string Apellido => textBoxApellido.Text;
        public string Seccion => comboBoxSeccion.SelectedItem?.ToString();
        public string Correo => textBoxCorreo.Text;

        public FormEditarAlumno()
        {
            InitializeComponent();
            ConfigurarInterfaz();
            this.Text = "Agregar Nuevo Alumno";
        }

        public FormEditarAlumno(string carnet, string nombre, string apellido, string seccion, string correo) : this()
        {
            this.Text = "Editar Alumno";
            textBoxCarnet.Text = carnet;
            textBoxNombre.Text = nombre;
            textBoxApellido.Text = apellido;
            comboBoxSeccion.SelectedItem = seccion;
            textBoxCorreo.Text = correo;
            textBoxCarnet.ReadOnly = true;
        }

        private void ConfigurarInterfaz()
        {
            this.ClientSize = new Size(350, 300);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.LightSteelBlue;
            this.Font = new Font("Segoe UI", 9, FontStyle.Regular);

            // Configurar ComboBox de sección
            comboBoxSeccion.Items.AddRange(new object[] { "A", "B", "C" });
            comboBoxSeccion.DropDownStyle = ComboBoxStyle.DropDownList;

            // Estilo de controles
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.BackColor = Color.White;
                }
                else if (control is Label)
                {
                    control.Font = new Font(control.Font, FontStyle.Bold);
                }
            }

            // Validación de email
            textBoxCorreo.Validating += (s, e) => {
                if (!textBoxCorreo.Text.Contains("@"))
                {
                    MessageBox.Show("Ingrese un correo electrónico válido", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            };
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(textBoxCarnet.Text))
            {
                MessageBox.Show("El CARNET es obligatorio", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCarnet.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show("El NOMBRE es obligatorio", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxApellido.Text))
            {
                MessageBox.Show("El APELLIDO es obligatorio", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxApellido.Focus();
                return false;
            }

            if (comboBoxSeccion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una sección", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxSeccion.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxCorreo.Text) || !textBoxCorreo.Text.Contains("@"))
            {
                MessageBox.Show("Ingrese un correo electrónico válido", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCorreo.Focus();
                return false;
            }

            return true;
        }

        private void buttonGuardarAlumno_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCancelarAlumno_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}