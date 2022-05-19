using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Merenje_test_1
{
    public partial class _Default : Page

        
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void SnimiButton_Click(object sender, EventArgs e)
        {
            // Prvi način merenja
            Drzava drz = new Drzava();

            drz.Naziv = NazivTextBox.Text;
            drz.Oznaka = OznakaTextBox.Text;
            // System.Diagnostics.Debug.WriteLine(drz.Naziv, drz.Oznaka);
            drz.Dodaj_U_Bazu();

            Label1.Text = "USPEŠNO SNIMLJENO!";

            // Kraj prvog načina merenja
        }
    }
}