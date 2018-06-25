using System;

namespace RestaurantAsiatique.User
{
    public class OptionsMaker
    {
        private IOptions ajouter;
        private IOptions enlever;
        private IOptions annuler;
        private IOptions valider;

        public OptionsMaker()
        {
            ajouter = new Ajouter();
            enlever = new Enlever();
            annuler = new Annuler();
            valider = new Valider();
        }

        public void ajouterProduit()
        {
            ajouter.choiceOptions();
        }
        public void enleverProduit()
        {
            enlever.choiceOptions();
        }
        public void annulerCommande()
        {
            annuler.choiceOptions();
        }
        public void validerCommande()
        {
            valider.choiceOptions();
        }
    }
}
