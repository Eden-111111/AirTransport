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
    
    public partial class FrmAircrafts : Form
    {
        Connect con;
        public FrmAircrafts()
        {
            InitializeComponent();
            con= new Connect();
        }

        private async void FrmAircrafts_Load(object sender, EventArgs e)
        {
            dgvAllAircrafts.DataSource = await con.GetAllAircrafts();

        }
    }
}
