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
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.MyConnection.Airport.Delete(Convert.ToInt16(listView1.SelectedItems[0].Text));

            MessageBox.Show("Item removed.");

            listView1.SelectedItems[0].Remove();

        }
    }
}
