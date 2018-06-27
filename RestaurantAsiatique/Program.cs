using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Sushi.Fabric;
using RestaurantAsiatique;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int id_commande = Restaurant.addCommande(new Commande());
            var sf = new SaumonFabric();
            IProduit sushiA = sf.CreateMaki();
            IProduit sushiB = sf.CreateNigiri();
            Restaurant.getCommande(id_commande).addProduit(sushiA);
            Restaurant.getCommande(id_commande).addProduit(sushiB);
            Restaurant.getCommande(id_commande).removeDernierProduit();
            IMenu MenuA = new MenuAllTuna();
            Restaurant.getCommande(id_commande).addProduit(MenuA);
            Restaurant.getCommande(id_commande).getTTc();
            Restaurant.getCommande(id_commande).toString();
            Console.Write(Restaurant.getCommande(id_commande).toString());
            Restaurant.getCommande(id_commande).Validate();
            var list = Restaurant.getCommandeList(EStateCommande.Valider);
            Restaurant.getCommande(id_commande).toString();
            Restaurant.getCommande(id_commande).Validate();
        }
    }
}
