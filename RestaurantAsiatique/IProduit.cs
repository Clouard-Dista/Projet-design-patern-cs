namespace RestaurantAsiatique
{
    public interface IProduit
    {
        long GetTemps();
        long GetPrix();
        long GetTempsPreparation();
        string GetNom();
    }
}