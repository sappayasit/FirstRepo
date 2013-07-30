using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProj
{

    //Classes that implement the AbstractProduct interface and define product objects
    //to be created by the corresponding factories
    // All concrete ProductA's
    class Bag<Brand> : IBag
    where Brand : IBrand, new()
    {
        private Brand myBrand;
        public Bag()
        {
            myBrand = new Brand();

        }
        public string Material { get { return myBrand.Material; } }
    }

    // All concrete ProductB's
    class Shoes<Brand> : IShoes
    where Brand : IBrand, new()
    {
        private Brand myBrand;
        public Shoes()
        {
            myBrand = new Brand();
        }
        public int Price { get { return myBrand.Price; } }
    }

    class Belt<Brand> : IBelt
        where Brand : IBrand, new()
    {
        private Brand myBrand;
        public Belt()
        {
            this.myBrand = new Brand();
        }


        #region IBelt Members


        public string Color
        {
            get { return myBrand.Color; }
        }

        #endregion
    }

}
