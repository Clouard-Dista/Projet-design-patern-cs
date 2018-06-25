using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAsiatique
{
    public class MenuAllBream : IMenu
    {
        private long Prix = 10;
        private long TempsPreparation = 30;
        private string Nom = "Menu All Tuna";

        public MenuAllBream() { }
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
            Console.Write(Nom + "\n\nPour 10€ vous avez : \n- 1 maki daurade\n- 1 nigiri daurade\n- 2 temaki daurade\n- 1 uramaki daurade");
        }
    }
}