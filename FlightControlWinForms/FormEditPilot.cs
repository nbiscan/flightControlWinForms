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


            //BindingSource bindingSource1 = new BindingSource();
            //bindingSource1.DataSource = Program.MyConnection.Pilot.GetAll();

            listView1.Items.Add("bla");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
