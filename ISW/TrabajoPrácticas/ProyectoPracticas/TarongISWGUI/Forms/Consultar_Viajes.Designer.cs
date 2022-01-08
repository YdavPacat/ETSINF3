
namespace TarongISWGUI.Forms
{
    partial class Consultar_Viajes
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
            this.ini_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fin_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.camiones_dataGridView = new System.Windows.Forms.DataGridView();
            this.parcela_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCajas_Columns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPeso_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula_comboBox = new System.Windows.Forms.ComboBox();
            this.matricula_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.camiones_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ini_dateTimePicker
            // 
            this.ini_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ini_dateTimePicker.Location = new System.Drawing.Point(271, 54);
            this.ini_dateTimePicker.Name = "ini_dateTimePicker";
            this.ini_dateTimePicker.Size = new System.Drawing.Size(154, 22);
            this.ini_dateTimePicker.TabIndex = 1;
            this.ini_dateTimePicker.ValueChanged += new System.EventHandler(this.matricula_comboBox_SelectedIndexChanged);
            // 
            // fin_dateTimePicker
            // 
            this.fin_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fin_dateTimePicker.Location = new System.Drawing.Point(533, 54);
            this.fin_dateTimePicker.Name = "fin_dateTimePicker";
            this.fin_dateTimePicker.Size = new System.Drawing.Size(154, 22);
            this.fin_dateTimePicker.TabIndex = 2;
            this.fin_dateTimePicker.ValueChanged += new System.EventHandler(this.matricula_comboBox_SelectedIndexChanged);
            // 
            // camiones_dataGridView
            // 
            this.camiones_dataGridView.AllowUserToAddRows = false;
            this.camiones_dataGridView.AllowUserToDeleteRows = false;
            this.camiones_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.camiones_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parcela_column,
            this.fecha_Column,
            this.numCajas_Columns,
            this.totalPeso_Column});
            this.camiones_dataGridView.GridColor = System.Drawing.Color.AliceBlue;
            this.camiones_dataGridView.Location = new System.Drawing.Point(26, 112);
            this.camiones_dataGridView.Name = "camiones_dataGridView";
            this.camiones_dataGridView.RowHeadersVisible = false;
            this.camiones_dataGridView.RowHeadersWidth = 51;
            this.camiones_dataGridView.RowTemplate.Height = 24;
            this.camiones_dataGridView.Size = new System.Drawing.Size(661, 178);
            this.camiones_dataGridView.TabIndex = 3;
            // 
            // parcela_column
            // 
            this.parcela_column.DataPropertyName = "parcela_dp";
            this.parcela_column.HeaderText = "Parcela";
            this.parcela_column.MinimumWidth = 6;
            this.parcela_column.Name = "parcela_column";
            this.parcela_column.ReadOnly = true;
            this.parcela_column.Width = 125;
            // 
            // fecha_Column
            // 
            this.fecha_Column.DataPropertyName = "fecha_dp";
            this.fecha_Column.HeaderText = "Fecha";
            this.fecha_Column.MinimumWidth = 6;
            this.fecha_Column.Name = "fecha_Column";
            this.fecha_Column.Width = 125;
            // 
            // numCajas_Columns
            // 
            this.numCajas_Columns.DataPropertyName = "cajas_dp";
            this.numCajas_Columns.HeaderText = "Nº de cajas";
            this.numCajas_Columns.MinimumWidth = 6;
            this.numCajas_Columns.Name = "numCajas_Columns";
            this.numCajas_Columns.Width = 125;
            // 
            // totalPeso_Column
            // 
            this.totalPeso_Column.DataPropertyName = "peso_dp";
            this.totalPeso_Column.HeaderText = "Peso total";
            this.totalPeso_Column.MinimumWidth = 6;
            this.totalPeso_Column.Name = "totalPeso_Column";
            this.totalPeso_Column.Width = 125;
            // 
            // matricula_comboBox
            // 
            this.matricula_comboBox.FormattingEnabled = true;
            this.matricula_comboBox.Location = new System.Drawing.Point(26, 56);
            this.matricula_comboBox.Name = "matricula_comboBox";
            this.matricula_comboBox.Size = new System.Drawing.Size(139, 24);
            this.matricula_comboBox.TabIndex = 4;
            this.matricula_comboBox.SelectedIndexChanged += new System.EventHandler(this.matricula_comboBox_SelectedIndexChanged);
            // 
            // matricula_label
            // 
            this.matricula_label.AutoSize = true;
            this.matricula_label.Location = new System.Drawing.Point(23, 34);
            this.matricula_label.Name = "matricula_label";
            this.matricula_label.Size = new System.Drawing.Size(69, 17);
            this.matricula_label.TabIndex = 5;
            this.matricula_label.Text = "Matricula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha fin:";
            // 
            // Consultar_Viajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(718, 325);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matricula_label);
            this.Controls.Add(this.matricula_comboBox);
            this.Controls.Add(this.camiones_dataGridView);
            this.Controls.Add(this.fin_dateTimePicker);
            this.Controls.Add(this.ini_dateTimePicker);
            this.Name = "Consultar_Viajes";
            this.ShowIcon = false;
            this.Text = "Consultar viajes";
            ((System.ComponentModel.ISupportInitialize)(this.camiones_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker ini_dateTimePicker;
        private System.Windows.Forms.DateTimePicker fin_dateTimePicker;
        private System.Windows.Forms.DataGridView camiones_dataGridView;
        private System.Windows.Forms.ComboBox matricula_comboBox;
        private System.Windows.Forms.Label matricula_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcela_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCajas_Columns;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPeso_Column;
    }
}