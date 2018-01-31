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
    public partial class FormEditRoute : Form
    {
        public FormEditRoute()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

            FlightControlApi.Models.Route[] pilots = Program.MyConnection.Route.GetAll().ToArray();

            string[] tmpRoute = new string[8];
            ListViewItem lvi;

            foreach (FlightControlApi.Models.Route p in pilots)
            {
                tmpRoute[0] = p.Id.ToString();
                tmpRoute[1] = p.FromId.ToString();
                tmpRoute[2] = p.DestinationId.ToString();
                

                lvi = new ListViewItem(tmpRoute);

                listView1.Items.Add(lvi);
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
                Program.MyConnection.Route.Delete(Convert.ToInt16(listView1.SelectedItems[0].Text));

                MessageBox.Show("Item removed.");

                listView1.SelectedItems[0].Remove();
            }
        }
    }
}
