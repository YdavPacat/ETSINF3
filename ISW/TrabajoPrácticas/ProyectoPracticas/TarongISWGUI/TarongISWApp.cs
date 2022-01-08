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

namespace TarongISWGUI
{
    public partial class TarongISWApp : Form
    {
        private ITarongISWService service;
        public TarongISWApp(ITarongISWService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void TarongISWApp_Load(object sender, EventArgs e)
        {

        }
    }
}
