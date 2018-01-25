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
    public partial class FormEditPilot : Form
    {
        public FormEditPilot()
        {
            InitializeComponent();

            FlightControlApi.Models.Pilot[] pilots = Program.MyConnection.Pilot.GetAll().ToArray();

            string[] tmpPilot = new string[5];
            ListViewItem lvi;

            foreach (FlightControlApi.Models.Pilot p in pilots)
            {
                tmpPilot[0] = p.Id.ToString();
                tmpPilot[1] = p.FirstName;
                tmpPilot[2] = p.LastName;
                tmpPilot[3] = p.BirthDay.ToString();
                tmpPilot[4] = p.Active.ToString();

                lvi = new ListViewItem(tmpPilot);

                listView1.Items.Add(lvi);

            }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
