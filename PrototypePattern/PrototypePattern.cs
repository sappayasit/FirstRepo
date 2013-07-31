﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternProj
{
    // Prototype Pattern Judith Bishop Dec 2006, Nov 2007
    // Serializable is used for the deep copy option
    [Serializable()]
    // Helper class used to create a second level data structure
    class DeeperData
    {
        public string Data { get; set; }
        public DeeperData(string s)
        {
            Data = s;
        }
        public override string ToString()
        {
            return Data;
        }
    }
    [Serializable()]
    class Prototype : IPrototype<Prototype>
    {
        // Content members
        public string Country { get; set; }
        public string Capital { get; set; }
        public DeeperData Language { get; set; }
        public Prototype(string country, string capital, string language)
        {
            Country = country;
            Capital = capital;
            Language = new DeeperData(language);
        }
        public override string ToString()
        {
            return Country + "\t\t" + Capital + "\t\t->" + Language;
        }
    }
    [Serializable()]
    class PrototypeManager : IPrototype<Prototype>
    {
        public Dictionary<string, Prototype> prototypes
        = new Dictionary<string, Prototype> {
                                                {"Germany",new Prototype ("Germany", "Berlin", "German")},
                                                {"Italy",new Prototype ("Italy", "Rome", "Italian")},
                                                {"Australia",new Prototype ("Australia", "Canberra", "English")}
                                            };
    }
    class PrototypeClient : IPrototype<Prototype>
    {
        static void Report(string s, Prototype a, Prototype b)
        {
            Console.WriteLine("\n" + s);
            Console.WriteLine("Prototype " + a + "\nClone " + b);
        }
        static void Main()
        {
            var s = "";
            PrototypeManager manager = new PrototypeManager();
            Prototype c2, c3;
            // Make a copy of Australia's data
            c2 = manager.prototypes["Australia"].Clone();
            Report("Shallow cloning Australia\n===============",
            manager.prototypes["Australia"], c2);
            // Change the capital of Australia to Sydney
            c2.Capital = "Sydney";
            Report("Altered Clone's shallow state, prototype unaffected",
            manager.prototypes["Australia"], c2);
            // Change the language of Australia (deep data)
            c2.Language.Data = "Chinese";
            Report("Altering Clone deep state: prototype affected *****",
            manager.prototypes["Australia"], c2);
            // Make a copy of Germany's data
            c3 = manager.prototypes["Germany"].DeepCopy();
            Report("Deep cloning Germany\n============",
            manager.prototypes["Germany"], c3);
            // Change the capital of Germany
            c3.Capital = "Munich";
            Report("Altering Clone shallow state, prototype unaffected",
            manager.prototypes["Germany"], c3);
            // Change the language of Germany (deep data)
            c3.Language.Data = "Turkish";
            Report("Altering Clone deep state, prototype unaffected",
            manager.prototypes["Germany"], c3);
        }
    }
}
