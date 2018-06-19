namespace RestaurantAsiatique.Sushi.Poisson
{
    public interface IPoisson
    {
        long GetPrix();
        string GetNom();
        //pattern Etat
        bool GetCook();
        void Cooked();
        void UnCooked();
    }
}