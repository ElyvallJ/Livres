using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Revue : Livre
    {
        // la propriete
        public int Numero { get; set; }
        public int Annee { get; set; }

        // le constructeur
        public Revue(string titre, string auteur, int nombrepages, int numero, int annee) : base(titre, auteur, nombrepages)
        {
            Numero = numero;
            Annee = annee;
        }

        //la methode 
        public override void AfficherDetails()
        {
            Console.WriteLine($"le titre du revue est {Titre},l'auteur est {Auteur},le nomre de page est {NombrePages},le numero de revue est {Numero} et l'annee de sortie est {Annee}.");
        }

    }
}
