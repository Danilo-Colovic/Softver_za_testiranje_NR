using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Merenje3KlasaPodataka
{

    public class clsDrzavaDB
    {

        // atributi
        private string pStringKonekcije = "";
        private SqlConnection conn = null;

        public clsDrzavaDB(SqlConnection noviStringKonekcije)
        {
            conn = noviStringKonekcije;
        }

        public void SnimiPodatke(Drzava objNovaDrzava)
        {

            string Oznaka = objNovaDrzava.Oznaka;
            string Naziv = objNovaDrzava.Naziv;

            this.conn = new SqlConnection();
            conn.ConnectionString = pStringKonekcije;

            conn.Open();

            string SQLNaredba = "INSERT INTO DrzavaTable (Naziv, Oznaka)";
            SQLNaredba += " VALUES(@Naziv, @Oznaka)";

            SqlCommand myCommand = new SqlCommand(SQLNaredba, conn);
            myCommand.Parameters.AddWithValue("@Naziv", Naziv);
            myCommand.Parameters.AddWithValue("@Oznaka", Oznaka);
            myCommand.ExecuteNonQuery();

            conn.Close();
        }

            public List<Drzava> UcitajPodatke()
            {
                List<Drzava> drzave = new List<Drzava>();

                conn.Open();

                SqlCommand command = conn.CreateCommand();
                string query = "SELECT * FROM DrzavaTable;";
                command.CommandText = query;
                command.ExecuteNonQuery();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Drzava drz;
                    while (reader.Read())
                    {
                        drz = new Drzava();
                        drz.Naziv = reader["Naziv"].ToString();
                        drz.Oznaka = reader["Oznaka"].ToString();
                        drzave.Add(drz);
                    }
                }
                conn.Close();
                return drzave;
            }
    }
}
