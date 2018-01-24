﻿namespace FlightControlWinForms
{
    partial class FormMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFlightToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passengersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPilotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPilotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePilotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPilotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRoutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPassengersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPlanesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePlaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPlaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAirportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAirportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAirportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAirportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCountriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightsToolStripMenuItem,
            this.passengersToolStripMenuItem,
            this.pilotsToolStripMenuItem,
            this.routesToolStripMenuItem,
            this.passengerToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.planeToolStripMenuItem,
            this.airportToolStripMenuItem,
            this.ticketToolStripMenuItem,
            this.countriesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1385, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flightsToolStripMenuItem
            // 
            this.flightsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFlightToolStripMenuItem,
            this.addFlightToolStripMenuItem1,
            this.removeFlightToolStripMenuItem,
            this.editFlightToolStripMenuItem});
            this.flightsToolStripMenuItem.Name = "flightsToolStripMenuItem";
            this.flightsToolStripMenuItem.Size = new System.Drawing.Size(97, 36);
            this.flightsToolStripMenuItem.Text = "Flights";
            // 
            // addFlightToolStripMenuItem
            // 
            this.addFlightToolStripMenuItem.Name = "addFlightToolStripMenuItem";
            this.addFlightToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.addFlightToolStripMenuItem.Text = "View Flights";
            this.addFlightToolStripMenuItem.Click += new System.EventHandler(this.addFlightToolStripMenuItem_Click);
            // 
            // addFlightToolStripMenuItem1
            // 
            this.addFlightToolStripMenuItem1.Name = "addFlightToolStripMenuItem1";
            this.addFlightToolStripMenuItem1.Size = new System.Drawing.Size(269, 38);
            this.addFlightToolStripMenuItem1.Text = "Add Flight";
            this.addFlightToolStripMenuItem1.Click += new System.EventHandler(this.addFlightToolStripMenuItem1_Click);
            // 
            // removeFlightToolStripMenuItem
            // 
            this.removeFlightToolStripMenuItem.Name = "removeFlightToolStripMenuItem";
            this.removeFlightToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.removeFlightToolStripMenuItem.Text = "Remove Flight";
            this.removeFlightToolStripMenuItem.Click += new System.EventHandler(this.removeFlightToolStripMenuItem_Click);
            // 
            // editFlightToolStripMenuItem
            // 
            this.editFlightToolStripMenuItem.Name = "editFlightToolStripMenuItem";
            this.editFlightToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.editFlightToolStripMenuItem.Text = "Edit Flight";
            this.editFlightToolStripMenuItem.Click += new System.EventHandler(this.editFlightToolStripMenuItem_Click);
            // 
            // passengersToolStripMenuItem
            // 
            this.passengersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStoresToolStripMenuItem,
            this.addStoreToolStripMenuItem,
            this.removeStoreToolStripMenuItem,
            this.editStoreToolStripMenuItem});
            this.passengersToolStripMenuItem.Name = "passengersToolStripMenuItem";
            this.passengersToolStripMenuItem.Size = new System.Drawing.Size(92, 36);
            this.passengersToolStripMenuItem.Text = "Stores";
            this.passengersToolStripMenuItem.Click += new System.EventHandler(this.passengersToolStripMenuItem_Click);
            // 
            // viewStoresToolStripMenuItem
            // 
            this.viewStoresToolStripMenuItem.Name = "viewStoresToolStripMenuItem";
            this.viewStoresToolStripMenuItem.Size = new System.Drawing.Size(263, 38);
            this.viewStoresToolStripMenuItem.Text = "View Stores ";
            this.viewStoresToolStripMenuItem.Click += new System.EventHandler(this.viewStoresToolStripMenuItem_Click);
            // 
            // addStoreToolStripMenuItem
            // 
            this.addStoreToolStripMenuItem.Name = "addStoreToolStripMenuItem";
            this.addStoreToolStripMenuItem.Size = new System.Drawing.Size(263, 38);
            this.addStoreToolStripMenuItem.Text = "Add Store";
            this.addStoreToolStripMenuItem.Click += new System.EventHandler(this.addStoreToolStripMenuItem_Click);
            // 
            // removeStoreToolStripMenuItem
            // 
            this.removeStoreToolStripMenuItem.Name = "removeStoreToolStripMenuItem";
            this.removeStoreToolStripMenuItem.Size = new System.Drawing.Size(263, 38);
            this.removeStoreToolStripMenuItem.Text = "Remove Store";
            this.removeStoreToolStripMenuItem.Click += new System.EventHandler(this.removeStoreToolStripMenuItem_Click);
            // 
            // editStoreToolStripMenuItem
            // 
            this.editStoreToolStripMenuItem.Name = "editStoreToolStripMenuItem";
            this.editStoreToolStripMenuItem.Size = new System.Drawing.Size(263, 38);
            this.editStoreToolStripMenuItem.Text = "Edit Store";
            this.editStoreToolStripMenuItem.Click += new System.EventHandler(this.editStoreToolStripMenuItem_Click);
            // 
            // pilotsToolStripMenuItem
            // 
            this.pilotsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPilotsToolStripMenuItem,
            this.addPilotToolStripMenuItem,
            this.removePilotToolStripMenuItem,
            this.editPilotToolStripMenuItem});
            this.pilotsToolStripMenuItem.Name = "pilotsToolStripMenuItem";
            this.pilotsToolStripMenuItem.Size = new System.Drawing.Size(84, 36);
            this.pilotsToolStripMenuItem.Text = "Pilots";
            // 
            // viewPilotsToolStripMenuItem
            // 
            this.viewPilotsToolStripMenuItem.Name = "viewPilotsToolStripMenuItem";
            this.viewPilotsToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.viewPilotsToolStripMenuItem.Text = "View Pilots";
            // 
            // addPilotToolStripMenuItem
            // 
            this.addPilotToolStripMenuItem.Name = "addPilotToolStripMenuItem";
            this.addPilotToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.addPilotToolStripMenuItem.Text = "Add Pilot";
            // 
            // removePilotToolStripMenuItem
            // 
            this.removePilotToolStripMenuItem.Name = "removePilotToolStripMenuItem";
            this.removePilotToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.removePilotToolStripMenuItem.Text = "Remove Pilot";
            // 
            // editPilotToolStripMenuItem
            // 
            this.editPilotToolStripMenuItem.Name = "editPilotToolStripMenuItem";
            this.editPilotToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.editPilotToolStripMenuItem.Text = "Edit Pilot";
            // 
            // routesToolStripMenuItem
            // 
            this.routesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewRoutesToolStripMenuItem,
            this.addRouteToolStripMenuItem,
            this.removeRouteToolStripMenuItem,
            this.editRouteToolStripMenuItem});
            this.routesToolStripMenuItem.Name = "routesToolStripMenuItem";
            this.routesToolStripMenuItem.Size = new System.Drawing.Size(99, 36);
            this.routesToolStripMenuItem.Text = "Routes";
            // 
            // viewRoutesToolStripMenuItem
            // 
            this.viewRoutesToolStripMenuItem.Name = "viewRoutesToolStripMenuItem";
            this.viewRoutesToolStripMenuItem.Size = new System.Drawing.Size(270, 38);
            this.viewRoutesToolStripMenuItem.Text = "View Routes";
            // 
            // addRouteToolStripMenuItem
            // 
            this.addRouteToolStripMenuItem.Name = "addRouteToolStripMenuItem";
            this.addRouteToolStripMenuItem.Size = new System.Drawing.Size(270, 38);
            this.addRouteToolStripMenuItem.Text = "Add Route";
            // 
            // removeRouteToolStripMenuItem
            // 
            this.removeRouteToolStripMenuItem.Name = "removeRouteToolStripMenuItem";
            this.removeRouteToolStripMenuItem.Size = new System.Drawing.Size(270, 38);
            this.removeRouteToolStripMenuItem.Text = "Remove Route";
            // 
            // editRouteToolStripMenuItem
            // 
            this.editRouteToolStripMenuItem.Name = "editRouteToolStripMenuItem";
            this.editRouteToolStripMenuItem.Size = new System.Drawing.Size(270, 38);
            this.editRouteToolStripMenuItem.Text = "Edit Route";
            // 
            // passengerToolStripMenuItem
            // 
            this.passengerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPassengersToolStripMenuItem});
            this.passengerToolStripMenuItem.Name = "passengerToolStripMenuItem";
            this.passengerToolStripMenuItem.Size = new System.Drawing.Size(143, 36);
            this.passengerToolStripMenuItem.Text = "Passengers";
            // 
            // viewPassengersToolStripMenuItem
            // 
            this.viewPassengersToolStripMenuItem.Name = "viewPassengersToolStripMenuItem";
            this.viewPassengersToolStripMenuItem.Size = new System.Drawing.Size(289, 38);
            this.viewPassengersToolStripMenuItem.Text = "View Passengers";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEmployeesToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(142, 36);
            this.employeeToolStripMenuItem.Text = "Employees";
            // 
            // viewEmployeesToolStripMenuItem
            // 
            this.viewEmployeesToolStripMenuItem.Name = "viewEmployeesToolStripMenuItem";
            this.viewEmployeesToolStripMenuItem.Size = new System.Drawing.Size(288, 38);
            this.viewEmployeesToolStripMenuItem.Text = "View Employees";
            // 
            // planeToolStripMenuItem
            // 
            this.planeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPlanesToolStripMenuItem,
            this.addPlaneToolStripMenuItem,
            this.removePlaneToolStripMenuItem,
            this.editPlaneToolStripMenuItem});
            this.planeToolStripMenuItem.Name = "planeToolStripMenuItem";
            this.planeToolStripMenuItem.Size = new System.Drawing.Size(95, 36);
            this.planeToolStripMenuItem.Text = "Planes";
            // 
            // airportToolStripMenuItem
            // 
            this.airportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAirportsToolStripMenuItem,
            this.addAirportToolStripMenuItem,
            this.removeAirportToolStripMenuItem,
            this.editAirportToolStripMenuItem});
            this.airportToolStripMenuItem.Name = "airportToolStripMenuItem";
            this.airportToolStripMenuItem.Size = new System.Drawing.Size(110, 38);
            this.airportToolStripMenuItem.Text = "Airports";
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(100, 36);
            this.ticketToolStripMenuItem.Text = "Tickets";
            // 
            // viewPlanesToolStripMenuItem
            // 
            this.viewPlanesToolStripMenuItem.Name = "viewPlanesToolStripMenuItem";
            this.viewPlanesToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.viewPlanesToolStripMenuItem.Text = "View Planes";
            // 
            // addPlaneToolStripMenuItem
            // 
            this.addPlaneToolStripMenuItem.Name = "addPlaneToolStripMenuItem";
            this.addPlaneToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.addPlaneToolStripMenuItem.Text = "Add Plane";
            // 
            // removePlaneToolStripMenuItem
            // 
            this.removePlaneToolStripMenuItem.Name = "removePlaneToolStripMenuItem";
            this.removePlaneToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.removePlaneToolStripMenuItem.Text = "Remove Plane";
            // 
            // editPlaneToolStripMenuItem
            // 
            this.editPlaneToolStripMenuItem.Name = "editPlaneToolStripMenuItem";
            this.editPlaneToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.editPlaneToolStripMenuItem.Text = "Edit Plane";
            // 
            // viewAirportsToolStripMenuItem
            // 
            this.viewAirportsToolStripMenuItem.Name = "viewAirportsToolStripMenuItem";
            this.viewAirportsToolStripMenuItem.Size = new System.Drawing.Size(281, 38);
            this.viewAirportsToolStripMenuItem.Text = "View Airports";
            this.viewAirportsToolStripMenuItem.Click += new System.EventHandler(this.viewAirportsToolStripMenuItem_Click);
            // 
            // addAirportToolStripMenuItem
            // 
            this.addAirportToolStripMenuItem.Name = "addAirportToolStripMenuItem";
            this.addAirportToolStripMenuItem.Size = new System.Drawing.Size(281, 38);
            this.addAirportToolStripMenuItem.Text = "Add Airport";
            // 
            // removeAirportToolStripMenuItem
            // 
            this.removeAirportToolStripMenuItem.Name = "removeAirportToolStripMenuItem";
            this.removeAirportToolStripMenuItem.Size = new System.Drawing.Size(281, 38);
            this.removeAirportToolStripMenuItem.Text = "Remove Airport";
            // 
            // editAirportToolStripMenuItem
            // 
            this.editAirportToolStripMenuItem.Name = "editAirportToolStripMenuItem";
            this.editAirportToolStripMenuItem.Size = new System.Drawing.Size(281, 38);
            this.editAirportToolStripMenuItem.Text = "Edit Airport";
            // 
            // countriesToolStripMenuItem
            // 
            this.countriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCountriesToolStripMenuItem,
            this.addCountryToolStripMenuItem,
            this.removeCountryToolStripMenuItem,
            this.editCountryToolStripMenuItem});
            this.countriesToolStripMenuItem.Name = "countriesToolStripMenuItem";
            this.countriesToolStripMenuItem.Size = new System.Drawing.Size(129, 36);
            this.countriesToolStripMenuItem.Text = "Countries";
            // 
            // viewCountriesToolStripMenuItem
            // 
            this.viewCountriesToolStripMenuItem.Name = "viewCountriesToolStripMenuItem";
            this.viewCountriesToolStripMenuItem.Size = new System.Drawing.Size(293, 38);
            this.viewCountriesToolStripMenuItem.Text = "View Countries";
            // 
            // addCountryToolStripMenuItem
            // 
            this.addCountryToolStripMenuItem.Name = "addCountryToolStripMenuItem";
            this.addCountryToolStripMenuItem.Size = new System.Drawing.Size(293, 38);
            this.addCountryToolStripMenuItem.Text = "Add Country";
            // 
            // removeCountryToolStripMenuItem
            // 
            this.removeCountryToolStripMenuItem.Name = "removeCountryToolStripMenuItem";
            this.removeCountryToolStripMenuItem.Size = new System.Drawing.Size(293, 38);
            this.removeCountryToolStripMenuItem.Text = "Remove Country";
            // 
            // editCountryToolStripMenuItem
            // 
            this.editCountryToolStripMenuItem.Name = "editCountryToolStripMenuItem";
            this.editCountryToolStripMenuItem.Size = new System.Drawing.Size(293, 38);
            this.editCountryToolStripMenuItem.Text = "Edit Country";
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 718);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMainWindow";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem flightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passengersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFlightToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPilotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPilotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePilotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPilotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem routesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRoutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRouteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeRouteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRouteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPassengersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPlanesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePlaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPlaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAirportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAirportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAirportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAirportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCountriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCountryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCountryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCountryToolStripMenuItem;
    }
}

