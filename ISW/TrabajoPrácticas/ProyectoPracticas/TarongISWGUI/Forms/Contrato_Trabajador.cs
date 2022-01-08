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
    public partial class Contrato_Trabajador : Form
    {
        private ITarongISWService service;
        private Alta_Persona persona;
        bool fecha_nula = false;

        public Contrato_Trabajador(ITarongISWService service) : this()
        {
            this.service = service;
            persona = new Alta_Persona(this, service);
            LoadData();
        }
        public Contrato_Trabajador()
        {
            InitializeComponent();
        }

        //Agrega las variables a los ComboBox
        public void LoadData()
        {
            
            /*dni.DisplayMember = "dni";
            dni.ValueMember = "dni";
            dni.DataSource = service.GetAllPeople();*/
            ICollection<Person> personas = service.GetAllPeople();
            dni.Items.Clear();
            if (personas != null)
                foreach (Person c in personas)
                    dni.Items.Add(c.Id);
            dni.SelectedIndex = -1;

            contrato.Items.Clear();
            /*contrato.DisplayMember = "contrato";
            contrato.ValueMember = "Id";*/
            contrato.Items.Insert(0, "Temporal");
            contrato.Items.Insert(1, "Permanente");
            contrato.SelectedIndex = -1;
        }

        //Revisa que no falten campos por llenar
        private bool fieldsOK()
        {
            return
                (dni.SelectedIndex != -1 || dni.Text != null) &&
                (contrato.SelectedIndex != -1) &&
                !string.IsNullOrEmpty(cuenta_bancaria.Text) &&
                !string.IsNullOrEmpty(seguridad_social.Text) &&
                (fecha_inicio.Value != null) &&
                ((fecha_fin.Value != null) || salario.Value != 0);
        }

        private void addContrato()
        {
            Person person = service.FindPersonById(dni.Text);
            try 
            {
                switch (contrato.SelectedIndex)
                {
                    case 0:
                        Temporary temporary = new Temporary(cuenta_bancaria.Text, fecha_inicio.Value, seguridad_social.Text, person);
                        if (!fecha_nula)
                            temporary.FinalDate = fecha_fin.Value;
                        service.AddTemporary(temporary);
                        break;
                    default:
                        Permanent permanent = new Permanent(cuenta_bancaria.Text, fecha_inicio.Value, seguridad_social.Text, person, (double)salario.Value);
                        service.AddPermanent(permanent);
                        break;
                }
                MessageBox.Show("Contrato creado");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error");
            }
            LoadData();
            dni.Text = null;
            cuenta_bancaria.Text = null;
            seguridad_social.Text = null;
            fecha_inicio.Value = DateTime.Today;
            contrato.Enabled = false;
            cuenta_bancaria.Enabled = false;
            seguridad_social.Enabled = false;
            fecha_inicio.Enabled = false;
        }

        public void addPersonFormConfirmed()
        {
            LoadData();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (service.FindPersonById(dni.Text) == null)
            {
                MessageBox.Show("Esta persona no ha sido dada de alta en el sistema", "Error");
            }
            else if (contrato.SelectedIndex == -1) 
            {
                MessageBox.Show("Esta persona no ha sido dada de alta en el sistema", "Error");
            }
            else {
                if (fieldsOK())
                {
                    addContrato();
                }
                else MessageBox.Show("Falta rellenar algún campo", "Error");
            }
        }

        private void dar_alta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            persona.Clear();
            persona.ShowDialog();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fecha_fin_nula_CheckedChanged(object sender, EventArgs e)
        {
            fecha_nula = !fecha_nula;
        }

        private void contrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (contrato.SelectedIndex)
            {
                case 0:
                    salario.Enabled = false;
                    fecha_fin.Enabled = true;
                    fecha_fin_nula.Enabled = true;
                    break;
                case 1:
                    fecha_fin.Enabled = false;
                    fecha_fin_nula.Enabled = false;
                    salario.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void dniBuscar(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (service.FindPersonById(dni.Text) != null){
                    contrato.Enabled = true;
                    cuenta_bancaria.Enabled = true;
                    seguridad_social.Enabled = true;
                    fecha_inicio.Enabled = true;
                }
                else
                {
                    contrato.Enabled = false;
                    cuenta_bancaria.Enabled = false;
                    seguridad_social.Enabled = false;
                    fecha_inicio.Enabled = false;
                    MessageBox.Show("Esta persona no ha sido dada de alta en el sistema", "Error");
                }
            }
        }

        private void dni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (service.FindPersonById(dni.Text) != null)
            {
                contrato.Enabled = true;
                cuenta_bancaria.Enabled = true;
                seguridad_social.Enabled = true;
                fecha_inicio.Enabled = true;
            }
            else
            {
                contrato.Enabled = false;
                cuenta_bancaria.Enabled = false;
                seguridad_social.Enabled = false;
                fecha_inicio.Enabled = false;
            }
        }
    }
}
