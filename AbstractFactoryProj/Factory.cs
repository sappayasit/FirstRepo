using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProj
{

    // Concrete Factories (both in the same one)
    /// <summary>
    /// Implementations of all the AbstractFactory creation operations
    /// </summary>
    /// <typeparam name="Brand"></typeparam>
    class Factory<Brand> : IFactory<Brand>
    where Brand : IBrand, new()
    {
        public IBag CreateBag()
        {
            return new Bag<Brand>();
        }
        public IShoes CreateShoes()
        {
            return new Shoes<Brand>();
        }
        public IBelt CreateBelt()
        {
            return new Belt<Brand>();
        }

    }
}
