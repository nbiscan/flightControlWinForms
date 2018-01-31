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
    public partial class FormEditStore : Form
    {
        public FormEditStore()
        {
            InitializeComponent();
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

            FlightControlApi.Models.Store[] pilots = Program.MyConnection.Store.GetAll().ToArray();

            string[] tmpStore = new string[8];
            ListViewItem lvi;

            foreach (FlightControlApi.Models.Store p in pilots)
            {
                tmpStore[0] = p.Id.ToString();
                tmpStore[1] = p.Name;
                tmpStore[2] = p.Address;
                tmpStore[3] = p.ZipCode.ToString();
                tmpStore[4] = p.CountryId.ToString();

                lvi = new ListViewItem(tmpStore);

                listView1.Items.Add(lvi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Program.MyConnection.Store.Delete(Convert.ToInt16(listView1.SelectedItems[0].Text));

                MessageBox.Show("Item removed.");

                listView1.SelectedItems[0].Remove();
            }
        }
    }
}
