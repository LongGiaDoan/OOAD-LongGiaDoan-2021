using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleKaartspel
{
    class Kaart
    {
         public int nummer;
         public string kleur;

        //public int Nummer { get; set; }
            
        

        //public char GetKleur
        //{
        //    get
        //    {
        //        return kleur;
        //    }
        //    set
        //    {

        //    }
        //}

        public Kaart(int num, string kl)
        {
            this.nummer = num;
            if (kl == "C" || kl == "S" || kl == "H" || kl == "D")
            {
                this.kleur = kl;
            }
            else  throw new ArgumentOutOfRangeException("Foute kleur ingave");
        }
    }
}
