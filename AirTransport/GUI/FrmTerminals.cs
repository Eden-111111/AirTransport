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
    public partial class FrmTerminals : Form
    {
        Connect con;
        public FrmTerminals()
        {
            InitializeComponent();
            con = new Connect();
        }

        private async void FrmTerminals_Load(object sender, EventArgs e)
        {
            dgvAllTerminals.DataSource = await con.GetAllTerminals();
        }
    }
}
