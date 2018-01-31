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
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
