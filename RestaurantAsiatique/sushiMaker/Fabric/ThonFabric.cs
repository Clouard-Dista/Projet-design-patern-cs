using RestaurantAsiatique.Sushi.Poisson;

namespace ConsoleApp1.Sushi.Fabric
{
    public class ThonFabric : SushiCreator
    {
        public override ISushi CreateUramaki()
        {
            return new Uramaki(new Thon());
        }
        public override ISushi CreateNigiri()
        {
            return new Nigiri(new Thon());
        }
        public override ISushi CreateTemaki()
        {
            return new Temaki(new Thon());
        }
        public override ISushi CreateMaki()
        {
            return new Maki(new Thon());
        }
    }
}