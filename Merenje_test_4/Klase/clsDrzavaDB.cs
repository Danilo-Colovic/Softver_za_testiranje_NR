using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.Data;

namespace Merenje_test_1
{
    
    public class clsDrzavaDB
    {
        
         // atributi
    private string pStringKonekcije="";

        // metode
        
        // konstruktor

    public clsDrzavaDB(string noviStringKonekcije)
    {
        pStringKonekcije = noviStringKonekcije; 
    }

        // javne metode
    public int SnimiPodatke(clsDrzava objNovaDrzava)
        {
            // preuzimanje iz korisnickog interfejsa
            // radi preglednosti koda postavljamo promenljive

            string Oznaka = objNovaDrzava.Oznaka;
            string Naziv = objNovaDrzava.Naziv;

            this.conn = new SqlConnection();
            conn.ConnectionString = pStringKonekcije;
                 
            conn.Open();

            string SQLNaredba = "INSERT INTO DrzavaTable (Naziv, Oznaka) VALUES (@Naziv, @Oznaka)";

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.InsertCommand = new SqlCommand(SQLNaredba,conn);
            adapter.InsertCommand.ExecuteNonQuery();

            conn.Close();

        } // metoda
    } // klasa
} // namespace
