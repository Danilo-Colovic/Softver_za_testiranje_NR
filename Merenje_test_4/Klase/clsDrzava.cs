using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KlasePodataka
{
    public class clsDrzava
    {
        //-------------ATRIBUTI

        // polja - sustinski atributi
        private string pOznaka;
        private string pNaziv;
        private int pUkupnoMesta;

        // public property
        public string Oznaka
        {
            get
            {
                return pOznaka;
            }
            set
            {
                if (this.pOznaka != value)
                    this.pOznaka = value;
            }
        }

        public string Naziv
        {
            get
            {
                return pNaziv;
            }
            set
            {
                if (this.pNaziv != value)
                    this.pNaziv = value;
            }
        }

        public int UkupnoMesta
        {
            get
            {
                return pUkupnoMesta;
            }
            set
            {
                if (this.pUkupnoMesta != value)
                    this.pUkupnoMesta = value;
            }
        }


        // --------- METODE

        //konstruktor

        public clsDrzava()
        {
            // inicijalizacija polja
            pOznaka="";
            pNaziv="";
            pUkupnoMesta=0;
        }

    }
}
