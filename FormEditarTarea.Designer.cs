using System;

namespace Tarea_crud_
{
    partial class FormEditarTarea
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
            this.comboBoxCarnet = new System.Windows.Forms.ComboBox();
            this.labelNota1 = new System.Windows.Forms.Label();
            this.textBoxNota1 = new System.Windows.Forms.TextBox();
            this.labelNota2 = new System.Windows.Forms.Label();
            this.textBoxNota2 = new System.Windows.Forms.TextBox();
            this.labelNota3 = new System.Windows.Forms.Label();
            this.textBoxNota3 = new System.Windows.Forms.TextBox();
            this.labelNota4 = new System.Windows.Forms.Label();
            this.textBoxNota4 = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
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
            // comboBoxCarnet
            // 
            this.comboBoxCarnet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarnet.FormattingEnabled = true;
            this.comboBoxCarnet.Location = new System.Drawing.Point(100, 17);
            this.comboBoxCarnet.Name = "comboBoxCarnet";
            this.comboBoxCarnet.Size = new System.Drawing.Size(150, 21);
            this.comboBoxCarnet.TabIndex = 1;
            // 
            // labelNota1
            // 
            this.labelNota1.AutoSize = true;
            this.labelNota1.Location = new System.Drawing.Point(20, 60);
            this.labelNota1.Name = "labelNota1";
            this.labelNota1.Size = new System.Drawing.Size(52, 13);
            this.labelNota1.TabIndex = 2;
            this.labelNota1.Text = "NOTA_1:";
            // 
            // textBoxNota1
            // 
            this.textBoxNota1.Location = new System.Drawing.Point(100, 57);
            this.textBoxNota1.Name = "textBoxNota1";
            this.textBoxNota1.Size = new System.Drawing.Size(60, 20);
            this.textBoxNota1.TabIndex = 2;
            this.textBoxNota1.Text = "";
            // 
            // labelNota2
            // 
            this.labelNota2.AutoSize = true;
            this.labelNota2.Location = new System.Drawing.Point(20, 90);
            this.labelNota2.Name = "labelNota2";
            this.labelNota2.Size = new System.Drawing.Size(52, 13);
            this.labelNota2.TabIndex = 4;
            this.labelNota2.Text = "NOTA_2:";
            // 
            // textBoxNota2
            // 
            this.textBoxNota2.Location = new System.Drawing.Point(100, 87);
            this.textBoxNota2.Name = "textBoxNota2";
            this.textBoxNota2.Size = new System.Drawing.Size(60, 20);
            this.textBoxNota2.TabIndex = 3;
            this.textBoxNota2.Text = "";
            // 
            // labelNota3
            // 
            this.labelNota3.AutoSize = true;
            this.labelNota3.Location = new System.Drawing.Point(20, 120);
            this.labelNota3.Name = "labelNota3";
            this.labelNota3.Size = new System.Drawing.Size(52, 13);
            this.labelNota3.TabIndex = 6;
            this.labelNota3.Text = "NOTA_3:";
            // 
            // textBoxNota3
            // 
            this.textBoxNota3.Location = new System.Drawing.Point(100, 117);
            this.textBoxNota3.Name = "textBoxNota3";
            this.textBoxNota3.Size = new System.Drawing.Size(60, 20);
            this.textBoxNota3.TabIndex = 4;
            this.textBoxNota3.Text = "";
            // 
            // labelNota4
            // 
            this.labelNota4.AutoSize = true;
            this.labelNota4.Location = new System.Drawing.Point(20, 150);
            this.labelNota4.Name = "labelNota4";
            this.labelNota4.Size = new System.Drawing.Size(52, 13);
            this.labelNota4.TabIndex = 8;
            this.labelNota4.Text = "NOTA_4:";
            // 
            // textBoxNota4
            // 
            this.textBoxNota4.Location = new System.Drawing.Point(100, 147);
            this.textBoxNota4.Name = "textBoxNota4";
            this.textBoxNota4.Size = new System.Drawing.Size(60, 20);
            this.textBoxNota4.TabIndex = 5;
            this.textBoxNota4.Text = "";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Location = new System.Drawing.Point(100, 200);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(90, 30);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(208, 200);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(90, 30);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // FormEditarTarea
            // 
            this.AcceptButton = this.buttonGuardar;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(924, 301);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxNota4);
            this.Controls.Add(this.labelNota4);
            this.Controls.Add(this.textBoxNota3);
            this.Controls.Add(this.labelNota3);
            this.Controls.Add(this.textBoxNota2);
            this.Controls.Add(this.labelNota2);
            this.Controls.Add(this.textBoxNota1);
            this.Controls.Add(this.labelNota1);
            this.Controls.Add(this.comboBoxCarnet);
            this.Controls.Add(this.labelCarnet);
            this.Name = "FormEditarTarea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCarnet;
        private System.Windows.Forms.ComboBox comboBoxCarnet;
        private System.Windows.Forms.Label labelNota1;
        private System.Windows.Forms.TextBox textBoxNota1;
        private System.Windows.Forms.Label labelNota2;
        private System.Windows.Forms.TextBox textBoxNota2;
        private System.Windows.Forms.Label labelNota3;
        private System.Windows.Forms.TextBox textBoxNota3;
        private System.Windows.Forms.Label labelNota4;
        private System.Windows.Forms.TextBox textBoxNota4;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}