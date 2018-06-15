namespace RestaurantAsiatique.Sushi
{
    public interface ISushiCreator
    {
        ISushi CreateUramaki();
        ISushi CreateNigiri();
        ISushi CreateTemaki();
        ISushi CreateMaki();
    }
}