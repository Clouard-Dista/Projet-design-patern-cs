using System;
using System.Collections.Generic;
using System.Text;
using RestaurantAsiatique.Sushi.Poisson;

namespace RestaurantAsiatique
{
    interface ICuisson
    {
        int GetCuisson();
        long GetPrix();
        long GetTempsPreparation();
        string GetNom();
    }
}
