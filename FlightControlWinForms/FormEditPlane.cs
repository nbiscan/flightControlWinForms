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
    public partial class FormEditPlane : Form
    {
        public FormEditPlane()
        {
            InitializeComponent();

            FlightControlApi.Models.Plane[] planes = Program.MyConnection.Plane.GetAll().ToArray();

            string[] tmpPlane = new string[8];
            ListViewItem lvi;

            foreach (FlightControlApi.Models.Plane p in planes)
            {
                tmpPlane[0] = p.Id.ToString();
                tmpPlane[1] = p.Model;
                tmpPlane[2] = p.SerialNumber;
                tmpPlane[3] = p.EconomyCapacity.ToString();
                tmpPlane[4] = p.BusinessCapacity.ToString();
                tmpPlane[5] = p.FirstClassCapacity.ToString();
                tmpPlane[6] = p.Active.ToString();

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
