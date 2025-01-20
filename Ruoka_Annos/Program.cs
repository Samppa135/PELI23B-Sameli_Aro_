namespace Ruoka_Annos
{
    using System;
    using System.Collections.Generic;

    // Määritellään enumeraattorit pääraaka-aineille, lisukkeille ja kastikkeille
    public enum PaaraakaAine { Nautaa, Kanaa, Kasviksia }
    public enum Lisuke { Perunaa, Riisia, Pastaa }
    public enum Kastike { Curry, Hapanimela, Pippuri, Chili }

    // Luodaan luokka kuvaamaan ruoka-annosta
    class Ateria
    {
        public PaaraakaAine PaaraakaAine { get; set; }
        public Lisuke Lisuke { get; set; }
        public Kastike Kastike { get; set; }

        // Konstruktorin avulla voidaan asettaa arvot
        public Ateria(PaaraakaAine paaraakaAine, Lisuke lisuke, Kastike kastike)
        {
            PaaraakaAine = paaraakaAine;
            Lisuke = lisuke;
            Kastike = kastike;
        }

        // Tulostusmetodi
        public override string ToString()
        {
            return $"{PaaraakaAine.ToString().ToLower()} ja {Lisuke.ToString().ToLower()} {Kastike.ToString().ToLower()}-kastikkeella";
        }
    }

            // Lista aterioista

            // Käyttäjän syöte ja aterioiden valinta

            // Tulostetaan kaikki valitut ateriat

        }
    

