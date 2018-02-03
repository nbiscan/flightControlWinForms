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
    public partial class FormEditTicket : Form
    {
        public FormEditTicket()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

            FlightControlApi.Models.Ticket[] planes = Program.MyConnection.Ticket.GetAll().ToArray();

            string[] tmpPlane = new string[8];
            ListViewItem lvi;

            foreach (FlightControlApi.Models.Ticket p in planes)
            {
                tmpPlane[0] = p.Id.ToString();
                tmpPlane[1] = p.Price.ToString();
                tmpPlane[2] = p.PassengerId.ToString();
                tmpPlane[3] = p.SeatId.ToString();
                tmpPlane[4] = p.StoreId.ToString();
                tmpPlane[5] = p.FlightId.ToString();
                tmpPlane[6] = p.Revoked.ToString();

                lvi = new ListViewItem(tmpPlane);

                listView1.Items.Add(lvi);
                comboBox2.Items.Add(tmpPlane[2]);
                comboBox1.Items.Add(tmpPlane[3]);
                comboBox3.Items.Add(tmpPlane[4]);
                comboBox4.Items.Add(tmpPlane[5]);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Ticket t = Program.MyConnection.Ticket.Get(Convert.ToInt16(listView1.SelectedItems[0].Text));
                numericUpDown1.Value = t.Price;
                comboBox1.SelectedIndex = listView1.SelectedIndices[0];
                comboBox2.SelectedIndex = listView1.SelectedIndices[0];
                comboBox3.SelectedIndex = listView1.SelectedIndices[0];
                comboBox4.SelectedIndex = listView1.SelectedIndices[0];

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ticket t = new Ticket();
            t.Id = Convert.ToInt16(listView1.SelectedItems[0].Text);
            t.Price = numericUpDown1.Value;
            t.PassengerId = Convert.ToInt32(comboBox2.SelectedItem.ToString().Split(' ')[0]);
            t.SeatId = Convert.ToInt32(comboBox1.SelectedItem.ToString().Split(' ')[0]);
            t.StoreId = Convert.ToInt32(comboBox3.SelectedItem.ToString().Split(' ')[0]);
            t.FlightId = Convert.ToInt32(comboBox4.SelectedItem.ToString().Split(' ')[0]);

            Program.MyConnection.Ticket.Update(Convert.ToInt32(t.Id), t);

            MessageBox.Show("Item updated");
            Reload();
        }

        private void Reload()
        {
            FlightControlApi.Models.Ticket[] planes = Program.MyConnection.Ticket.GetAll().ToArray();

            string[] tmpPlane = new string[8];
            ListViewItem lvi;
            listView1.Items.Clear();

            foreach (FlightControlApi.Models.Ticket p in planes)
            {
                tmpPlane[0] = p.Id.ToString();
                tmpPlane[1] = p.Price.ToString();
                tmpPlane[2] = p.PassengerId.ToString();
                tmpPlane[3] = p.SeatId.ToString();
                tmpPlane[4] = p.StoreId.ToString();
                tmpPlane[5] = p.FlightId.ToString();
                tmpPlane[6] = p.Revoked.ToString();

                lvi = new ListViewItem(tmpPlane);

                listView1.Items.Add(lvi);
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.MyConnection.Ticket.Delete(Convert.ToInt16(listView1.SelectedItems[0].Text));

            MessageBox.Show("Item deactivated.");

            Reload();
        }
    }
}
