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
                cbxSensor.Items.Add(tmpFlight[1]);
                comboBox1.Items.Add(tmpFlight[2]);
                comboBox2.Items.Add(tmpFlight[3]);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Flight f = Program.MyConnection.Flight.Get(Convert.ToInt16(listView1.SelectedItems[0].Text));
                dateTimePicker1.Value = f.DepTime;
                dateTimePicker2.Value = f.ArrTime;
                cbxSensor.SelectedIndex = listView1.SelectedIndices[0];
                comboBox1.SelectedIndex = listView1.SelectedIndices[0];
                comboBox2.SelectedIndex = listView1.SelectedIndices[0];
                numericUpDown1.Value = f.Price;

            }
        }

        private void FormEditFlights_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Flight f = new Flight();
            f.Id = Convert.ToInt16(listView1.SelectedItems[0].Text);
            f.DepTime = dateTimePicker1.Value;
            f.ArrTime = dateTimePicker2.Value;
            f.RouteId = Convert.ToInt16(cbxSensor.SelectedItem.ToString());
            f.PlaneId = Convert.ToInt16(comboBox1.SelectedItem.ToString());
            f.PilotId = Convert.ToInt16(comboBox2.SelectedItem.ToString());
            f.Price = numericUpDown1.Value;

            Program.MyConnection.Flight.Update(Convert.ToInt32(f.Id), f);

            MessageBox.Show("Item updated");

            Reload();
        }

        private void Reload()
        {
            FlightControlApi.Models.Flight[] items = Program.MyConnection.Flight.GetAll().ToArray();

            string[] tmpFlight = new string[8];
            ListViewItem lvi;

            listView1.Items.Clear();

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

        private void button1_Click(object sender, EventArgs e)
        {
            Program.MyConnection.Flight.Delete(Convert.ToInt16(listView1.SelectedItems[0].Text));

            MessageBox.Show("Item deactivated.");

            Reload();
        }
    }
}
