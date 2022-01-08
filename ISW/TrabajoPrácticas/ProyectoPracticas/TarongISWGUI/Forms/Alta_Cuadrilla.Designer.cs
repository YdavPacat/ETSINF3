
namespace TarongISWGUI.Forms
{
    partial class Alta_Cuadrilla
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Fecha_timePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.AñadirPersona_Button = new System.Windows.Forms.Button();
            this.miembrosAñadidos_Grid = new System.Windows.Forms.DataGridView();
            this.DNI_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Parcela_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eliminarMiembro_Button = new System.Windows.Forms.Button();
            this.DNI_comboBox = new System.Windows.Forms.ComboBox();
            this.crearCuadrilla_button = new System.Windows.Forms.Button();
            this.cancelar_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.miembrosAñadidos_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parcela:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha: ";
            // 
            // Fecha_timePicker
            // 
            this.Fecha_timePicker.Location = new System.Drawing.Point(74, 63);
            this.Fecha_timePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Fecha_timePicker.Name = "Fecha_timePicker";
            this.Fecha_timePicker.Size = new System.Drawing.Size(221, 20);
            this.Fecha_timePicker.TabIndex = 4;
            this.Fecha_timePicker.ValueChanged += new System.EventHandler(this.Fecha_timePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DNI:";
            // 
            // AñadirPersona_Button
            // 
            this.AñadirPersona_Button.Location = new System.Drawing.Point(310, 16);
            this.AñadirPersona_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AñadirPersona_Button.Name = "AñadirPersona_Button";
            this.AñadirPersona_Button.Size = new System.Drawing.Size(86, 36);
            this.AñadirPersona_Button.TabIndex = 8;
            this.AñadirPersona_Button.Text = "Añadir Miembro";
            this.AñadirPersona_Button.UseVisualStyleBackColor = true;
            this.AñadirPersona_Button.Click += new System.EventHandler(this.AñadirPersona_Button_Click);
            // 
            // miembrosAñadidos_Grid
            // 
            this.miembrosAñadidos_Grid.AllowUserToAddRows = false;
            this.miembrosAñadidos_Grid.AllowUserToDeleteRows = false;
            this.miembrosAñadidos_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.miembrosAñadidos_Grid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.miembrosAñadidos_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.miembrosAñadidos_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI_column,
            this.Nombre_column});
            this.miembrosAñadidos_Grid.Location = new System.Drawing.Point(15, 63);
            this.miembrosAñadidos_Grid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.miembrosAñadidos_Grid.MultiSelect = false;
            this.miembrosAñadidos_Grid.Name = "miembrosAñadidos_Grid";
            this.miembrosAñadidos_Grid.ReadOnly = true;
            this.miembrosAñadidos_Grid.RowHeadersWidth = 51;
            this.miembrosAñadidos_Grid.RowTemplate.Height = 24;
            this.miembrosAñadidos_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.miembrosAñadidos_Grid.Size = new System.Drawing.Size(279, 190);
            this.miembrosAñadidos_Grid.TabIndex = 9;
            // 
            // DNI_column
            // 
            this.DNI_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DNI_column.HeaderText = "DNI";
            this.DNI_column.MinimumWidth = 80;
            this.DNI_column.Name = "DNI_column";
            this.DNI_column.ReadOnly = true;
            this.DNI_column.Width = 80;
            // 
            // Nombre_column
            // 
            this.Nombre_column.HeaderText = "Nombre";
            this.Nombre_column.MinimumWidth = 6;
            this.Nombre_column.Name = "Nombre_column";
            this.Nombre_column.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Parcela_comboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Fecha_timePicker);
            this.groupBox1.Location = new System.Drawing.Point(17, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(413, 106);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar parcela de trabajo:";
            // 
            // Parcela_comboBox
            // 
            this.Parcela_comboBox.FormattingEnabled = true;
            this.Parcela_comboBox.Location = new System.Drawing.Point(74, 24);
            this.Parcela_comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Parcela_comboBox.Name = "Parcela_comboBox";
            this.Parcela_comboBox.Size = new System.Drawing.Size(221, 21);
            this.Parcela_comboBox.TabIndex = 6;
            this.Parcela_comboBox.SelectedIndexChanged += new System.EventHandler(this.Parcela_comboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.eliminarMiembro_Button);
            this.groupBox2.Controls.Add(this.DNI_comboBox);
            this.groupBox2.Controls.Add(this.AñadirPersona_Button);
            this.groupBox2.Controls.Add(this.miembrosAñadidos_Grid);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(17, 138);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(413, 265);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Añadir miembro a la cuadrilla:";
            // 
            // eliminarMiembro_Button
            // 
            this.eliminarMiembro_Button.Location = new System.Drawing.Point(310, 63);
            this.eliminarMiembro_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eliminarMiembro_Button.Name = "eliminarMiembro_Button";
            this.eliminarMiembro_Button.Size = new System.Drawing.Size(86, 47);
            this.eliminarMiembro_Button.TabIndex = 11;
            this.eliminarMiembro_Button.Text = "Eliminar miembro";
            this.eliminarMiembro_Button.UseVisualStyleBackColor = true;
            this.eliminarMiembro_Button.Click += new System.EventHandler(this.eliminarMiembro_Button_Click);
            // 
            // DNI_comboBox
            // 
            this.DNI_comboBox.FormattingEnabled = true;
            this.DNI_comboBox.Location = new System.Drawing.Point(74, 25);
            this.DNI_comboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DNI_comboBox.Name = "DNI_comboBox";
            this.DNI_comboBox.Size = new System.Drawing.Size(221, 21);
            this.DNI_comboBox.TabIndex = 10;
            // 
            // crearCuadrilla_button
            // 
            this.crearCuadrilla_button.Location = new System.Drawing.Point(302, 422);
            this.crearCuadrilla_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.crearCuadrilla_button.Name = "crearCuadrilla_button";
            this.crearCuadrilla_button.Size = new System.Drawing.Size(105, 22);
            this.crearCuadrilla_button.TabIndex = 12;
            this.crearCuadrilla_button.Text = "Crear cuadrilla";
            this.crearCuadrilla_button.UseVisualStyleBackColor = true;
            this.crearCuadrilla_button.Click += new System.EventHandler(this.crearCuadrilla_button_Click);
            // 
            // cancelar_button
            // 
            this.cancelar_button.Location = new System.Drawing.Point(17, 422);
            this.cancelar_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelar_button.Name = "cancelar_button";
            this.cancelar_button.Size = new System.Drawing.Size(79, 22);
            this.cancelar_button.TabIndex = 13;
            this.cancelar_button.Text = "Cancelar";
            this.cancelar_button.UseVisualStyleBackColor = true;
            this.cancelar_button.Click += new System.EventHandler(this.cancelar_button_Click);
            // 
            // Alta_Cuadrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(446, 467);
            this.Controls.Add(this.cancelar_button);
            this.Controls.Add(this.crearCuadrilla_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Alta_Cuadrilla";
            this.ShowIcon = false;
            this.Text = "Crear cuadrilla";
            ((System.ComponentModel.ISupportInitialize)(this.miembrosAñadidos_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Fecha_timePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AñadirPersona_Button;
        private System.Windows.Forms.DataGridView miembrosAñadidos_Grid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Parcela_comboBox;
        private System.Windows.Forms.ComboBox DNI_comboBox;
        private System.Windows.Forms.Button crearCuadrilla_button;
        private System.Windows.Forms.Button cancelar_button;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private System.Windows.Forms.Button eliminarMiembro_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_column;
    }
}