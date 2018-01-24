using System.Data.SqlClient;
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
       

        public PilotService Pilot { get { return _pilot; } }
    }

    public class MSSQLDatabase : DB
    {
        public MSSQLDatabase(string connectionString)
        {
            _connectionString = connectionString;
            _connection = new SqlConnection(_connectionString);
            _command = new SqlCommand();

            _pilot = new PilotService(new PilotRepo(_connection, _command));
        }
    }
}
