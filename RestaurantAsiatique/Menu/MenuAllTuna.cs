using System;
using System.Collections.Generic;

namespace RestaurantAsiatique
{
    public class MenuAllTuna : IMenu
    {
        private long Prix = 11;
        private long TempsPreparation = 30;
        private string Nom = "Menu All Tuna";

        public MenuAllTuna()
        {
        }

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
            Console.Write(
                Nom + "\n\nPour 11€ vous avez : \n- 1 maki thon\n- 1 nigiri thon\n- 2 temaki thon\n- 1 uramaki thon");
        }
    }
}