using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProj
{

    // Abstract Factory D-J Miller and Judith Bishop Sept 2007
    // Uses generics to simplify the creation of factories
    // Factory Interface
    /// <summary>
    /// An interface with Create operations for each of the abstract products
    /// </summary>
    /// <typeparam name="Brand"></typeparam>
    interface IFactory<Brand>
    where Brand : IBrand
    {
        IBag CreateBag();
        IShoes CreateShoes();
        IBelt CreateBelt();
    }




    // An interface for all Brands
    interface IBrand
    {
        int Price { get; }
        string Material { get; }
        string Color { get; }
    }

    class Gucci : IBrand
    {
        public int Price { get { return 1000; } }
        public string Material { get { return "Crocodile skin"; } }

        public string Color
        {
            get { return "Green"; }
        }


    }
    class Poochy : IBrand
    {
        public int Price { get { return new Gucci().Price / 3; } }
        public string Material { get { return "Plastic"; } }

        public string Color
        {
            get { return "Yellow"; }
        }
    }
    class Groundcover : IBrand
    {
        public int Price { get { return 2000; } }
        public string Material { get { return "South african leather"; } }
        public string Color
        {
            get { return "Grey"; }
        }
    }

    /// <summary>
    /// A class that accesses only the AbstractFactory and AbstractProduct interfaces
    /// </summary>
    /// <typeparam name="Brand"></typeparam>
    class Client<Brand>
    where Brand : IBrand, new()
    {
        public void ClientMain() //IFactory<Brand> factory)
        {
            IFactory<Brand> factory = new Factory<Brand>();
            IBag bag = factory.CreateBag();
            IShoes shoes = factory.CreateShoes();
            IBelt belt = factory.CreateBelt();
           
            Console.WriteLine("I bought a Bag which is made from " + bag.Material);
            Console.WriteLine("I bought some shoes which cost " + shoes.Price);
            Console.WriteLine("I bought a belt which is a " + belt.Color);
        }
    }


}
