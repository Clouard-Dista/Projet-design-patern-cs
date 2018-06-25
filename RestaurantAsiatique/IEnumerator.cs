using RestaurantAsiatique;

namespace ConsoleApp2
{
    public interface IEnumerator
    {
        void Reset();
        bool MoveNext();
        int Add(Commande commande);
        Commande Get(int id);
        object Current { get; }
        int CurrentId { get; }
    }
}