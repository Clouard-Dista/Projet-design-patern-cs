namespace RestaurantAsiatique.Sushi
{
    public abstract class SushiCreator: ISushiCreator
    {
        public abstract ISushi CreateUramaki();
        public abstract ISushi CreateNigiri();
        public abstract ISushi CreateTemaki();
        public abstract ISushi CreateMaki();
    }
}