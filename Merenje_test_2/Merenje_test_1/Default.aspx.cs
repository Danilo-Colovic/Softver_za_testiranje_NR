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
    public partial class _Default : Page   
    {
        SqlConnection conn = new SqlConnection();
        Stopwatch stopWatch = new Stopwatch();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        // Drugi način merenja (stored procedure)

        public void Dodaj_U_Bazu()
        {
            this.conn = new SqlConnection();
            conn.ConnectionString =
                 " Data Source=(LocalDB)\\MSSQLLocalDB; " +
                 " Initial Catalog=DrzavaDB; " +
                 " User id=; " +
                 " Password=; ";
            stopWatch.Start(); // Početak tajmera
            conn.Open();

            SqlCommand myCommand = new SqlCommand("DodajNovuDrzavu", conn);

            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.Add("@Naziv", SqlDbType.VarChar).Value = NazivTextBox.Text;
            myCommand.Parameters.Add("@Oznaka", SqlDbType.VarChar).Value = OznakaTextBox.Text;
            myCommand.ExecuteNonQuery();

            conn.Close();
            stopWatch.Stop(); // Kraj tajmera
            conn.Dispose();

            System.Diagnostics.Debug.WriteLine("RunTime " + stopWatch.ElapsedMilliseconds.ToString() + " milisekundi.");
        }

        // Kraj drugog načina merenja

        public void SnimiButton_Click(object sender, EventArgs e)
        {
            // Drugi način merenja

            Dodaj_U_Bazu();

            // Kraj drugog načina merenja
        }
    }
}