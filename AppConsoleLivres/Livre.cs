using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Livre
    {
        //La propriètes
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int NombrePages { get; set; }
        //Un constructeur

        public Livre(string titre, string auteur, int nombrepages)
        {
            Titre = titre;
            Auteur = auteur;
            NombrePages = nombrepages;
        }
        //Une methode
        public virtual void AfficherDetails()
        {
            Console.WriteLine($"Le titre est {Titre}, l'auteur est {Auteur} et le nombre de pages est {NombrePages}.");
        }
    }
}
