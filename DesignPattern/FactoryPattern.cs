using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternProj
{
    public class FactoryPattern
    {

        // Factory Method Pattern Judith Bishop 2006
        public interface IProduct
        {
            string ShipFrom();
        }
        public class ProductA : IProduct
        {
            public String ShipFrom()
            {
                return " from South Africa";
            }
        }
        public class ProductB : IProduct
        {
            public String ShipFrom()
            {
                return "from Spain";
            }
        }

        public class DefaultProduct : IProduct
        {
            public String ShipFrom()
            {
                return "not available";
            }
        }


        public class Creator
        {
            public IProduct FactoryMethod(int month)
            {
                if (month >= 4 && month <= 11)
                    return new ProductA();
                else
                    if (month == 1 || month == 2 || month == 12)
                        return new ProductB();
                    else return new DefaultProduct();
            }
        }


        static void Main()
        {

            Creator c = new Creator();
            IProduct product;
            for (int i = 1; i <= 12; i++)
            {
                product = c.FactoryMethod(i);
                Console.WriteLine("Avocados " + product.ShipFrom());
            }
            Console.ReadKey();
             
        }

       
    }
}
