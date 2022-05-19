using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Merenje_test_1
{
    public partial class Contact : Page
    {
        private SqlConnection conn;
        Stopwatch stopWatch = new Stopwatch();

        protected void Page_Load(object sender, EventArgs e)
        {
            Ucitaj_Drzave();   
        }

        public void Ucitaj_Drzave()
        {
            this.conn = new SqlConnection();
            conn.ConnectionString =
                 " Data Source=(LocalDB)\\MSSQLLocalDB; " +
                 " Initial Catalog=DrzavaDB; " +
                 " User id=; " +
                 " Password=; ";

            stopWatch.Start(); // Početak tajmera
            conn.Open();

            SqlCommand myCommand = new SqlCommand("PrikaziDrz", conn);
            myCommand.CommandType = CommandType.StoredProcedure;

            using (SqlDataReader reader = myCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    ListaListBox.Items.Add("Naziv: " + reader["Naziv"].ToString());
                    ListaListBox.Items.Add("Oznaka: " + reader["Oznaka"].ToString());
                }
            }

            conn.Close();
            stopWatch.Stop(); // Kraj tajmera

            // Ispis merenja
            System.Diagnostics.Debug.WriteLine("RunTime " + stopWatch.ElapsedMilliseconds.ToString() + " milisekundi (tabela).");
        }
    }
}