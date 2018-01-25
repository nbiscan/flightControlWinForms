﻿using System.Data.SqlClient;
using System.Data;
using FlightControlModel.Services;
using FlightControlModel.Repos;

namespace FlightControlModel
{
    public abstract class DB
    {
        protected string _connectionString = string.Empty;
        protected IDbConnection _connection;
        protected IDbCommand _command;

        protected PilotService _pilot;
        protected AirportService _airport;
        protected CountryService _country;
        protected FlightService _flight;
        protected PassengerService _passenger;
        protected PlaneService _plane;
        protected RouteService _route;
        protected SeatService _seat;
       
        public PilotService Pilot { get { return _pilot; } }
        public AirportService Airport { get { return _airport; } }
        public CountryService Country { get { return _country; } }
        public FlightService Flight { get { return _flight; } }
        public PassengerService Passenger { get { return _passenger; } }
        public PlaneService Plane { get { return _plane; } }
        public RouteService Route { get { return _route; } }
        public SeatService Seat { get { return _seat; } }
    }

    public class MSSQLDatabase : DB
    {
        public MSSQLDatabase(string connectionString)
        {
            _connectionString = connectionString;
            _connection = new SqlConnection(_connectionString);
            _command = new SqlCommand();

            _pilot = new PilotService(new PilotRepo(_connection, _command));
            _airport = new AirportService(new AirportRepo(_connection, _command));
        }
    }
}
