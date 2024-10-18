using AppConsoleLivres;

internal class Program
{
    private static void Main(string[] args)
    {
        // les instances de la classe Revue
        Revue revue1 = new Revue("Monde", "Alba", 352, 45, 1980);
        Revue revue2 = new Revue("Ciel", "Messi", 456, 25, 1999);
        Revue revue3 = new Revue("Terre", "Xavi", 548, 5, 2006);

        // la création d'une liste et l'ajout des élèments dans la liste
        List<Revue> Revues = new List<Revue> { revue1, revue2, revue3 };


        Console.WriteLine("les livres dans la liste, leurs details est :");
        foreach (var Revue in Revues)
        {
            Revue.AfficherDetails();
        }
    }
}