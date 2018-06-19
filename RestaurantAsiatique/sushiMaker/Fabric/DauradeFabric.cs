using RestaurantAsiatique.Sushi;
using RestaurantAsiatique.Sushi.Poisson;

namespace ConsoleApp1.Sushi.Fabric
{
    public class DauradeFabric : SushiCreator
    {
        public override ISushi CreateUramaki()
        {
            return new Uramaki(new Daurade());
        }
        public override ISushi CreateNigiri()
        {
            return new Nigiri(new Daurade());
        }
        public override ISushi CreateTemaki()
        {
            return new Temaki(new Daurade());
        }
        public override ISushi CreateMaki()
        {
            return new Maki(new Daurade());
        }
    }
}