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
    public partial class Viaje_Camion : Form
    {
        private ITarongISWService service;
        bool llegada_nula = false;
        bool salida_nula = false;
        bool descarga_nula = false;

        public Viaje_Camion(ITarongISWService service) : this()
        {
            this.service = service;
            LoadData();
        }
        public Viaje_Camion()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            Matricula_comboBox.DisplayMember = "matricula";
            Matricula_comboBox.ValueMember = "matricula";

            ICollection<Truck> trucks = service.GetAllTrucks();
            Matricula_comboBox.Items.Clear();
            if (trucks != null)
                foreach (Truck t in trucks)
                    Matricula_comboBox.Items.Add(t.Id);
            Matricula_comboBox.SelectedIndex = -1;
            Matricula_comboBox.ResetText();
        }

        private bool fieldsOK()
        {
            return
                (Matricula_comboBox.SelectedIndex != -1);
        }

        private void addViaje()
        {
            try
            {
                Truck truck = service.FindTruckById(Matricula_comboBox.Text);

                if (truck == null)
                    MessageBox.Show("No existe la matricula", "Error");

                Trip trip = new Trip(truck);
                if (!llegada_nula)
                    trip.CoopArrival = llegada.Value;
                if (!salida_nula)
                    trip.ParcelExit = salida.Value;
                if (!descarga_nula)
                    trip.UnloadTime = descarga.Value;
                truck.AddTrip(trip);
                service.Commit();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            LoadData();
            Matricula_comboBox.Text = null;
            llegada.Value = DateTime.Today;
            salida.Value = DateTime.Today;
            descarga.Value = DateTime.Today;
            llegada_checkbox.Checked = false;
            salida_checkbox.Checked = false;
            descarga_checkbox.Checked = false;
            llegada.Enabled = true;
            salida.Enabled = true;
            descarga.Enabled = true;
        }

        private void llegada_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            llegada_nula = !llegada_nula;
            if (llegada_nula)
                llegada.Enabled = false;
        }

        private void salida_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            salida_nula = !salida_nula;
            if (salida_nula)
                salida.Enabled = false;
        }
        private void descarga_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            descarga_nula = !descarga_nula;
            if (descarga_nula)
                descarga.Enabled = false;
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (fieldsOK())
            {
                addViaje();
                MessageBox.Show("Viaje creado");
            }
            else MessageBox.Show("Falta rellenar algún campo", "Error");
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
