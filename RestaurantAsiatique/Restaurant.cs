using System.Collections.Generic;
using RestaurantAsiatique;

namespace ConsoleApp2
{
    public class Restaurant
    {
        private int lastCommandeId = 0;
        private Dictionary<int, Commande> listCommande = new Dictionary<int, Commande>();
        private static readonly Restaurant _Restaurant = new Restaurant();
        private Restaurant()
        {

        }

        public int addCommande(Commande commande)
        {
            lastCommandeId++;
            listCommande.Add(lastCommandeId, commande);
            return lastCommandeId;
        }
        public Commande getCommande(int id)
        {
            return listCommande[id];
        }
        public Dictionary<int, Commande> getCommandeEnAttente()
        {
            Dictionary<int, Commande> listCommandeEnAttente = new Dictionary<int, Commande>();
            foreach (var commande in listCommande)
            {
                if (commande.Value.IsComplete() && !commande.Value.IsFinish())
                {
                    listCommandeEnAttente.Add(commande.Key, commande.Value);
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