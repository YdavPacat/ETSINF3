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
    public partial class Consultar_Viajes : Form
    {
        private ITarongISWService service;

        public Consultar_Viajes(ITarongISWService service) : this()
        {
            this.service = service;
            LoadData();
        }

        public Consultar_Viajes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga la lista para el combo box
        /// </summary>
        public void LoadData()
        {
            ICollection<Truck> trucks = service.GetAllTrucks();
            matricula_comboBox.Items.Clear();
            if (trucks != null)
                foreach (Truck t in trucks)
                    matricula_comboBox.Items.Add(t.Id);
            matricula_comboBox.SelectedIndex = -1;
            matricula_comboBox.ResetText();
            // reservationsbindingSource.DataSource = null;
        }

        private void refreshDataGrind()
        {
            if (fin_dateTimePicker.Value == null 
                || ini_dateTimePicker.Value == null 
                || matricula_comboBox.Text.Length < 1
                || fin_dateTimePicker.Value < ini_dateTimePicker.Value)
                return;

            string matricula = (string)matricula_comboBox.SelectedItem;

            Truck truck = service.FindTruckById(matricula);

            if (truck == null)
            {
                MessageBox.Show("No existe esa matrícula ");
                return;
            }

             
            ICollection<Trip> trips = truck.TripsByDate(ini_dateTimePicker.Value.Date, fin_dateTimePicker.Value.Date);

            if (trips.Count < 1)
            {
                MessageBox.Show("No hay Trips para esas fechas ");
                return;
            }

            BindingList<object> bindinglist = new BindingList<object>();
            foreach (Trip t in trips)
                //Adding one anonymous object for each reservation obtained
                bindinglist.Add(new
                {
                    //ds_... are DataPropertyNames defined in the DataGridView object
                    //see DataGridView column definitions in Visual Studio Designer
                    parcela_dp = t.Crates.First().Group.Parcel.Name,
                    fecha_dp = t.Crates.First().Group.Date,
                    cajas_dp = t.Crates.Count,
                    peso_dp = t.CarriedWeight
                });

            camiones_dataGridView.DataSource = bindinglist;


        }
        
        private void matricula_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshDataGrind();
        }

        private void Consultar_Viajes_Load(object sender, EventArgs e)
        {

        }
    }
}
