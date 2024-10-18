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


        Console.WriteLine("les revues sont  :");
        foreach (var Revue in Revues)
        {
            Revue.AfficherDetails();
        }

        // les instances de la classe Roman
        Roman roman1 = new Roman("l'enfant noir", "Camara Laye", 221, "Hisoire");
        Roman roman2 = new Roman("Maimouna", "Abdoulaye Sadji", 251, "Education");
        Roman roman3 = new Roman("soue l'orage", "Seydou Badian", 253, "Conflit");

        // la création d'une liste et l'ajout des élèments dans la liste
        List<Roman> Romans = new List<Roman> { roman1,roman2,roman3 };


        Console.WriteLine("les romans sont :");
        foreach (var Roman in Romans)
        {
            Roman.AfficherDetails();
        }
    }
}