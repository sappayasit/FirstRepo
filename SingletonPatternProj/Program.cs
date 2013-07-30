using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.UniqueInstance;
            Singleton s2 = Singleton.UniqueInstance;
            s1.Value1 = "AAA";
            s2.Value2 = "BBB";
            SingletonNested s3 = SingletonNested.UniqueInstance;

            
            
        }
    }
}
