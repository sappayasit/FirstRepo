using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProj
{

    // Interface IProductA
    /// <summary>
    /// AbstractProduct
    //An interface for a kind of product with its own operations
    /// </summary>
    interface IBag
    {
        string Material { get; }
    }
    // Interface IProductB
    interface IShoes
    {
        int Price { get; }
    }
    interface IBelt
    {
        string Color { get; }
    }

   
}
