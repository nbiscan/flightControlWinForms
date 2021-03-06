﻿using FlightControlApi.Models;
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
    public partial class FormAddStore : Form
    {
        public FormAddStore(Country[] countries)
        {
            InitializeComponent();
            Country[] items = countries;//Program.MyConnection.Country.GetAll().ToArray();

            string[] tmpCountry = new string[6];

            foreach (Country p in items)
            {
                tmpCountry[0] = p.Id.ToString();
                tmpCountry[1] = p.iso;
                tmpCountry[2] = p.name;
                tmpCountry[3] = p.iso3;
                tmpCountry[4] = p.printable_name;
                tmpCountry[5] = p.numcode.ToString();


                comboBox3.Items.Add(tmpCountry[0] + ' ' + tmpCountry[2]);

            }
        }

        private void FormAddStore_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Store p = new Store();
            p.Name = textBox3.Text;
            p.Address = textBox1.Text;
            p.ZipCode = textBox2.Text;
            p.CountryId = Convert.ToInt32(comboBox3.SelectedItem.ToString().Split(' ')[0]);

            Program.MyConnection.Store.Insert(p);
            MessageBox.Show("Item added.");
            Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
