using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Merenje_test_1
{
    public partial class Contact : Page
    {
        private SqlConnection conn;
        Stopwatch stopWatch = new Stopwatch();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.conn = new SqlConnection();
            conn.ConnectionString =
                 " Data Source=(LocalDB)\\MSSQLLocalDB; " +
                 " Initial Catalog=DrzavaDB; " +
                 " User id=; " +
                 " Password=; ";

            stopWatch.Start(); // Početak tajmera
            conn.Open();

            SqlCommand command = conn.CreateCommand();
            string query = "SELECT * FROM DrzavaTable;";
            command.CommandText = query;

            /*
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {  
                    ListaListBox.Items.Add(reader["Naziv"].ToString() + ", " + reader["Oznaka"].ToString());
                }
            }*/

            conn.Close();
            

            stopWatch.Stop(); // Kraj tajmera

            // Ispis merenja
            System.Diagnostics.Debug.WriteLine("RunTime " + stopWatch.ElapsedMilliseconds.ToString(" milisekundi (tabela)."));
        }
    }
}