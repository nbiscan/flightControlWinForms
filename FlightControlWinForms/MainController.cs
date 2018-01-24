using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;



namespace FlightControlWinForms
{
    public class MainController : IMainController
    {
        public void AddAirports()
        {
            FormAddAirport faa = new FormAddAirport();
            faa.ShowDialog();
        }

        public void AddCountries()
        {
            FormAddCountry fac = new FormAddCountry();
            fac.ShowDialog();
        }

        public void AddFlights()
        {
            FormAddFlight faf = new FormAddFlight();
            faf.ShowDialog();
        }

        public void AddPilots()
        {
            FormAddPilot fap = new FormAddPilot();
            fap.ShowDialog();
        }

        public void AddPlanes()
        {
            FormAddPlane fap = new FormAddPlane();
            fap.ShowDialog();
        }

        public void AddStores()
        {
            FormAddStore fas = new FormAddStore();
            fas.ShowDialog();
        }

        public void EditAirports()
        {
            FormEditAirport fea = new FormEditAirport();
            fea.ShowDialog();
        }

        public void EditCountries()
        {
            FormEditCountry fec = new FormEditCountry();
            fec.ShowDialog();
        }

        public void EditFlights()
        {
            FormEditFlights fef = new FormEditFlights();
            fef.ShowDialog();
        }

        public void EditPilots()
        {
            FormEditPilot fep = new FormEditPilot();
            fep.ShowDialog();
        }

        public void EditPlanes()
        {
            FormEditPlane fep = new FormEditPlane();
            fep.ShowDialog();
        }

        public void EditStores()
        {
            FormEditStore fes = new FormEditStore();
            fes.ShowDialog();
        }

        public void RemoveAirports()
        {
            FormEditAirport fea = new FormEditAirport();
            fea.ShowDialog();
        }

        public void RemoveCountries()
        {
            FormEditCountry fec = new FormEditCountry();
            fec.ShowDialog();
        }

        public void RemoveFlights()
        {
            FormEditFlights fef = new FormEditFlights();
            fef.ShowDialog();
        }

        public void RemovePilots()
        {
            FormEditPilot fep = new FormEditPilot();
            fep.ShowDialog();
        }

        public void RemovePlanes()
        {
            FormEditPlane fep = new FormEditPlane();
            fep.ShowDialog();
        }

        public void RemoveStores()
        {
            FormEditStore fes = new FormEditStore();
            fes.ShowDialog();
        }

        public void ViewAirports()
        {
            FormEditAirport fea = new FormEditAirport();
            fea.ShowDialog();
        }

        public void ViewCountries()
        {
            FormEditCountry fec = new FormEditCountry();
            fec.ShowDialog();
        }

        public void ViewFlights()
        {
            FormEditFlights fef = new FormEditFlights();
            fef.ShowDialog();
        }

        public void ViewPilots()
        {
            FormEditPilot fep = new FormEditPilot();
            fep.ShowDialog();
        }

        public void ViewPlanes()
        {
            FormEditPlane fep = new FormEditPlane();
            fep.ShowDialog();
        }

        public void ViewStores()
        {
            FormEditStore fes = new FormEditStore();
            fes.ShowDialog();
        }
    }
}
