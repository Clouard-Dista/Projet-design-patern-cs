using System;
using ConsoleApp1.Sushi.Fabric;
using ConsoleApp2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using RestaurantAsiatique;
using RestaurantAsiatique.Sushi;

namespace UnitTestProject4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Restaurant()
        {
            var restaurantA = Restaurant.GetInstance();
            var restaurantB = Restaurant.GetInstance();
            Check.That(restaurantA).IsEqualTo(restaurantB);
        }

        [TestMethod]
        public void Test_SushiFabrick()
        {
            var df = new DauradeFabric();
            ISushi sushiA = df.CreateUramaki();
            ISushi sushiB = df.CreateNigiri();
            Check.That(sushiA.Poisson.GetNom()).IsEqualTo(sushiB.Poisson.GetNom());
        }
        [TestMethod]
        public void senario_a()
        {
            // un employé prend la commande d'un client
            //l'utilisateur clique sur nouvelle commande
            int id_commande = Restaurant.addCommande(new Commande());
            //il veut ajouté un maki et un nigiri a sa commande
            var sf = new SaumonFabric();
            IProduit sushiA = sf.CreateMaki();
            IProduit sushiB = sf.CreateNigiri();
            Restaurant.getCommande(id_commande).addProduit(sushiA);
            Restaurant.getCommande(id_commande).addProduit(sushiB);
            //il veut annulé le nigiri(son dertnier ajout)
            Restaurant.getCommande(id_commande).removeDernierProduit();
            //il veut ajouté un menu
            IMenu MenuA = new MenuAllTuna();
            Restaurant.getCommande(id_commande).addProduit(MenuA);
            //il affiche le total
            Restaurant.getCommande(id_commande).getTTc();
            //ou pour plus de detail
            Restaurant.getCommande(id_commande).toString();
            //il valide sa commande
            Restaurant.getCommande(id_commande).Validate();
            //en cuisine il veules les commande non préparé
            var list = Restaurant.getCommandeEnAttente();
            //en cuisine il veules voir le detail d'une commande non préparé affiché grace a notre liste
            //(pour que se soit plus pratique on va dire d'ils on cliqué sur la commande de notre client)
            Restaurant.getCommande(id_commande).toString();
            //une fois préparé ils valide la preparation de la commande
            Restaurant.getCommande(id_commande).Validate();
            //et le client repart avec sa commande
        }
        [TestMethod]
        public void senario_b()
        {
            // un employé prend la commande d'un client
            //l'utilisateur clique sur nouvelle commande
            int id_commande = Restaurant.addCommande(new Commande());
            //il veut ajouté un maki et un nigiri a sa commande
            var sf = new SaumonFabric();
            IProduit sushiA = sf.CreateMaki();
            IProduit sushiB = sf.CreateNigiri();
            Restaurant.getCommande(id_commande).addProduit(sushiA);
            Restaurant.getCommande(id_commande).addProduit(sushiB);
            //il veut annulé le nigiri(son dertnier ajout)
            Restaurant.getCommande(id_commande).removeDernierProduit();
            //il veut ajouté un menu
            IMenu MenuA = new MenuAllTuna();
            Restaurant.getCommande(id_commande).addProduit(MenuA);
            //il affiche le total
            Restaurant.getCommande(id_commande).getTTc();
            //il valide sa commande
            Restaurant.getCommande(id_commande).Validate();
            //mais le clien déside de partir
            Restaurant.getCommande(id_commande).Cancel();
        }
    }
}
