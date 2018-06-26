using System.Collections.Generic;
using RestaurantAsiatique;

namespace ConsoleApp2
{
    public class Restaurant
    {
        private int lastCommandeId = 0;
        private static readonly Restaurant _Restaurant = new Restaurant();
        IterateurCommande listCommande = new IterateurCommande();
        private Restaurant()
        {

        }

        public static int addCommande(Commande commande)
        {
            return _Restaurant.listCommande.Add(commande);
        }
        public static Commande getCommande(int id)
        {
            return _Restaurant.listCommande.Get(id);
        }
        public static Dictionary<int, Commande> getCommande(EStateCommande State = EStateCommande.All)
        {
            _Restaurant.listCommande.Reset();
            Dictionary<int, Commande> listCommandeEnAttente = new Dictionary<int, Commande>();
            while (_Restaurant.listCommande.MoveNext())
            {
                if (State == EStateCommande.All || (((Commande)_Restaurant.listCommande.Current).State() == State))
                {
                    listCommandeEnAttente.Add(_Restaurant.listCommande.CurrentId, (Commande)_Restaurant.listCommande.Current);
                }
            }
            return listCommandeEnAttente;
        }
        public static Restaurant GetInstance()
        {
            return _Restaurant;
        }
    }
}