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
    }
}
