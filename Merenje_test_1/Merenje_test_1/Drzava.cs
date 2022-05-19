using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Merenje_test_1
{
    public class Drzava
    {
        private string _naziv;
        private string _oznaka;
        private SqlConnection conn;
        Stopwatch stopWatch = new Stopwatch();

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

        public void Dodaj_U_Bazu()
        {
            // Prvi način merenja
            this.conn = new SqlConnection();
            conn.ConnectionString =
                 " Data Source=(LocalDB)\\MSSQLLocalDB; " +
                 " Initial Catalog=DrzavaDB; " +
                 " User id=; "  +
                 " Password=; ";

            stopWatch.Start(); // Takmer Start
            conn.Open();
            
            string query = "INSERT INTO DrzavaTable (Naziv, Oznaka)";
            query += " VALUES (@Naziv, @Oznaka)";

            SqlCommand myCommand = new SqlCommand(query, conn);
            myCommand.Parameters.AddWithValue("@Naziv", Naziv);
            myCommand.Parameters.AddWithValue("@Oznaka", Oznaka);
            myCommand.ExecuteNonQuery();
            
            conn.Close();
            stopWatch.Stop(); // Tajmer Kraj

            // Prikaz tajmera u konzoli
            System.Diagnostics.Debug.WriteLine("RunTime " + stopWatch.ElapsedMilliseconds.ToString() + " milisekundi.");
            // Kraj prvog načina merenja
        }
    }
}