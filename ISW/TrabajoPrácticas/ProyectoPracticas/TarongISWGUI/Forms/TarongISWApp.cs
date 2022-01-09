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
using TarongISWGUI.Forms;

namespace TarongISWGUI
{
    public partial class TarongISWApp : Form
    {
        private Alta_Cuadrilla alta_Cuadrilla;
        private Cajon_Viaje cajon_Viaje;
        private Consultar_Viajes consultar_Viajes;
        private Contrato_Trabajador contrato_Trabajador;
        private Viaje_Camion viaje_Camion;
        
        private ITarongISWService service;
        public TarongISWApp(ITarongISWService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void TarongISWApp_Load(object sender, EventArgs e)
        {

        }

        private void altaCudrilla_Click(object sender, EventArgs e)
        {
            alta_Cuadrilla = new Alta_Cuadrilla(service);
            alta_Cuadrilla.ShowDialog();
        }

        private void asignarViajeACamion_Click(object sender, EventArgs e)
        {
            viaje_Camion = new Viaje_Camion(service);
            viaje_Camion.ShowDialog();
        }

        private void consultarViajesDeCamion_Cick(object sender, EventArgs e)
        {
            consultar_Viajes = new Consultar_Viajes(service);
            consultar_Viajes.ShowDialog();
        }

        private void asignarCajonAViaje_Click(object sender, EventArgs e)
        {
            cajon_Viaje = new Cajon_Viaje(service);
            cajon_Viaje.ShowDialog();
        }

        private void altaContrato_Click(object sender, EventArgs e)
        {
            contrato_Trabajador = new Contrato_Trabajador(service);
            contrato_Trabajador.ShowDialog();
        }

        private void crearBDEjemplo(object sender, EventArgs e)
        {
            service.RemoveAllData();

            Console.WriteLine("INITIALIZATING DB...");

            Person p1;
            p1 = new Person("12345678Z", "Juan Abelló");
            service.AddPerson(p1);

            Parcel parcel = new Parcel("1234567AB9999C0001DE", "El Lobillo, Alhambra (Ciudad Real)", Product.Orange, 10000, p1);
            service.AddParcel(parcel);

            p1 = new Person("23456789D", "José María Aristrian");
            service.AddPerson(p1);

            parcel = new Parcel("7654321AB9999C0001DE", "Valdepuercas, Alia (Cáceres)", Product.Avocado, 18000, p1);
            service.AddParcel(parcel);

            p1 = new Person("34567890V", "Junta de Andalucía");
            service.AddPerson(p1);

            parcel = new Parcel("7654321AB1111C0001DE", "La Almoraima (Cadiz)", Product.Kiwi, 16000, p1);
            service.AddParcel(parcel);

            Truck t = new Truck("1234AAA", 3200, 3000);
            service.AddTruck(t);

            t = new Truck("1234BJP", 3500, 2660);
            service.AddTruck(t);

            t = new Truck("1234LKP", 18000, 3660);
            service.AddTruck(t);
        }

        private void salir(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
