using FlightControlApi.Models;
using FlightControlModel.Repos;
using System.Collections.Generic;

namespace FlightControlModel.Services
{
    public class PilotService
    {
        private readonly PilotRepo _pilotRepository;

        public PilotService(PilotRepo pilotRepository)
        {
            _pilotRepository = pilotRepository;
        }

        //public Pilot GetAll()
        //{
        //    return _pilotRepository.GetAll();
        //}

        public Pilot Get(int unid)
        {
            return _pilotRepository.Get(unid);
        }

        //public int Insert(Pilot p)
        //{
        //    return _pilotRepository.Insert(a);
        //}
        //public bool Update(Account a)
        //{
        //    return _pilot.Update(a);
        //}
        //public bool Delete(int unid)
        //{
        //    return _accountRepository.Delete(unid);
        //}
    }
}