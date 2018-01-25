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
    }
}
