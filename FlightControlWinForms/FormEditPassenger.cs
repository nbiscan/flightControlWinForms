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
            Program.MyConnection.Passenger.Delete(Convert.ToInt16(listView1.SelectedItems[0].Text));

            MessageBox.Show("Item removed.");

            listView1.SelectedItems[0].Remove();
        }
    }
}
