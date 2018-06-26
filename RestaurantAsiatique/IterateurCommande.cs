using System.Collections.Generic;
using RestaurantAsiatique;

namespace ConsoleApp2
{
    public class IterateurCommande : IEnumerator
    {
        private List<Commande> _chainesAParcourir =new List<Commande>();
        private int _positionCourante = -1;
        public int lastId = 0;

        public void Reset() { _positionCourante = -1; }

        public int Add(Commande commande)
        {
            _chainesAParcourir.Add(commande);
            return _chainesAParcourir.Count-1;
        }
        public Commande Get(int id)
        {
            return _chainesAParcourir[id];
        }

        public bool MoveNext()
        {
            if (_positionCourante + 1 >= _chainesAParcourir.Count) return false;

            _positionCourante += 1;
            return true;
        }

        public object Current { get { return _chainesAParcourir[_positionCourante]; } }
        public int CurrentId { get { return _positionCourante; } }
    }
}