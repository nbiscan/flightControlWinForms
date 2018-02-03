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
    public partial class FormEditSeat : Form
    {
        public FormEditSeat()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

            FlightControlApi.Models.Seat[] pilots = Program.MyConnection.Seat.GetAll().ToArray();

            string[] tmpSeat = new string[8];
            ListViewItem lvi;

            foreach (FlightControlApi.Models.Seat p in pilots)
            {
                tmpSeat[0] = p.Id.ToString();
                tmpSeat[1] = p.Num.ToString();
                tmpSeat[2] = p.PlaneId.ToString();
                tmpSeat[3] = p.SeatClassId.ToString();

                lvi = new ListViewItem(tmpSeat);

                listView1.Items.Add(lvi);
                comboBox1.Items.Add(tmpSeat[2]);
                comboBox3.Items.Add(tmpSeat[3]);

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
                Program.MyConnection.Seat.Delete(Convert.ToInt16(listView1.SelectedItems[0].Text));

                MessageBox.Show("Item removed.");

                listView1.SelectedItems[0].Remove();
            }
        }

        private void FormEditSeat_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Seat s = Program.MyConnection.Seat.Get(Convert.ToInt16(listView1.SelectedItems[0].Text));
                numericUpDown4.Value = s.Num;
                comboBox3.SelectedIndex = listView1.SelectedIndices[0];
                comboBox1.SelectedIndex = listView1.SelectedIndices[0];

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Seat s = new Seat();
            s.Id = Convert.ToInt16(listView1.SelectedItems[0].Text);
            s.Num = Convert.ToInt16(numericUpDown4.Value);
            s.PlaneId = Convert.ToInt32(comboBox1.SelectedItem.ToString().Split(' ')[0]);
            s.SeatClassId = Convert.ToInt32(comboBox3.SelectedItem.ToString().Split(' ')[0]);

            Program.MyConnection.Seat.Update(Convert.ToInt32(s.Id), s);

            MessageBox.Show("Item updated");
            Reload();
        }

        private void Reload()
        {
            FlightControlApi.Models.Seat[] pilots = Program.MyConnection.Seat.GetAll().ToArray();

            string[] tmpSeat = new string[8];
            ListViewItem lvi;
            listView1.Items.Clear();

            foreach (FlightControlApi.Models.Seat p in pilots)
            {
                tmpSeat[0] = p.Id.ToString();
                tmpSeat[1] = p.Num.ToString();
                tmpSeat[2] = p.PlaneId.ToString();
                tmpSeat[3] = p.SeatClassId.ToString();

                lvi = new ListViewItem(tmpSeat);

                listView1.Items.Add(lvi);
            }
        }
    }
}
