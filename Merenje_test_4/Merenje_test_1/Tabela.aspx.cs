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

using Merenje3KlasaPodataka;

namespace Merenje_test_1
{
    public partial class Contact : Page
    {
        private SqlConnection conn;
        Stopwatch stopWatch = new Stopwatch();
        clsDrzavaDB drzDB;
        List<Drzava> drzaveList = new List<Drzava>();

        protected void Page_Load(object sender, EventArgs e)
        {

            this.conn = new SqlConnection();
            conn.ConnectionString =
                 " Data Source=(LocalDB)\\MSSQLLocalDB; " +
                 " Initial Catalog=DrzavaDB; " +
                 " User id=; " +
                 " Password=; ";

            stopWatch.Start(); // Početak tajmera

            drzDB = new clsDrzavaDB(this.conn);


            drzaveList= drzDB.UcitajPodatke();

            for(int i= 0; i < drzaveList.Count; i++)
            {
                ListaListBox.Items.Add("Naziv: " + drzaveList[i].Naziv);
                ListaListBox.Items.Add("Oznaka: " + drzaveList[i].Oznaka);
            }
            
            stopWatch.Stop(); // Kraj tajmera

            // Ispis merenja
            System.Diagnostics.Debug.WriteLine("RunTime " + stopWatch.ElapsedMilliseconds.ToString() + " milisekundi (tabela).");
        }
    }
}