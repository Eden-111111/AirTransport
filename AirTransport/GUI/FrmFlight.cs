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
    public partial class FrmFlight : Form
    {
        Connect con;
        public FrmFlight()
        {
            InitializeComponent();
            con = new Connect();
        }

        private async void FrmFlight_Load(object sender, EventArgs e)
        {
            dgvAllFlights.DataSource = await con.GetAllFlights();
        }
    }
}
