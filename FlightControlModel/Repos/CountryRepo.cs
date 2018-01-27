using FlightControlApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FlightControlModel.Repos
{
    public class CountryRepo:CRUD
    {
        public CountryRepo(IDbConnection conn, IDbCommand comm) : base(conn, comm)
        {
        }

        public Country Get(int id)
        {
            Country a;

            _comm.CommandText = "SELECT * " +
                                "FROM country a " +
                                "WHERE a.Id = @id;";

            _comm.AddParameter("@id", id);

            _conn.Open();

            try
            {
                using (IDataReader rdr = _comm.ExecuteReader())
                {
                    rdr.Read();

                    a = new Country()
                    {
                        Id = Convert.ToInt32(rdr["id"]),
                        iso = Convert.ToString(rdr["iso"]),
                        name = Convert.ToString(rdr["name"]),
                        printable_name = Convert.ToString(rdr["printable_name"]),
                        iso3 = Convert.ToString(rdr["iso3"]),
                        numcode = Convert.ToInt32(rdr["numcode"])

                    };

                }

                _conn.Close();

                return a;
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

        public List<Country> GetAll()
        {
            List<int> allCountrysIDs = new List<int>();
            List<Country> allCountrys = new List<Country>();

            _comm.CommandText = "SELECT * " +
                                "FROM country ";

            _conn.Open();

            try
            {
                using (IDataReader rdr = _comm.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        allCountrysIDs.Add(Convert.ToInt32(rdr["id"]));
                    }
                }

                _conn.Close();

                foreach (int id in allCountrysIDs)
                {
                    allCountrys.Add(this.Get(id));
                }

                return allCountrys;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
        }


    }
}
