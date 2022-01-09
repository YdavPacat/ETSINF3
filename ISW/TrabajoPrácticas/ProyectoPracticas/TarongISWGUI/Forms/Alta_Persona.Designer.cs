
namespace TarongISWGUI.Forms
{
    partial class Alta_Persona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.dar_alta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "DNI: ";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(101, 53);
            this.dni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(132, 22);
            this.dni.TabIndex = 2;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(101, 95);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(132, 22);
            this.nombre.TabIndex = 4;
            // 
            // cancelar
            // 
            this.cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelar.Location = new System.Drawing.Point(35, 150);
            this.cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(89, 23);
            this.cancelar.TabIndex = 6;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // dar_alta
            // 
            this.dar_alta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dar_alta.Location = new System.Drawing.Point(144, 150);
            this.dar_alta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dar_alta.Name = "dar_alta";
            this.dar_alta.Size = new System.Drawing.Size(89, 23);
            this.dar_alta.TabIndex = 7;
            this.dar_alta.Text = "Dar de alta";
            this.dar_alta.UseVisualStyleBackColor = true;
            this.dar_alta.Click += new System.EventHandler(this.dar_alta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre:";
            // 
            // Alta_Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 228);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dar_alta);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dni);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Alta_Persona";
            this.ShowIcon = false;
            this.Text = "Alta trabajador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button dar_alta;
        private System.Windows.Forms.Label label3;
    }
}