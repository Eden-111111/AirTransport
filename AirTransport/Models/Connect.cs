using AirTransport.GUI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTransport.Models
{
    internal class Connect
    {
        HttpClient Client;//אוביקט שתפקידו לתקשר עם השרת
        HttpResponseMessage response;//אוביקט שמקבל את התגובה מהשרת
        List<Aircraft> lstAircrafts;
        List<Airlines> lstAirlines;
        List<Airports> lstAirports;
        List<Baggage> lstBaggages;
        List<Bookings> lstBookings;
        List<Flights> lstFlights;
        List<Passengers> lstPassengers;
        List<Terminals> lstTerminals;


        public Connect()
        {
            Client = new HttpClient();
            response = new HttpResponseMessage();

        }

        public async Task<List<Aircraft>> GetAllAircrafts()
        {
            response = await Client.GetAsync("https://localhost:7180/api/Aircraft");
            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();
                lstAircrafts = JsonConvert.DeserializeObject<List<Aircraft>>(data);
            }

            else
                MessageBox.Show("error ");
            return lstAircrafts;
        }

        public async Task<List<Airlines>> GetAllAirlines()
        {
            response = await Client.GetAsync("https://localhost:7180/api/Airlines");
            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();//קורא את תוכן גוף התשובה שהגיע מהשרת כ מחרוזת טקסט (בדרך כלל במבנה JSON).
                lstAirlines = JsonConvert.DeserializeObject<List<Airlines>>(data);//משתמש בספריית Newtonsoft.Json כדי להמיר (לרדות) את מחרוזת ה-JSON שקיבלנו לתוך רשימה של אובייקטים מסוג List<Customers> ב-C#.
            }
            else
                MessageBox.Show("error ");//מציג הודעת שגיאה קופצת למשתמש (MessageBox) המעידה שמשהו השתבש בקריאה.
            return lstAirlines;

        }

        public async Task<List<Airports>> GetAllAirports()
        {
            response = await Client.GetAsync("https://localhost:7180/api/Airports");
            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();//קורא את תוכן גוף התשובה שהגיע מהשרת כ מחרוזת טקסט (בדרך כלל במבנה JSON).
                lstAirports = JsonConvert.DeserializeObject<List<Airports>>(data);//משתמש בספריית Newtonsoft.Json כדי להמיר (לרדות) את מחרוזת ה-JSON שקיבלנו לתוך רשימה של אובייקטים מסוג List<Customers> ב-C#.
            }
            else
                MessageBox.Show("error ");//מציג הודעת שגיאה קופצת למשתמש (MessageBox) המעידה שמשהו השתבש בקריאה.
            return lstAirports;
        }

        public async Task<List<Baggage>> GetAllBaggage()
        {
            response = await Client.GetAsync("https://localhost:7180/api/Baggage");
            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();//קורא את תוכן גוף התשובה שהגיע מהשרת כ מחרוזת טקסט (בדרך כלל במבנה JSON).
                lstBaggages = JsonConvert.DeserializeObject<List<Baggage>>(data);//משתמש בספריית Newtonsoft.Json כדי להמיר (לרדות) את מחרוזת ה-JSON שקיבלנו לתוך רשימה של אובייקטים מסוג List<Customers> ב-C#.
            }
            else
                MessageBox.Show("error ");//מציג הודעת שגיאה קופצת למשתמש (MessageBox) המעידה שמשהו השתבש בקריאה.
            return lstBaggages;
        }

        public async Task<List<Bookings>> GetAllBookings()
        {
            response = await Client.GetAsync("https://localhost:7180/api/Bookings");
            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();//קורא את תוכן גוף התשובה שהגיע מהשרת כ מחרוזת טקסט (בדרך כלל במבנה JSON).
                lstBookings = JsonConvert.DeserializeObject<List<Bookings>>(data);//משתמש בספריית Newtonsoft.Json כדי להמיר (לרדות) את מחרוזת ה-JSON שקיבלנו לתוך רשימה של אובייקטים מסוג List<Customers> ב-C#.
            }
            else
                MessageBox.Show("error ");//מציג הודעת שגיאה קופצת למשתמש (MessageBox) המעידה שמשהו השתבש בקריאה.
            return lstBookings;
        }
        public async Task<List<Flights>> GetAllFlights()
        {
            response = await Client.GetAsync("https://localhost:7180/api/Flights");
            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();//קורא את תוכן גוף התשובה שהגיע מהשרת כ מחרוזת טקסט (בדרך כלל במבנה JSON).
                lstFlights = JsonConvert.DeserializeObject<List<Flights>>(data);//משתמש בספריית Newtonsoft.Json כדי להמיר (לרדות) את מחרוזת ה-JSON שקיבלנו לתוך רשימה של אובייקטים מסוג List<Customers> ב-C#.
            }
            else
                MessageBox.Show("error ");//מציג הודעת שגיאה קופצת למשתמש (MessageBox) המעידה שמשהו השתבש בקריאה.
            return lstFlights;
        }




    }
}


