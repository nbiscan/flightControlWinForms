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
    public partial class FormEditPassenger : Form
    {
        public FormEditPassenger()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

            FlightControlApi.Models.Passenger[] pilots = Program.MyConnection.Passenger.GetAll().ToArray();

            string[] tmpPassenger = new string[5];
            ListViewItem lvi;

            foreach (FlightControlApi.Models.Passenger p in pilots)
            {
                tmpPassenger[0] = p.Id.ToString();
                tmpPassenger[1] = p.Name;
                tmpPassenger[2] = p.Email;
                tmpPassenger[3] = p.Identifier;
                tmpPassenger[4] = p.CountryId.ToString();

                lvi = new ListViewItem(tmpPassenger);

                listView1.Items.Add(lvi);
                comboBox3.Items.Add(tmpPassenger[4]);
            }
        }

        private void FormEditPassenger_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                Program.MyConnection.Passenger.Delete(Convert.ToInt16(listView1.SelectedItems[0].Text));

                MessageBox.Show("Item removed.");

                listView1.SelectedItems[0].Remove();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Passenger p = Program.MyConnection.Passenger.Get(Convert.ToInt16(listView1.SelectedItems[0].Text));
                textBox3.Text = p.Name;
                textBox1.Text = p.Email;
                textBox4.Text = p.Identifier;
                comboBox3.SelectedIndex = listView1.SelectedIndices[0];

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Passenger p = new Passenger();
            p.Id = Convert.ToInt16(listView1.SelectedItems[0].Text);
            p.Name = textBox3.Text;
            p.Email = textBox1.Text;
            p.Identifier = textBox4.Text;
            p.CountryId = Convert.ToInt32(comboBox3.SelectedItem.ToString().Split(' ')[0]);

            Program.MyConnection.Passenger.Update(Convert.ToInt32(p.Id), p);

            MessageBox.Show("Item updated");
            Reload();
        }

        private void Reload()
        {
            FlightControlApi.Models.Passenger[] pilots = Program.MyConnection.Passenger.GetAll().ToArray();

            string[] tmpPassenger = new string[5];
            ListViewItem lvi;

            listView1.Items.Clear();

            foreach (FlightControlApi.Models.Passenger p in pilots)
            {
                tmpPassenger[0] = p.Id.ToString();
                tmpPassenger[1] = p.Name;
                tmpPassenger[2] = p.Email;
                tmpPassenger[3] = p.Identifier;
                tmpPassenger[4] = p.CountryId.ToString();

                lvi = new ListViewItem(tmpPassenger);

                listView1.Items.Add(lvi);
                comboBox3.Items.Add(tmpPassenger[4]);
            }
        }
    }
}
