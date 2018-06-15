namespace RestaurantAsiatique.Sushi.Poisson
{
    public class Thon : IPoisson
    {
        private long Prix = 2;
        private string Nom = "Thon";
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