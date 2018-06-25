using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAsiatique
{
    public class MenuAllSalmon : IMenu
    {
        private long Prix = 12;
        private long TempsPreparation = 30;
        private string Nom = "Menu All Salmon";

        public MenuAllSalmon() { }
        public long GetPrix()
        {
            return Prix;
        }
        public long GetTempsPreparation()
        {
            return TempsPreparation;
        }
        public string GetNom()
        {
            return Nom;
        }
        public void DisplayMenu()
        {
            Console.Write(Nom + "\n\nPour 12€ vous avez : \n- 1 maki saumon\n- 1 nigiri saumon\n- 2 temaki saumon\n- 1 uramaki saumon");
        }
    }
}
