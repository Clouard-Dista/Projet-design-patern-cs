using RestaurantAsiatique.Sushi.Poisson;

namespace RestaurantAsiatique.Sushi
{
    public class Nigiri : ISushi
    {
        private int Prix = 2;
        private long TempsPreparation = 5;
        private string Nom = "Nigiri";
        public Nigiri(IPoisson poisson)
        {
            Poisson = poisson;
        }
        public long GetPrix()
        {
            return Poisson.GetPrix() + Prix;
        }

        public long GetTempsPreparation()
        {
            if (Poisson.GetCook())
            {
                TempsPreparation = TempsPreparation + 5;
            }
            return TempsPreparation;
        }
        public string GetNom()
        {
            return Nom + "au" + Poisson.GetNom();
        }
        public IPoisson Poisson { get; }
    }
}