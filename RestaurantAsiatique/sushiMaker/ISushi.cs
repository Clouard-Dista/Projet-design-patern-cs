using RestaurantAsiatique.Sushi.Poisson;

namespace RestaurantAsiatique.Sushi
{
    public interface ISushi
    {
        IPoisson Poisson { get; }
        long GetPrix();
        long GetTempsPreparation();
        string GetNom();
    }
}