using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Roman : Livre
    {
        // la propriete
        public string Genre { get; set; }

        // le constructeur
        public Roman(string titre, string auteur, int nombrepages, string genre) : base(titre, auteur, nombrepages)
        {
            Genre = genre;
        }

        //la methode 
        public override void AfficherDetails()
        {
            Console.WriteLine($"le titre est {Titre},l'auteur est {Auteur},le nombre de page est {NombrePages} et le genre du roman est {Genre}.");
        }
    }
}

