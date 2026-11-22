using AirTransport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTransport.GUI
{
    public partial class FrmAirlines : Form
    {
        Connect con;
        public FrmAirlines()
        {
            InitializeComponent();
            con = new Connect();
        }

        private async void FrmAirlines_Load(object sender, EventArgs e)
        {
            dgvAllAirlines.DataSource = await con.GetAllAirlines();

        }
    }
}
