using System;
using System.Collections.Generic;
using ConsoleApp2;

namespace RestaurantAsiatique
{
    public class Commande
    {
        private DateTime DateDeCreation;
        private List<IProduit> Produits;
        private double TVA;
        private EStateCommande state = EStateCommande.EnCours;

        internal void addProduit()
        {
            throw new NotImplementedException();
        }

        public Commande(int tva = 5)
        {
            this.TVA = tva;
            this.DateDeCreation = DateTime.Now;
        }

        public void addProduit(IProduit produit)
        {
            this.Produits.Add(produit);
        }
        public void removeDernierProduit()
        {
            this.Produits.RemoveAt(this.Produits.Count-1);
        }
        public double calculTaxe(long prix)
        {
            return prix + ((double)prix / 100 * this.TVA);
        }

        public double getTTc()
        {
            long prixTotal = 0;
            foreach (var produit in this.Produits)
            {
                prixTotal += produit.GetPrix();
            }
            return calculTaxe(prixTotal);
        }
        public string toString()
        {
            string pattern = "dd/MM/yy H:mm:ss";
            string factureTotal="";
            long tempsTotal = 0;
            long prixTotal = 0;
            factureTotal = "Facture du:" + this.DateDeCreation.ToString(pattern)+"\n";
            foreach (var produit in this.Produits)
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
        public EStateCommande State()
        {
            return this.state;
        }

        public void Validate()
        {
            if (this.state == EStateCommande.EnCours)
            {
                this.state = EStateCommande.Valider;
            }
            else if (this.state == EStateCommande.Valider)
            {
                this.state = EStateCommande.Fini;
            }
        }
        public void Cancel()
        {
            this.state = EStateCommande.Annuler;
        }
    }
}