
namespace TarongISWGUI
{
    partial class TarongISWApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadrillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaCuadrillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarCajonAViajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarViajeACamionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarViajesDeCamiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearBDDeEjemploToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contratoToolStripMenuItem,
            this.cuadrillaToolStripMenuItem,
            this.viajeToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(805, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contratoToolStripMenuItem
            // 
            this.contratoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contratoToolStripMenuItem.Name = "contratoToolStripMenuItem";
            this.contratoToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.contratoToolStripMenuItem.Text = "Contrato";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem1.Text = "Alta Contrato";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.altaContrato_Click);
            // 
            // cuadrillaToolStripMenuItem
            // 
            this.cuadrillaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaCuadrillaToolStripMenuItem});
            this.cuadrillaToolStripMenuItem.Name = "cuadrillaToolStripMenuItem";
            this.cuadrillaToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.cuadrillaToolStripMenuItem.Text = "Cuadrilla";
            // 
            // altaCuadrillaToolStripMenuItem
            // 
            this.altaCuadrillaToolStripMenuItem.Name = "altaCuadrillaToolStripMenuItem";
            this.altaCuadrillaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.altaCuadrillaToolStripMenuItem.Text = "Alta Cuadrilla";
            this.altaCuadrillaToolStripMenuItem.Click += new System.EventHandler(this.altaCudrilla_Click);
            // 
            // viajeToolStripMenuItem
            // 
            this.viajeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarCajonAViajeToolStripMenuItem,
            this.asignarViajeACamionToolStripMenuItem1,
            this.consultarViajesDeCamiónToolStripMenuItem});
            this.viajeToolStripMenuItem.Name = "viajeToolStripMenuItem";
            this.viajeToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.viajeToolStripMenuItem.Text = "Viaje";
            // 
            // asignarCajonAViajeToolStripMenuItem
            // 
            this.asignarCajonAViajeToolStripMenuItem.Name = "asignarCajonAViajeToolStripMenuItem";
            this.asignarCajonAViajeToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.asignarCajonAViajeToolStripMenuItem.Text = "Asignar cajón a viaje";
            this.asignarCajonAViajeToolStripMenuItem.Click += new System.EventHandler(this.asignarCajonAViaje_Click);
            // 
            // asignarViajeACamionToolStripMenuItem1
            // 
            this.asignarViajeACamionToolStripMenuItem1.Name = "asignarViajeACamionToolStripMenuItem1";
            this.asignarViajeACamionToolStripMenuItem1.Size = new System.Drawing.Size(269, 26);
            this.asignarViajeACamionToolStripMenuItem1.Text = "Asignar viaje a camion";
            this.asignarViajeACamionToolStripMenuItem1.Click += new System.EventHandler(this.asignarViajeACamion_Click);
            // 
            // consultarViajesDeCamiónToolStripMenuItem
            // 
            this.consultarViajesDeCamiónToolStripMenuItem.Name = "consultarViajesDeCamiónToolStripMenuItem";
            this.consultarViajesDeCamiónToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.consultarViajesDeCamiónToolStripMenuItem.Text = "Consultar viajes de camión";
            this.consultarViajesDeCamiónToolStripMenuItem.Click += new System.EventHandler(this.consultarViajesDeCamion_Cick);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearBDDeEjemploToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // crearBDDeEjemploToolStripMenuItem
            // 
            this.crearBDDeEjemploToolStripMenuItem.Name = "crearBDDeEjemploToolStripMenuItem";
            this.crearBDDeEjemploToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.crearBDDeEjemploToolStripMenuItem.Text = "Crear BD de ejemplo";
            this.crearBDDeEjemploToolStripMenuItem.Click += new System.EventHandler(this.crearBDEjemplo);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salir);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TarongISWApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(805, 462);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TarongISWApp";
            this.ShowIcon = false;
            this.Text = "TarongISW";
            this.Load += new System.EventHandler(this.TarongISWApp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contratoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadrillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaCuadrillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarCajonAViajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarViajeACamionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarViajesDeCamiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearBDDeEjemploToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

