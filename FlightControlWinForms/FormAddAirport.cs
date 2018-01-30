using FlightControlApi.Models;
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
    public partial class FormAddAirport : Form
    {
        public FormAddAirport()
        {
            InitializeComponent();
            FlightControlApi.Models.Country[] items = Program.MyConnection.Country.GetAll().ToArray();

            string[] tmpCountry = new string[6];
            ListViewItem lvi;

            foreach (FlightControlApi.Models.Country p in items)
            {
                tmpCountry[0] = p.Id.ToString();
                tmpCountry[1] = p.iso;
                tmpCountry[2] = p.name;
                tmpCountry[3] = p.iso3;
                tmpCountry[4] = p.printable_name;
                tmpCountry[5] = p.numcode.ToString();


                lvi = new ListViewItem(tmpCountry);

                comboBox3.Items.Add(lvi);

            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Airport p = new Airport();
            p.Name = textBox3.Text;
            p.Address = textBox1.Text;
            p.ZipCode = textBox4.Text;
            p.CountryId = 3;

            Program.MyConnection.Airport.Insert(p);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
