using RestaurantAsiatique.Sushi.Poisson;

namespace RestaurantAsiatique.Sushi
{
    public class Uramaki : ISushi
    {
        private int Prix = 4;
        private long TempsPreparation = 15;
        private string Nom = "Uramaki";
        public Uramaki(IPoisson poisson)
        {
            Poisson = poisson;
        }
        public long GetPrix()
        {
            return Poisson.GetPrix() + Prix;
        }
        public long GetTempsPreparation()
        {
            return TempsPreparation;
        }
        public string GetNom()
        {
            return Nom + "au" + Poisson.GetNom();
        }
        public IPoisson Poisson { get; }
    }
}