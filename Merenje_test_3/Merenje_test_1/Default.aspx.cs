using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;

using Merenje3KlasaPodataka;

namespace Merenje_test_1
{
    public partial class _Default : Page
    {
        private clsDrzavaDB drzavaDB;
        private SqlConnection conn;
        Stopwatch stopWatch = new Stopwatch();

        protected void Page_Load(object sender, EventArgs e)
        {
            drzavaDB = new clsDrzavaDB(conn);

            this.conn = new SqlConnection();
            conn.ConnectionString =
                     " Data Source=(LocalDB)\\MSSQLLocalDB; " +
                     " Initial Catalog=DrzavaDB; " +
                     " User id=; " +
                     " Password=; ";
        }

        public void SnimiButton_Click(object sender, EventArgs e)
        {
            Drzava drz = new Drzava();
            drz.Naziv = NazivTextBox.Text;
            drz.Oznaka = OznakaTextBox.Text;

            // Treći način merenja

            stopWatch.Start(); // Početak tajmera

            drzavaDB.SnimiPodatke(drz);

            stopWatch.Stop(); // Kraj tajmera

            // Ispis merenja
            System.Diagnostics.Debug.WriteLine("RunTime " + stopWatch.ElapsedMilliseconds.ToString() + " milisekundi.");
        } 
    }
}
