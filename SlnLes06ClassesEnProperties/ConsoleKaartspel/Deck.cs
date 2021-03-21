using System.Collections.Generic;

namespace ConsoleKaartspel
{
    class Deck
    {
        public List<Kaart> Kaarts { get; set; } = new List<Kaart>();

        public Deck()
        {
            for (int kl = 0; kl < 4; kl++)
            {
                for (int i = 1; i < 14; i++)
                {
                    string getalKleur;

                    switch (kl)
                    {
                        case 0:
                            getalKleur = "S";
                            break;
                        case 1:
                            getalKleur = "H";
                            break;
                        case 2:
                            getalKleur = "D";
                            break;
                        case 3:
                            getalKleur = "C";
                            break;
                        default:
                            getalKleur = "S";
                            break;

                    }

                    Kaarts.Add(new Kaart(i, getalKleur));
                }
            }
        }
    }
}
