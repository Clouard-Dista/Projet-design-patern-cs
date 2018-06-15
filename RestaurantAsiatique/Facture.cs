using System;
using System.Collections.Generic;

namespace RestaurantAsiatique
{
    public class Facture
    {
        private DateTime DateDeCreation;
        private List<IProduit> Produits;
        private double TVA = 5;
        private static readonly Facture _facture = new Facture();
        public Facture()
        {
            _facture.DateDeCreation = DateTime.Now;
        }

        public void addProduit(IProduit produit)
        {
            _facture.Produits.Add(produit);
        }
        public double calculTaxe(long prix)
        {
            return prix + ((double)prix / 100 * _facture.TVA);
        }
        public string toString()
        {
            string pattern = "dd/MM/yy H:mm:ss";
            string factureTotal="";
            long tempsTotal = 0;
            long prixTotal = 0;
            factureTotal = "Facture du:" + _facture.DateDeCreation.ToString(pattern)+"\n";
            foreach (var produit in _facture.Produits)
            {
                factureTotal += produit.GetNom() + "//" + produit.GetPrix() + "\n";
                tempsTotal += produit.GetTempsPreparation();
                prixTotal += produit.GetPrix();
            }
            long tts = tempsTotal % 60;
            long ttm = (tempsTotal - tts) / 60;
            factureTotal += "Temps de preparation " + ttm + "m " + tts + "s.\n";
            factureTotal += "Prix ttc " + calculTaxe(prixTotal) + "€";
            return factureTotal;
        }

        public static Facture GetInstance()
        {
            return _facture;
        }
    }
}