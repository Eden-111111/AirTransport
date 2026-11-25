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
        List<Passengers> lstPassengers;

        public FrmPassengers()
        {
            InitializeComponent();
            con = new Connect();
        }

        private async void FrmPassengers_Load(object sender, EventArgs e)
        {
            lstPassengers= await con.GetAllPassengers();
            dgvAllPassengers.DataSource = lstPassengers.Select(p => new
            {
                p.PassengerId,
                p.FirstName,
                p.LastName,
                p.PassportNumber,
            }).ToList();
            dgvAllPassengers.Columns[0].HeaderText = "ת.ז.";
            dgvAllPassengers.Columns[1].HeaderText = "שם פרטי"; 
            dgvAllPassengers.Columns[2].HeaderText = "שם משפחה";
            dgvAllPassengers.Columns[3].HeaderText = "מספר דרכון";
        }
    }
}
