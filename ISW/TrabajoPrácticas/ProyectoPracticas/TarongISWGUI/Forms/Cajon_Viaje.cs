using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarongISW.Services;
using TarongISW.Entities;


namespace TarongISWGUI.Forms
{
    public partial class Cajon_Viaje : Form
    {
        private ITarongISWService service;
        ICollection<Parcel> parcels;
        ICollection<Person> persons;
        ICollection<Truck> trucks;
        Parcel parcel;
        Person person;
        Truck truck;
        Product product;

        public Cajon_Viaje(ITarongISWService service) : this()
        {
            this.service = service;
            LoadData();
        }
        public Cajon_Viaje()
        {
            InitializeComponent();
        }

        public List<String> GetAllProducts()
        {
            List<String> products = new List<String>() {"Avocado", "Kiwi", "Lemon", "Orange", "Peach", "Plum"};
            return products;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            parcels = service.GetAllParcels();
            parcela_comboBox.Items.Clear();
            if (parcels != null)
                foreach (Parcel p in parcels)
                    parcela_comboBox.Items.Add(p.Name);
            parcela_comboBox.SelectedIndex = -1;
            parcela_comboBox.ResetText();

            persons = service.GetAllPeople();
            DNI_comboBox.Items.Clear();
            if (persons != null)
                foreach (Person p in persons)
                    DNI_comboBox.Items.Add(p.Id);
            DNI_comboBox.SelectedIndex = -1;
            DNI_comboBox.ResetText();

            trucks = service.GetAllTrucks();
            matricula_comboBox.Items.Clear();
            if (trucks != null)
                foreach (Truck t in trucks)
                    matricula_comboBox.Items.Add(t.Id);
            matricula_comboBox.SelectedIndex = -1;
            matricula_comboBox.ResetText();
        }

        private bool fieldsOK()
        {
            if (!string.IsNullOrEmpty(peso_textBox.Text))
            {
                if ( /*(parcela_comboBox.SelectedIndex != -1) && */
                (DNI_comboBox.SelectedIndex != -1) &&
                (matricula_comboBox.SelectedIndex != -1) &&
                (producto_textBox.Text.Length >= 1) &&
                (peso_textBox.Text.Length >= 1))
                    return true;
            }
            return false;
                
        }

        private void Aceptar_button_Click(object sender, EventArgs e)
        {
            if (asignarParcela())
            {
               if (asignarPersona())
               {
                   Contract contract = person.LastActiveContract();
                   if (contract == null)
                    {
                       MessageBox.Show("La persona no posee un contrato activo", "Error");
                       DNI_comboBox.SelectedIndex = -1;
                       DNI_comboBox.ResetText();
                   }
                   else
                   {
                        if (contract.Groups.Count == 0)
                        {
                            MessageBox.Show("La persona no pertenece a ningún grupo", "Error");
                            DNI_comboBox.SelectedIndex = -1;
                            DNI_comboBox.ResetText();
                        }
                        else
                        {
                            if (asignarTruck())
                            {
                                if (truck.Trips.Count == 0)
                                {
                                    MessageBox.Show("El camión no posee viajes", "Error");
                                    matricula_comboBox.SelectedIndex = -1;
                                    matricula_comboBox.ResetText();
                                }
                                else
                                {
                                    if (verificaPeso())
                                    {
                                        try
                                        {
                                            double peso = Convert.ToDouble(peso_textBox.Text);
                                            Crate crate = new Crate(product, peso, contract, contract.Groups.Last(), truck.Trips.Last());
                                            truck.LastTrip().Crates.Add(crate);
                                            service.AddCrate(crate);
                                            MessageBox.Show("Caja creada");
                                            parcela_comboBox.ResetText();
                                            DNI_comboBox.ResetText();
                                            matricula_comboBox.ResetText();
                                            producto_textBox.ResetText();
                                            peso_textBox.ResetText();
                                        }
                                        catch (ServiceException se)
                                        {
                                            MessageBox.Show(se.Message, "Error");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Por favor, indica un valor de peso correcto", "Error");
                                        peso_textBox.ResetText();
                                    }
                                } 
                            }
                            else
                            {
                                MessageBox.Show("El camión no existe", "Error");
                                matricula_comboBox.SelectedIndex = -1;
                                matricula_comboBox.ResetText();
                            }
                        }
                   }
               }
               else
               {
                   MessageBox.Show("La persona no existe", "Error");
                   DNI_comboBox.SelectedIndex = -1;
                   DNI_comboBox.ResetText();
                   return;
               }  
            }
            else 
            {
                MessageBox.Show("La parcela no existe", "Error"); 
                producto_textBox.ResetText();
                parcela_comboBox.ResetText();
                return; 
            }
        }

        private void parcela_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (parcela_comboBox.Text.Length >= 1 && asignarParcela()) DNI_comboBox.Enabled = true;
            else 
            {
                MessageBox.Show("La parcela no existe", "Error"); //Si no coincide el texto del comboBox con el nombre de una parcela 
                parcela_comboBox.SelectedIndex = -1;
                parcela_comboBox.ResetText();
            }
        }

        private void DNI_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DNI_comboBox.Text.Length >= 1 && asignarPersona())
            {
                Contract contract = person.LastActiveContract();
                if (contract == null)
                {
                    MessageBox.Show("La persona no posee un contrato activo", "Error");
                    DNI_comboBox.ResetText();
                }
                else if (contract.Groups.Count == 0)
                {
                    MessageBox.Show("La persona no pertenece a ningún grupo", "Error");
                    DNI_comboBox.ResetText();
                }
            }
            else
            {
                DNI_comboBox.ResetText();
                MessageBox.Show("La persona no existe", "Error");  
            }
        }

        private void matricula_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (matricula_comboBox.Text.Length >= 1 && asignarTruck()) peso_textBox.Enabled = true;
            else
            {
                matricula_comboBox.ResetText();
                peso_textBox.Enabled = false;
                MessageBox.Show("El camión no existe", "Error"); //Si no coincide el texto del comboBox con el nombre de una parcela 
            }
        }

        private void peso_textBox_TextChanged(object sender, EventArgs e)
        {
            if (peso_textBox.Text.Length >= 1) Aceptar_button.Enabled = true;
            else Aceptar_button.Enabled = false; 
        }

        private bool asignarParcela()
        {
            //Buscamos la parcela por el atributo Name y guardamos la parcela en la variable global "parcel"
            foreach (Parcel p in parcels)
            {
                if (p.Name == parcela_comboBox.Text)
                {
                    parcel = p;
                    product = parcel.Product;
                    String pro = product.ToString();
                    producto_textBox.Text = pro;
                    return true;
                }
            }
            return false;
        }

        private bool asignarPersona()
        {
            //Buscamos la persona por el atributo DNI 
            foreach (Person p in persons)
            {
                if (p.Id == DNI_comboBox.Text)
                {
                    person = p;
                    return true;
                }
            }
            return false;
        }

        private bool asignarTruck()
        {
            //Buscamos el truck por el atributo Id
            foreach (Truck t in trucks)
            {
                if (t.Id == matricula_comboBox.Text)
                {
                    truck = t;
                    return true;
                }
            }
            return false;
        }

        private bool verificaPeso() 
        {
            if (peso_textBox.Text.Length >= 1) {
                char[] cadena = peso_textBox.Text.ToCharArray();
                for (int x = 0; x < cadena.Length; x++)
                {
                    char c = cadena[x];
                    if (((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || c != '.') && (c < '0' || c > '9')) return false; 
                }
            }
            else return false;

            return true; 
        }

        private void parcelaBuscar(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (parcela_comboBox.Text.Length >= 1 && asignarParcela()) { }

                else
                {
                    parcela_comboBox.ResetText();
                    MessageBox.Show("La parcela no existe", "Error");
                }
            }
        }

        private void dniBuscar(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (DNI_comboBox.Text.Length >= 1 && asignarPersona())
                {
                    Contract contract = person.LastActiveContract();
                    if (contract == null)
                    {
                        MessageBox.Show("La persona no posee un contrato activo", "Error");
                        DNI_comboBox.ResetText();
                    }
                    else if (contract.Groups.Count == 0)
                    {
                        MessageBox.Show("La persona no pertenece a ningún grupo", "Error");
                        DNI_comboBox.ResetText();
                    }
                }
                else
                {
                    DNI_comboBox.ResetText();
                    MessageBox.Show("La persona no existe", "Error");
                }
            }
        }

        private void matriculaBuscar(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (matricula_comboBox.Text.Length >= 1 && asignarTruck())
                {
                }
                else
                {
                    matricula_comboBox.ResetText();
                    MessageBox.Show("El camión no existe", "Error");
                }
            }
        }
        private void Cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
