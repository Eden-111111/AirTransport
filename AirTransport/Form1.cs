using AirTransport.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTransport
{
    public partial class Form1 : Form
    {

        HttpClient Client;//אוביקט שתפקידו לתקשר עם השרת
        List<Aircraft> lstAircraft; //רשימה שתכיל את כל מאגר הלקוחות
        HttpResponseMessage response;

        public Form1()
        {
            InitializeComponent();
            Client = new HttpClient();
            response = new HttpResponseMessage();

        }

     

        private async void Form1_Load_1(object sender, EventArgs e)
        {
            response = await Client.GetAsync("https://localhost:7180/api/Aircraft\r\n");


            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();
                lstAircraft = JsonConvert.DeserializeObject<List<Aircraft>>(data);

            }

            else
                MessageBox.Show("error ");
            dataGridView1.DataSource = lstAircraft;
        }

    }

}
    

