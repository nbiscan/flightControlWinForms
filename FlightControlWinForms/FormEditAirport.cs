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
    public partial class FormEditAirport : Form
    {
        public FormEditAirport()
        {
            InitializeComponent();

            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

            FlightControlApi.Models.Airport[] pilots = Program.MyConnection.Airport.GetAll().ToArray();

            string[] tmpAirport = new string[5];
            ListViewItem lvi;

            foreach (FlightControlApi.Models.Airport p in pilots)
            {
                tmpAirport[0] = p.Id.ToString();
                tmpAirport[1] = p.Name;
                tmpAirport[2] = p.Address;
                tmpAirport[3] = p.ZipCode;
                tmpAirport[4] = p.CountryId.ToString();

                lvi = new ListViewItem(tmpAirport);

                listView1.Items.Add(lvi);
                comboBox3.Items.Add(tmpAirport[4]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Program.MyConnection.Airport.Delete(Convert.ToInt16(listView1.SelectedItems[0].Text));

                MessageBox.Show("Item removed.");

                listView1.SelectedItems[0].Remove();
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Airport p = Program.MyConnection.Airport.Get(Convert.ToInt16(listView1.SelectedItems[0].Text));
                textBox3.Text = p.Name;
                textBox1.Text = p.Address;
                textBox4.Text = p.ZipCode;
                comboBox3.SelectedIndex = listView1.SelectedIndices[0];

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Airport a = new Airport();
            a.Id = Convert.ToInt16(listView1.SelectedItems[0].Text);
            a.Name = textBox3.Text;
            a.Address = textBox1.Text;
            a.ZipCode = textBox4.Text;
            a.CountryId = Convert.ToInt32(comboBox3.SelectedItem.ToString().Split(' ')[0]);

            Program.MyConnection.Airport.Update(Convert.ToInt32(a.Id), a);

            MessageBox.Show("Item updated");
        }
    }
}
