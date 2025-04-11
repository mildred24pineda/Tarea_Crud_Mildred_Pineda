namespace Tarea_crud_
{
    partial class FormEditarAlumno
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelCarnet = new System.Windows.Forms.Label();
            this.textBoxCarnet = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.buttonCancelarAlumno = new System.Windows.Forms.Button();
            this.buttonGuardarAlumno = new System.Windows.Forms.Button();
            this.labelSeccion = new System.Windows.Forms.Label();
            this.comboBoxSeccion = new System.Windows.Forms.ComboBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCarnet
            // 
            this.labelCarnet.AutoSize = true;
            this.labelCarnet.Location = new System.Drawing.Point(20, 20);
            this.labelCarnet.Name = "labelCarnet";
            this.labelCarnet.Size = new System.Drawing.Size(54, 13);
            this.labelCarnet.TabIndex = 0;
            this.labelCarnet.Text = "CARNET:";
            // 
            // textBoxCarnet
            // 
            this.textBoxCarnet.Location = new System.Drawing.Point(100, 17);
            this.textBoxCarnet.MaxLength = 12;
            this.textBoxCarnet.Name = "textBoxCarnet";
            this.textBoxCarnet.Size = new System.Drawing.Size(200, 20);
            this.textBoxCarnet.TabIndex = 1;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(20, 50);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(57, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "NOMBRE:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(100, 47);
            this.textBoxNombre.MaxLength = 50;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(100, 77);
            this.textBoxApellido.MaxLength = 50;
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(200, 20);
            this.textBoxApellido.TabIndex = 3;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(20, 80);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(62, 13);
            this.labelApellido.TabIndex = 4;
            this.labelApellido.Text = "APELLIDO:";
            // 
            // buttonCancelarAlumno
            // 
            this.buttonCancelarAlumno.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCancelarAlumno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarAlumno.Location = new System.Drawing.Point(180, 200);
            this.buttonCancelarAlumno.Name = "buttonCancelarAlumno";
            this.buttonCancelarAlumno.Size = new System.Drawing.Size(90, 30);
            this.buttonCancelarAlumno.TabIndex = 6;
            this.buttonCancelarAlumno.Text = "CANCELAR";
            this.buttonCancelarAlumno.UseVisualStyleBackColor = false;
            // 
            // buttonGuardarAlumno
            // 
            this.buttonGuardarAlumno.BackColor = System.Drawing.Color.LightGreen;
            this.buttonGuardarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardarAlumno.Location = new System.Drawing.Point(80, 200);
            this.buttonGuardarAlumno.Name = "buttonGuardarAlumno";
            this.buttonGuardarAlumno.Size = new System.Drawing.Size(90, 30);
            this.buttonGuardarAlumno.TabIndex = 5;
            this.buttonGuardarAlumno.Text = "GUARDAR";
            this.buttonGuardarAlumno.UseVisualStyleBackColor = false;
            // 
            // labelSeccion
            // 
            this.labelSeccion.AutoSize = true;
            this.labelSeccion.Location = new System.Drawing.Point(20, 110);
            this.labelSeccion.Name = "labelSeccion";
            this.labelSeccion.Size = new System.Drawing.Size(57, 13);
            this.labelSeccion.TabIndex = 6;
            this.labelSeccion.Text = "SECCIÓN:";
            // 
            // comboBoxSeccion
            // 
            this.comboBoxSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeccion.FormattingEnabled = true;
            this.comboBoxSeccion.Location = new System.Drawing.Point(100, 107);
            this.comboBoxSeccion.Name = "comboBoxSeccion";
            this.comboBoxSeccion.Size = new System.Drawing.Size(60, 21);
            this.comboBoxSeccion.TabIndex = 4;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Location = new System.Drawing.Point(20, 140);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(56, 13);
            this.labelCorreo.TabIndex = 8;
            this.labelCorreo.Text = "CORREO:";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(100, 137);
            this.textBoxCorreo.MaxLength = 100;
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(200, 20);
            this.textBoxCorreo.TabIndex = 5;
            // 
            // FormEditarAlumno
            // 
            this.AcceptButton = this.buttonGuardarAlumno;
            this.CancelButton = this.buttonCancelarAlumno;
            this.ClientSize = new System.Drawing.Size(456, 312);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.comboBoxSeccion);
            this.Controls.Add(this.labelSeccion);
            this.Controls.Add(this.buttonGuardarAlumno);
            this.Controls.Add(this.buttonCancelarAlumno);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxCarnet);
            this.Controls.Add(this.labelCarnet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditarAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Alumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCarnet;
        private System.Windows.Forms.TextBox textBoxCarnet;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Button buttonCancelarAlumno;
        private System.Windows.Forms.Button buttonGuardarAlumno;
        private System.Windows.Forms.Label labelSeccion;
        private System.Windows.Forms.ComboBox comboBoxSeccion;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.TextBox textBoxCorreo;
    }
}