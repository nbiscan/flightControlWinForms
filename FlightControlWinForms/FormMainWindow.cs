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
    public partial class FormMainWindow : Form
    {
        private IMainController _controller;

        public FormMainWindow(IMainController inController)
        {
            _controller = inController;
            InitializeComponent();
        }

        private void passengersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ViewFlights();
        }

        private void editFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.EditFlights();
        }

        private void removeFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.RemoveFlights();
        }

        private void addFlightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _controller.AddFlights();
        }

        private void viewStoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ViewStores();
        }

        private void addStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.AddStores();
        }

        private void removeStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.RemoveStores();
        }

        private void editStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.EditStores();
        }

        private void viewAirportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ViewAirports();
        }
    }
}
