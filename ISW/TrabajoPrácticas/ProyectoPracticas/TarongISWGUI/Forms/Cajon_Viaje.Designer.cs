
namespace TarongISWGUI.Forms
{
    partial class Cajon_Viaje
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.matricula_comboBox = new System.Windows.Forms.ComboBox();
            this.DNI_comboBox = new System.Windows.Forms.ComboBox();
            this.parcela_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.producto_textBox = new System.Windows.Forms.TextBox();
            this.peso_textBox = new System.Windows.Forms.TextBox();
            this.Peso_label = new System.Windows.Forms.Label();
            this.Producto_label = new System.Windows.Forms.Label();
            this.Cancelar_button = new System.Windows.Forms.Button();
            this.Aceptar_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.matricula_comboBox);
            this.groupBox1.Controls.Add(this.DNI_comboBox);
            this.groupBox1.Controls.Add(this.parcela_comboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(375, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // matricula_comboBox
            // 
            this.matricula_comboBox.FormattingEnabled = true;
            this.matricula_comboBox.Location = new System.Drawing.Point(92, 144);
            this.matricula_comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matricula_comboBox.Name = "matricula_comboBox";
            this.matricula_comboBox.Size = new System.Drawing.Size(251, 24);
            this.matricula_comboBox.TabIndex = 10;
            this.matricula_comboBox.SelectedIndexChanged += new System.EventHandler(this.matricula_comboBox_SelectedIndexChanged);
            this.matricula_comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matriculaBuscar);
            // 
            // DNI_comboBox
            // 
            this.DNI_comboBox.FormattingEnabled = true;
            this.DNI_comboBox.Location = new System.Drawing.Point(92, 85);
            this.DNI_comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DNI_comboBox.Name = "DNI_comboBox";
            this.DNI_comboBox.Size = new System.Drawing.Size(251, 24);
            this.DNI_comboBox.TabIndex = 9;
            this.DNI_comboBox.SelectedIndexChanged += new System.EventHandler(this.DNI_comboBox_SelectedIndexChanged);
            this.DNI_comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dniBuscar);
            // 
            // parcela_comboBox
            // 
            this.parcela_comboBox.FormattingEnabled = true;
            this.parcela_comboBox.Location = new System.Drawing.Point(92, 31);
            this.parcela_comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.parcela_comboBox.Name = "parcela_comboBox";
            this.parcela_comboBox.Size = new System.Drawing.Size(251, 24);
            this.parcela_comboBox.TabIndex = 8;
            this.parcela_comboBox.SelectedIndexChanged += new System.EventHandler(this.parcela_comboBox_SelectedIndexChanged);
            this.parcela_comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.parcelaBuscar);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Matrícula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "DNI:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Parcela:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.producto_textBox);
            this.groupBox2.Controls.Add(this.peso_textBox);
            this.groupBox2.Controls.Add(this.Peso_label);
            this.groupBox2.Controls.Add(this.Producto_label);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(16, 217);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(375, 142);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de la caja";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // producto_textBox
            // 
            this.producto_textBox.Location = new System.Drawing.Point(92, 33);
            this.producto_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.producto_textBox.Name = "producto_textBox";
            this.producto_textBox.ReadOnly = true;
            this.producto_textBox.Size = new System.Drawing.Size(132, 26);
            this.producto_textBox.TabIndex = 4;
            // 
            // peso_textBox
            // 
            this.peso_textBox.Location = new System.Drawing.Point(92, 90);
            this.peso_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.peso_textBox.Name = "peso_textBox";
            this.peso_textBox.Size = new System.Drawing.Size(132, 26);
            this.peso_textBox.TabIndex = 2;
            this.peso_textBox.TextChanged += new System.EventHandler(this.peso_textBox_TextChanged);
            // 
            // Peso_label
            // 
            this.Peso_label.AutoSize = true;
            this.Peso_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Peso_label.Location = new System.Drawing.Point(39, 96);
            this.Peso_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Peso_label.Name = "Peso_label";
            this.Peso_label.Size = new System.Drawing.Size(44, 17);
            this.Peso_label.TabIndex = 1;
            this.Peso_label.Text = "Peso:";
            // 
            // Producto_label
            // 
            this.Producto_label.AutoSize = true;
            this.Producto_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Producto_label.Location = new System.Drawing.Point(13, 39);
            this.Producto_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Producto_label.Name = "Producto_label";
            this.Producto_label.Size = new System.Drawing.Size(69, 17);
            this.Producto_label.TabIndex = 0;
            this.Producto_label.Text = "Producto:";
            this.Producto_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // Cancelar_button
            // 
            this.Cancelar_button.Location = new System.Drawing.Point(16, 366);
            this.Cancelar_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancelar_button.Name = "Cancelar_button";
            this.Cancelar_button.Size = new System.Drawing.Size(100, 28);
            this.Cancelar_button.TabIndex = 0;
            this.Cancelar_button.Text = "Cancelar";
            this.Cancelar_button.UseVisualStyleBackColor = true;
            this.Cancelar_button.Click += new System.EventHandler(this.Cancelar_button_Click);
            // 
            // Aceptar_button
            // 
            this.Aceptar_button.Enabled = false;
            this.Aceptar_button.Location = new System.Drawing.Point(291, 366);
            this.Aceptar_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Aceptar_button.Name = "Aceptar_button";
            this.Aceptar_button.Size = new System.Drawing.Size(100, 28);
            this.Aceptar_button.TabIndex = 1;
            this.Aceptar_button.Text = "Aceptar";
            this.Aceptar_button.UseVisualStyleBackColor = true;
            this.Aceptar_button.Click += new System.EventHandler(this.Aceptar_button_Click);
            // 
            // Cajon_Viaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(428, 411);
            this.Controls.Add(this.Aceptar_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Cancelar_button);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cajon_Viaje";
            this.ShowIcon = false;
            this.Text = "Añadir cajón a viaje";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelar_button;
        private System.Windows.Forms.Button Aceptar_button;
        private System.Windows.Forms.Label Peso_label;
        private System.Windows.Forms.Label Producto_label;
        private System.Windows.Forms.ComboBox matricula_comboBox;
        private System.Windows.Forms.ComboBox DNI_comboBox;
        private System.Windows.Forms.ComboBox parcela_comboBox;
        private System.Windows.Forms.TextBox peso_textBox;
        private System.Windows.Forms.TextBox producto_textBox;
    }
}