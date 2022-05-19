using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using Merenje_test_1;

namespace Merenje3KlasaPodataka
{

    public class clsDrzavaDB
    {

        // atributi
        private SqlConnection conn;
        private string Naziv;
        private string Oznaka;
        public List<Drzava> readerList = new List<Drzava>();

        public clsDrzavaDB(SqlConnection noviStringKonekcije)
        {
            this.conn = noviStringKonekcije;
        }

        public void SnimiPodatke(Drzava objNovaDrzava)
        {

            this.Oznaka = objNovaDrzava.Oznaka;
            this.Naziv = objNovaDrzava.Naziv;

            conn.Open();

            SqlCommand myCommand = new SqlCommand("DodajNovuDrzavu", conn);

            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.Add("@Naziv", SqlDbType.VarChar).Value = Naziv;
            myCommand.Parameters.Add("@Oznaka", SqlDbType.VarChar).Value = Oznaka;
            myCommand.ExecuteNonQuery();

            conn.Close();
        }

        public List<Drzava> UcitajPodatke()
        {
            List<Drzava> drzave = new List<Drzava>();

            conn.Open();

            SqlCommand myCommand = new SqlCommand("PrikaziDrz", conn);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.ExecuteNonQuery();

            using (SqlDataReader reader= myCommand.ExecuteReader())
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
