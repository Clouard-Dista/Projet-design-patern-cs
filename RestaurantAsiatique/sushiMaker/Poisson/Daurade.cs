namespace RestaurantAsiatique.Sushi.Poisson
{
    public class Daurade : IPoisson
    {
        private long Prix = 1;
        private string Nom = "Daurade";
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