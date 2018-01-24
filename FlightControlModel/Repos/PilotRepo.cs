using FlightControlApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FlightControlModel.Repos
{
    public class PilotRepo : CRUD
    {
        public PilotRepo(IDbConnection conn, IDbCommand comm) : base(conn, comm)
        {
        }

        public  Pilot Get(int id)
        {
            Pilot p;

            _comm.CommandText = "SELECT * " +
                                "FROM Pilot p " +
                                "WHERE p.ID = @id;";

            _comm.AddParameter("@id", id);

            _conn.Open();

            try
            {
                using (IDataReader rdr = _comm.ExecuteReader())
                {
                    rdr.Read();

                    p = new Pilot()
                    {
                        Id = Convert.ToInt32(rdr["Id"]),
                        FirstName = Convert.ToString(rdr["FirstName"]),
                        LastName = Convert.ToString(rdr["LastName"]),
                        BirthDay = Convert.ToDateTime(rdr["BirthDay"]),

                    };

                }

                _conn.Close();

                return p;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _comm.Parameters.Clear();
                _conn.Close();
            }


        }
        //public  List<Pilot> GetAll()
        //{

        //}
        //public  int Insert(Pilot a)
        //{

        //}
        //public  bool Update(int id, Pilot a)
        //{

        //}
        //public  bool Delete(int id)
        //{

        //}
    }
}
