using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlightControlWinForms
{
    public partial class FormEditFlights : Form
    {
        public FormEditFlights()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

            FlightControlApi.Models.Flight[] items = Program.MyConnection.Flight.GetAll().ToArray();

            string[] tmpFlight = new string[8];
            ListViewItem lvi;

            foreach (FlightControlApi.Models.Flight p in items)
            {
                tmpFlight[0] = p.Id.ToString();
                tmpFlight[1] = p.RouteId.ToString();
                tmpFlight[2] = p.PlaneId.ToString();
                tmpFlight[3] = p.PilotId.ToString();
                tmpFlight[4] = p.DepTime.ToString();
                tmpFlight[5] = p.ArrTime.ToString();
                tmpFlight[6] = p.Canceled.ToString();
                tmpFlight[7] = p.Price.ToString();


                lvi = new ListViewItem(tmpFlight);

                listView1.Items.Add(lvi);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormEditFlights_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
