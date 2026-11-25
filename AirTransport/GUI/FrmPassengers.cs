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
    public partial class FrmPassengers : Form
    {
        Connect con;

        public FrmPassengers()
        {
            InitializeComponent();
            con = new Connect();
        }

        private async void FrmPassengers_Load(object sender, EventArgs e)
        {
            dgvAllPassengers.DataSource = await con.GetAllPassengers();
        }
    }
}
