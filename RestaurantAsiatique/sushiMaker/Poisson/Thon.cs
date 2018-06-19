namespace RestaurantAsiatique.Sushi.Poisson
{
    public class Thon : IPoisson
    {
        private long Prix = 2;
        private string Nom = "Thon";
        private bool Cook = false;
        public string GetNom()
        {
            return Nom;
        }
        public long GetPrix()
        {
            return Prix;
        }
        public bool GetCook()
        {
            return Cook;
        }
        public void Cooked()
        {
            Prix = Prix + 1;
            Cook = true;
        }
        public void UnCooked()
        {
            Prix = Prix + 0;
            Cook = false;
        }
    }
}