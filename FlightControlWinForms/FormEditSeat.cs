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
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.MyConnection.Seat.Delete(Convert.ToInt16(listView1.SelectedItems[0].Text));

            MessageBox.Show("Item removed.");

            listView1.SelectedItems[0].Remove();
        }
    }
}
