using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightControlWinForms
{
    public interface IMainController
    {
        void ViewFlights();
        void AddFlights();
        void RemoveFlights();
        void EditFlights();

        void ViewStores();
        void AddStores();
        void RemoveStores();
        void EditStores();

        void ViewPilots();
        void AddPilots();
        void RemovePilots();
        void EditPilots();

        void ViewAirports();
        void AddAirports();
        void RemoveAirports();
        void EditAirports();

        void ViewCountries();
        void AddCountries();
        void RemoveCountries();
        void EditCountries();

        void ViewPlanes();
        void AddPlanes();
        void RemovePlanes();
        void EditPlanes();

        
    }
}
