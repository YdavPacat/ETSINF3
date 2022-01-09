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
    public partial class Alta_Cuadrilla : Form
    {
        private ITarongISWService service;
        IList<Person> DNIs_añadirMiembros; //Lista de tipo Person que se van añadiendo al DataGrid
        ICollection<Parcel> parcelas;
        Parcel parcel; //Parcela seleccionada en el comboBox

        public Alta_Cuadrilla(ITarongISWService service) : this()
        {
            this.service = service;
            LoadData();
        }
        public Alta_Cuadrilla()
        {
            InitializeComponent();
            DNIs_añadirMiembros = new List<Person>();
        }
        /// <summary>
        /// Cargamos las listas de los comboBox Parcela y DNI
        /// </summary>
        private void LoadData()
        {
            //Cargamos todas las parcelas del dal al comboBox
            parcelas = service.GetAllParcels();
            Parcela_comboBox.Items.Clear();
            if (parcelas != null)
                foreach (Parcel p in parcelas)
                    Parcela_comboBox.Items.Add(p.Name);
            Parcela_comboBox.SelectedIndex = -1;
            Parcela_comboBox.ResetText();

            //Cargamos todos los DNI del dal al comboBox
            ICollection<Person> personas = service.GetAllPeople();
            DNI_comboBox.Items.Clear();
            if (personas != null)
                foreach (Person c in personas)
                    DNI_comboBox.Items.Add(c.Id);
            DNI_comboBox.SelectedIndex = -1;
            DNI_comboBox.ResetText();
        }
        private void AñadirPersona_Button_Click(object sender, EventArgs e)
        {
            string dni = (string) DNI_comboBox.SelectedItem;
            Person p = service.FindPersonById(dni);
            if (p == null)
            {
                MessageBox.Show("Esta persona no existe", "Error");
                return;
            }
            if (p.LastActiveContract() == null)
            {
                MessageBox.Show("Esta persona no tiene un contrato activo", "Error");
                return;
            }
            if (DNIs_añadirMiembros.Contains(p))
            {
                MessageBox.Show("Ya has añadido esta persona anteriormente", "Error"); //Ya se ha añadido antes al DataGrid
                return;
            }
            //Añade la fila en DataGrid
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(miembrosAñadidos_Grid);
            row.Cells[0].Value = p.Id;
            row.Cells[1].Value = p.Name;
            miembrosAñadidos_Grid.Rows.Add(row);
            DNIs_añadirMiembros.Add(p); //Guarda en la lista("auxiliar") tipo Person para poder leer desde crearCuadrilla_button_click
        }

        private void crearCuadrilla_button_Click(object sender, EventArgs e)
        {
            if (fieldsOK())
            {
                if (!asignarParcela())
                {
                    MessageBox.Show("La parcela no existe", "Error"); //Si no coincide el texto del comboBox con el nombre de una parcela 
                    Parcela_comboBox.ResetText();
                    return;
                }
                try
                {
                    //Creamos grupo y lo añadimos al DAL
                    Group g = new Group(Fecha_timePicker.Value, parcel);
                    service.AddGroup(g);

                    //Recorremos la lista de miembros a añadir
                    foreach (Person p in DNIs_añadirMiembros)
                    {
                        Contract c = p.LastActiveContract();
                        g.AddMember(c);
                    }
                    MessageBox.Show("Grupo creado ");
                    Parcela_comboBox.ResetText();
                    Fecha_timePicker.Value = DateTime.Today;
                    DNI_comboBox.ResetText();
                    for(int i = 0; miembrosAñadidos_Grid.Rows.Count != 0; i++)
                    {
                        DNIs_añadirMiembros.Remove(service.FindPersonById((string)miembrosAñadidos_Grid.Rows[i].Cells[0].Value));
                        miembrosAñadidos_Grid.Rows.RemoveAt(i);
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else MessageBox.Show("No has introducido una parcela", "Error");
        }
        protected virtual bool fieldsOK()
        {
            return
                (Parcela_comboBox.SelectedIndex != -1 || !string.IsNullOrEmpty(Parcela_comboBox.Text));
        }
        private void eliminarMiembro_Button_Click(object sender, EventArgs e)
        {
            if(miembrosAñadidos_Grid.SelectedRows.Count > 0)
            {
                DNIs_añadirMiembros.Remove(service.FindPersonById((string)miembrosAñadidos_Grid.SelectedRows[0].Cells[0].Value));
                miembrosAñadidos_Grid.Rows.RemoveAt(miembrosAñadidos_Grid.SelectedRows[0].Index);
            } else
            {
                MessageBox.Show("No hay una fila seleccionada", "Error");
            }
        }
        private bool asignarParcela()
        {
            //Buscamos la parcela por el atributo Name y guardamos la parcela en la variable global "parcel"
            foreach (Parcel p in parcelas)
            {
                if (p.Name == Parcela_comboBox.Text)
                {
                    parcel = p; return true;
                }
            }
            return false;
        }
        private void Parcela_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        
        private void Fecha_timePicker_ValueChanged(object sender, EventArgs e)
        {
        }

        private void cancelar_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
