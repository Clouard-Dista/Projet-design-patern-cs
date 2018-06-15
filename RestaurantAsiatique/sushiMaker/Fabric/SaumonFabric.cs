using RestaurantAsiatique.Sushi;
using RestaurantAsiatique.Sushi.Poisson;

namespace ConsoleApp1.Sushi.Fabric
{
    public class SaumonFabric : SushiCreator
    {
        public override ISushi CreateUramaki()
        {
            return new Uramaki(new Saumon());
        }
        public override ISushi CreateNigiri()
        {
            return new Nigiri(new Saumon());
        }
        public override ISushi CreateTemaki()
        {
            return new Temaki(new Saumon());
        }
        public override ISushi CreateMaki()
        {
            return new Maki(new Saumon());
        }
    }
}