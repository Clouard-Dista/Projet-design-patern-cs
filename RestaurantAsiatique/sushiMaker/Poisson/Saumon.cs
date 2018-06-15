namespace RestaurantAsiatique.Sushi.Poisson
{
    public class Saumon : IPoisson
    {
        private long Prix = 3;
        private string Nom = "Saumon";
        public string GetNom()
        {
            return Nom;
        }
        public long GetPrix()
        {
            return Prix;
        }
    }
}