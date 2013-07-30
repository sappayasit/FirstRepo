using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternProj
{
    public class SingletonNested
    {
        // Private constructor
        SingletonNested() { }
        // Nested class for lazy instantiation
        class SingletonCreator
        {
            static SingletonCreator() { }
            // Private object instantiated with private constructor
            internal static readonly
            SingletonNested uniqueInstance = new SingletonNested();
        }
        // Public static property to get the object
        public static SingletonNested UniqueInstance
        {
            get { return SingletonCreator.uniqueInstance; }
        }
    }
}
