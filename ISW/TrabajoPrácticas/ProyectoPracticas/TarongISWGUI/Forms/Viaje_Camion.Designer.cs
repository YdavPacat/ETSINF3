
namespace TarongISWGUI.Forms
{
    partial class Viaje_Camion
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.llegada = new System.Windows.Forms.DateTimePicker();
            this.salida = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.descarga = new System.Windows.Forms.DateTimePicker();
            this.cancelar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.Matricula_comboBox = new System.Windows.Forms.ComboBox();
            this.salida_checkbox = new System.Windows.Forms.CheckBox();
            this.descarga_checkbox = new System.Windows.Forms.CheckBox();
            this.llegada_checkbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Matrícula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Llegada a la cooperativa:";
            // 
            // llegada
            // 
            this.llegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.llegada.Location = new System.Drawing.Point(195, 93);
            this.llegada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.llegada.Name = "llegada";
            this.llegada.Size = new System.Drawing.Size(200, 22);
            this.llegada.TabIndex = 15;
            // 
            // salida
            // 
            this.salida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.salida.Location = new System.Drawing.Point(195, 157);
            this.salida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(200, 22);
            this.salida.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Salida de la parcela:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Descarga:";
            // 
            // descarga
            // 
            this.descarga.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.descarga.Location = new System.Drawing.Point(195, 225);
            this.descarga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descarga.Name = "descarga";
            this.descarga.Size = new System.Drawing.Size(200, 22);
            this.descarga.TabIndex = 19;
            // 
            // cancelar
            // 
            this.cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelar.Location = new System.Drawing.Point(54, 310);
            this.cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(99, 23);
            this.cancelar.TabIndex = 23;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // guardar
            // 
            this.guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardar.Location = new System.Drawing.Point(299, 310);
            this.guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(96, 23);
            this.guardar.TabIndex = 24;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // Matricula_comboBox
            // 
            this.Matricula_comboBox.FormattingEnabled = true;
            this.Matricula_comboBox.Location = new System.Drawing.Point(195, 45);
            this.Matricula_comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Matricula_comboBox.Name = "Matricula_comboBox";
            this.Matricula_comboBox.Size = new System.Drawing.Size(200, 24);
            this.Matricula_comboBox.TabIndex = 25;
            // 
            // salida_checkbox
            // 
            this.salida_checkbox.AutoSize = true;
            this.salida_checkbox.Location = new System.Drawing.Point(195, 185);
            this.salida_checkbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salida_checkbox.Name = "salida_checkbox";
            this.salida_checkbox.Size = new System.Drawing.Size(150, 21);
            this.salida_checkbox.TabIndex = 29;
            this.salida_checkbox.Text = "Sin fecha de salida";
            this.salida_checkbox.UseVisualStyleBackColor = true;
            this.salida_checkbox.CheckedChanged += new System.EventHandler(this.salida_checkbox_CheckedChanged);
            // 
            // descarga_checkbox
            // 
            this.descarga_checkbox.AutoSize = true;
            this.descarga_checkbox.Location = new System.Drawing.Point(195, 252);
            this.descarga_checkbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descarga_checkbox.Name = "descarga_checkbox";
            this.descarga_checkbox.Size = new System.Drawing.Size(172, 21);
            this.descarga_checkbox.TabIndex = 30;
            this.descarga_checkbox.Text = "Sin fecha de descarga";
            this.descarga_checkbox.UseVisualStyleBackColor = true;
            this.descarga_checkbox.CheckedChanged += new System.EventHandler(this.descarga_checkbox_CheckedChanged);
            // 
            // llegada_checkbox
            // 
            this.llegada_checkbox.AutoSize = true;
            this.llegada_checkbox.Location = new System.Drawing.Point(195, 121);
            this.llegada_checkbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.llegada_checkbox.Name = "llegada_checkbox";
            this.llegada_checkbox.Size = new System.Drawing.Size(159, 21);
            this.llegada_checkbox.TabIndex = 31;
            this.llegada_checkbox.Text = "Sin fecha de llegada";
            this.llegada_checkbox.UseVisualStyleBackColor = true;
            this.llegada_checkbox.CheckedChanged += new System.EventHandler(this.llegada_checkbox_CheckedChanged);
            // 
            // Viaje_Camion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(450, 375);
            this.Controls.Add(this.llegada_checkbox);
            this.Controls.Add(this.descarga_checkbox);
            this.Controls.Add(this.salida_checkbox);
            this.Controls.Add(this.Matricula_comboBox);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.descarga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.llegada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Viaje_Camion";
            this.ShowIcon = false;
            this.Text = "Asignar viajes a camión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker llegada;
        private System.Windows.Forms.DateTimePicker salida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker descarga;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.ComboBox Matricula_comboBox;
        private System.Windows.Forms.CheckBox salida_checkbox;
        private System.Windows.Forms.CheckBox descarga_checkbox;
        private System.Windows.Forms.CheckBox llegada_checkbox;
    }
}