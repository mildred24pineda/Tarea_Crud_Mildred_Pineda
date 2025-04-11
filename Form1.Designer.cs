namespace Tarea_crud_
{
    partial class Form1
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
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.textBuscarAlumno = new System.Windows.Forms.TextBox();
            this.buttonBuscarAlumno = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.comboBoxSeccion = new System.Windows.Forms.ComboBox();
            this.labelSeccion = new System.Windows.Forms.Label();
            this.dataGridViewTareas = new System.Windows.Forms.DataGridView();
            this.textBuscarTarea = new System.Windows.Forms.TextBox();
            this.buttonBuscarTarea = new System.Windows.Forms.Button();
            this.buttonAgregarTarea = new System.Windows.Forms.Button();
            this.labelAlumnos = new System.Windows.Forms.Label();
            this.labelTareas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlumnos
            // 
            this.dataGridViewAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(20, 114);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(850, 200);
            this.dataGridViewAlumnos.TabIndex = 0;
            // 
            // textBuscarAlumno
            // 
            this.textBuscarAlumno.Location = new System.Drawing.Point(20, 70);
            this.textBuscarAlumno.Name = "textBuscarAlumno";
            this.textBuscarAlumno.Size = new System.Drawing.Size(200, 20);
            this.textBuscarAlumno.TabIndex = 1;
            // 
            // buttonBuscarAlumno
            // 
            this.buttonBuscarAlumno.Location = new System.Drawing.Point(230, 70);
            this.buttonBuscarAlumno.Name = "buttonBuscarAlumno";
            this.buttonBuscarAlumno.Size = new System.Drawing.Size(100, 23);
            this.buttonBuscarAlumno.TabIndex = 2;
            this.buttonBuscarAlumno.Text = "Buscar Alumno";
            this.buttonBuscarAlumno.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(450, 70);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(300, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(217, 24);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "ALUMNOS Y TAREAS";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(340, 70);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 6;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(540, 70);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 7;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // comboBoxSeccion
            // 
            this.comboBoxSeccion.FormattingEnabled = true;
            this.comboBoxSeccion.Location = new System.Drawing.Point(650, 70);
            this.comboBoxSeccion.Name = "comboBoxSeccion";
            this.comboBoxSeccion.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSeccion.TabIndex = 8;
            // 
            // labelSeccion
            // 
            this.labelSeccion.AutoSize = true;
            this.labelSeccion.Location = new System.Drawing.Point(650, 50);
            this.labelSeccion.Name = "labelSeccion";
            this.labelSeccion.Size = new System.Drawing.Size(49, 13);
            this.labelSeccion.TabIndex = 9;
            this.labelSeccion.Text = "Sección:";
            // 
            // dataGridViewTareas
            // 
            this.dataGridViewTareas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTareas.Location = new System.Drawing.Point(20, 364);
            this.dataGridViewTareas.Name = "dataGridViewTareas";
            this.dataGridViewTareas.Size = new System.Drawing.Size(850, 186);
            this.dataGridViewTareas.TabIndex = 10;
            // 
            // textBuscarTarea
            // 
            this.textBuscarTarea.Location = new System.Drawing.Point(20, 320);
            this.textBuscarTarea.Name = "textBuscarTarea";
            this.textBuscarTarea.Size = new System.Drawing.Size(200, 20);
            this.textBuscarTarea.TabIndex = 11;
            // 
            // buttonBuscarTarea
            // 
            this.buttonBuscarTarea.Location = new System.Drawing.Point(230, 320);
            this.buttonBuscarTarea.Name = "buttonBuscarTarea";
            this.buttonBuscarTarea.Size = new System.Drawing.Size(100, 23);
            this.buttonBuscarTarea.TabIndex = 12;
            this.buttonBuscarTarea.Text = "Buscar Tarea";
            this.buttonBuscarTarea.UseVisualStyleBackColor = true;
            // 
            // buttonAgregarTarea
            // 
            this.buttonAgregarTarea.Location = new System.Drawing.Point(340, 320);
            this.buttonAgregarTarea.Name = "buttonAgregarTarea";
            this.buttonAgregarTarea.Size = new System.Drawing.Size(100, 23);
            this.buttonAgregarTarea.TabIndex = 13;
            this.buttonAgregarTarea.Text = "Agregar Tarea";
            this.buttonAgregarTarea.UseVisualStyleBackColor = true;
            // 
            // labelAlumnos
            // 
            this.labelAlumnos.AutoSize = true;
            this.labelAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumnos.Location = new System.Drawing.Point(20, 93);
            this.labelAlumnos.Name = "labelAlumnos";
            this.labelAlumnos.Size = new System.Drawing.Size(69, 17);
            this.labelAlumnos.TabIndex = 14;
            this.labelAlumnos.Text = "Alumnos";
            // 
            // labelTareas
            // 
            this.labelTareas.AutoSize = true;
            this.labelTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTareas.Location = new System.Drawing.Point(20, 343);
            this.labelTareas.Name = "labelTareas";
            this.labelTareas.Size = new System.Drawing.Size(59, 17);
            this.labelTareas.TabIndex = 15;
            this.labelTareas.Text = "Tareas";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.labelTareas);
            this.Controls.Add(this.labelAlumnos);
            this.Controls.Add(this.buttonAgregarTarea);
            this.Controls.Add(this.buttonBuscarTarea);
            this.Controls.Add(this.textBuscarTarea);
            this.Controls.Add(this.dataGridViewTareas);
            this.Controls.Add(this.labelSeccion);
            this.Controls.Add(this.comboBoxSeccion);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonBuscarAlumno);
            this.Controls.Add(this.textBuscarAlumno);
            this.Controls.Add(this.dataGridViewAlumnos);
            this.Name = "Form1";
            this.Text = "Sistema de Gestión Académica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAlumnos;
        private System.Windows.Forms.TextBox textBuscarAlumno;
        private System.Windows.Forms.Button buttonBuscarAlumno;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ComboBox comboBoxSeccion;
        private System.Windows.Forms.Label labelSeccion;
        private System.Windows.Forms.DataGridView dataGridViewTareas;
        private System.Windows.Forms.TextBox textBuscarTarea;
        private System.Windows.Forms.Button buttonBuscarTarea;
        private System.Windows.Forms.Button buttonAgregarTarea;
        private System.Windows.Forms.Label labelAlumnos;
        private System.Windows.Forms.Label labelTareas;
    }
}