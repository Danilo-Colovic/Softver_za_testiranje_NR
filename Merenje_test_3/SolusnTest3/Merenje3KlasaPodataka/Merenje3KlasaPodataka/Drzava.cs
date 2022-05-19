using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Merenje3KlasaPodataka
{
    public class Drzava
    {
        private string _naziv;
        private string _oznaka;
        // private SqlConnection conn;

        public string Naziv
        {
            get { return this._naziv; }
            set { this._naziv = value; }
        }

        public string Oznaka
        {
            get { return this._oznaka; }
            set { this._oznaka = value; }
        }

        /*
        public void Dodaj_U_Bazu()
        {
            this.conn = new SqlConnection();
            conn.ConnectionString =
                 " Data Source=(LocalDB)\\MSSQLLocalDB; " +
                 " Initial Catalog=DrzavaDB; " +
                 " User id=; "  +
                 " Password=; ";

            conn.Open();
            
            string query = "INSERT INTO DrzavaTable (Naziv, Oznaka)";
            query += " VALUES (@Naziv, @Oznaka)";

            SqlCommand myCommand = new SqlCommand(query, conn);
            myCommand.Parameters.AddWithValue("@Naziv", Naziv);
            myCommand.Parameters.AddWithValue("@Oznaka", Oznaka);
            myCommand.ExecuteNonQuery();
            
            conn.Close();
        }
        */
    }
}