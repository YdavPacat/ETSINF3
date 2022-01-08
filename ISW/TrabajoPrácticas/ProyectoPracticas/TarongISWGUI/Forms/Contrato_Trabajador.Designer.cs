
namespace TarongISWGUI.Forms
{
    partial class Contrato_Trabajador
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
            this.cuenta_bancaria = new System.Windows.Forms.TextBox();
            this.seguridad_social = new System.Windows.Forms.TextBox();
            this.contrato = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.dar_alta = new System.Windows.Forms.LinkLabel();
            this.dni = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.salario = new System.Windows.Forms.NumericUpDown();
            this.fecha_fin_nula = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.salario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI: ";
            // 
            // cuenta_bancaria
            // 
            this.cuenta_bancaria.Enabled = false;
            this.cuenta_bancaria.Location = new System.Drawing.Point(133, 119);
            this.cuenta_bancaria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cuenta_bancaria.Name = "cuenta_bancaria";
            this.cuenta_bancaria.Size = new System.Drawing.Size(101, 20);
            this.cuenta_bancaria.TabIndex = 4;
            // 
            // seguridad_social
            // 
            this.seguridad_social.Enabled = false;
            this.seguridad_social.Location = new System.Drawing.Point(133, 155);
            this.seguridad_social.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.seguridad_social.Name = "seguridad_social";
            this.seguridad_social.Size = new System.Drawing.Size(101, 20);
            this.seguridad_social.TabIndex = 5;
            // 
            // contrato
            // 
            this.contrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contrato.Enabled = false;
            this.contrato.FormattingEnabled = true;
            this.contrato.Items.AddRange(new object[] {
            "Temporal",
            "Permanente"});
            this.contrato.Location = new System.Drawing.Point(133, 80);
            this.contrato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contrato.Name = "contrato";
            this.contrato.Size = new System.Drawing.Size(101, 21);
            this.contrato.TabIndex = 7;
            this.contrato.SelectedIndexChanged += new System.EventHandler(this.contrato_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cuenta bancaria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nº Seguridad Social:";
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fecha_inicio.Enabled = false;
            this.fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_inicio.Location = new System.Drawing.Point(133, 193);
            this.fecha_inicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fecha_inicio.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.fecha_inicio.Name = "fecha_inicio";
            this.fecha_inicio.Size = new System.Drawing.Size(101, 20);
            this.fecha_inicio.TabIndex = 11;
            this.fecha_inicio.Value = new System.DateTime(2021, 12, 20, 0, 0, 0, 0);
            // 
            // fecha_fin
            // 
            this.fecha_fin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fecha_fin.Enabled = false;
            this.fecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_fin.Location = new System.Drawing.Point(133, 232);
            this.fecha_fin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fecha_fin.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.fecha_fin.Name = "fecha_fin";
            this.fecha_fin.Size = new System.Drawing.Size(101, 20);
            this.fecha_fin.TabIndex = 12;
            this.fecha_fin.Value = new System.DateTime(2021, 12, 20, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha inicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha fin:";
            // 
            // cancelar
            // 
            this.cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelar.Location = new System.Drawing.Point(64, 324);
            this.cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(63, 19);
            this.cancelar.TabIndex = 15;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // guardar
            // 
            this.guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guardar.Location = new System.Drawing.Point(189, 324);
            this.guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(62, 19);
            this.guardar.TabIndex = 16;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // dar_alta
            // 
            this.dar_alta.AutoSize = true;
            this.dar_alta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dar_alta.Location = new System.Drawing.Point(131, 55);
            this.dar_alta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dar_alta.Name = "dar_alta";
            this.dar_alta.Size = new System.Drawing.Size(59, 13);
            this.dar_alta.TabIndex = 18;
            this.dar_alta.TabStop = true;
            this.dar_alta.Text = "Dar de alta";
            this.dar_alta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dar_alta_LinkClicked);
            // 
            // dni
            // 
            this.dni.BackColor = System.Drawing.SystemColors.Window;
            this.dni.FormattingEnabled = true;
            this.dni.Location = new System.Drawing.Point(133, 34);
            this.dni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(101, 21);
            this.dni.TabIndex = 19;
            this.dni.SelectedIndexChanged += new System.EventHandler(this.dni_SelectedIndexChanged);
            this.dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dniBuscar);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Salario:";
            // 
            // salario
            // 
            this.salario.Enabled = false;
            this.salario.Location = new System.Drawing.Point(133, 286);
            this.salario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salario.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(100, 20);
            this.salario.TabIndex = 21;
            // 
            // fecha_fin_nula
            // 
            this.fecha_fin_nula.AutoSize = true;
            this.fecha_fin_nula.Enabled = false;
            this.fecha_fin_nula.Location = new System.Drawing.Point(134, 254);
            this.fecha_fin_nula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fecha_fin_nula.Name = "fecha_fin_nula";
            this.fecha_fin_nula.Size = new System.Drawing.Size(93, 17);
            this.fecha_fin_nula.TabIndex = 23;
            this.fecha_fin_nula.Text = "Sin fecha final";
            this.fecha_fin_nula.UseVisualStyleBackColor = true;
            this.fecha_fin_nula.CheckedChanged += new System.EventHandler(this.fecha_fin_nula_CheckedChanged);
            // 
            // Contrato_Trabajador
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(311, 380);
            this.Controls.Add(this.fecha_fin_nula);
            this.Controls.Add(this.salario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.dar_alta);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fecha_fin);
            this.Controls.Add(this.fecha_inicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contrato);
            this.Controls.Add(this.seguridad_social);
            this.Controls.Add(this.cuenta_bancaria);
            this.Controls.Add(this.label1);
            this.Name = "Contrato_Trabajador";
            this.ShowIcon = false;
            this.Text = "Crear contrato";
            ((System.ComponentModel.ISupportInitialize)(this.salario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cuenta_bancaria;
        private System.Windows.Forms.TextBox seguridad_social;
        private System.Windows.Forms.ComboBox contrato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fecha_inicio;
        private System.Windows.Forms.DateTimePicker fecha_fin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.LinkLabel dar_alta;
        private System.Windows.Forms.ComboBox dni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown salario;
        private System.Windows.Forms.CheckBox fecha_fin_nula;
    }
}