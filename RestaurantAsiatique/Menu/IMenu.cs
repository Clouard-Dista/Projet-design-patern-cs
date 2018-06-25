using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantAsiatique;

namespace RestaurantAsiatique
{
    public interface IMenu:IProduit
    {
        void DisplayMenu();
        
    }
}
