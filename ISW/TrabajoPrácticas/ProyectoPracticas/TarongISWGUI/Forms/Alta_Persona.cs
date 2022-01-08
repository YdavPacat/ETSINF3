using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarongISW.Entities;
using TarongISW.Services;

namespace TarongISWGUI.Forms
{
    public partial class Alta_Persona : Form
    {
        private ITarongISWService service;
        private Contrato_Trabajador contrato;

        public Alta_Persona(Contrato_Trabajador contrato, ITarongISWService service) : this()
        {
            this.service = service;
            this.contrato = contrato;
        }
        
        public Alta_Persona()
        {
            InitializeComponent();
        }

        protected virtual bool fieldsOK()
        {
            return
                !string.IsNullOrEmpty(dni.Text) &&
                !string.IsNullOrEmpty(nombre.Text);
        }

        public virtual void Clear()
        {
            dni.Clear();
            nombre.Clear();
        }

        private void dar_alta_Click(object sender, EventArgs e)
        {
            if (fieldsOK())
            {
                try
                {
                    Person p = new Person(dni.Text, nombre.Text);
                    service.AddPerson(p);
                    contrato.addPersonFormConfirmed();
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else MessageBox.Show("Falta rellenar algún campo", "Error");
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
