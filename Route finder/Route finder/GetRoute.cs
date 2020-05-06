using System;
using System.Collections.Generic;
using System.Text;

namespace Route_finder
{
    class GetRoute
    {
        string country;
        public GetRoute(string query)
        {
             country = query.ToLower();
        }

        public void FindRoute()
        {
            switch (country)
            {
                case "orio al serio": Console.WriteLine("By73");
                    break;
                case "seriate":
                    Console.WriteLine("By66");
                    break;
                case "grassobbio": Console.WriteLine("type the correct address please..");
                    string address = Console.ReadLine().ToLower();
                    if(address == "via orio al serio" || address == "via matteotti")
                    {
                        Console.WriteLine("By31");
                    }
                    else
                    {
                        Console.WriteLine("By73");
                    }
                    break;
                case "adrara san martino": Console.WriteLine("By56");
                        break;
                case "adrara san rocco":
                    Console.WriteLine("By56");
                        break;
                case "albano": Console.WriteLine("By57");
                    break;
                case "albano sant'alessandro":
                    Console.WriteLine("By57");
                    break;
                case "albino": Console.WriteLine("Type the correct address please..");
                    address = Console.ReadLine().ToLower();
                    if(address == "via marconi" || address == "via provinciale" || address == "via roncaglia"|| address == "via serio" || address == "via sottoprovinciale")
                    {
                        Console.WriteLine("By47");
                    }
                    else
                    {
                        Console.WriteLine("By40");
                    }
                        break;
                case "algua": Console.WriteLine("ByQ2 ex By78");
                    break;
                case "almè":
                    Console.WriteLine("By62");
                    break;
                case "almenno san bartolomeo":
                    Console.WriteLine("By27");
                    break;
                case "almenno san salvatore":
                    Console.WriteLine("By62");
                    break;
                case "alzano lombardo":
                    Console.WriteLine("By77");
                    break;
                case "ambivere":
                    Console.WriteLine("By60");
                    break;
                case "antegnate":
                    Console.WriteLine("By61");
                    break;
                case "arcene":
                    Console.WriteLine("By54");
                    break;
                case "ardesio":
                    Console.WriteLine("Q3 ex By30");
                    break;
                case "arzago d'adda":
                    Console.WriteLine("By41");
                    break;
                case "averara":
                    Console.WriteLine("ByQ2");
                    break;
                case "aviatico":
                    Console.WriteLine("ByQ2");
                    break;
                case "azzano san paolo":
                    Console.WriteLine("by59");
                    break;
                case "azzone":
                    Console.WriteLine("ByQ5");
                    break;
                case "bagnatica":
                    Console.WriteLine("By31");
                    break;
                case "barbata":
                    Console.WriteLine("By61");
                    break;
                case "bariano":
                    Console.WriteLine("By45");
                    break;
                case "barzana":
                    Console.WriteLine("By27");
                    break;
            }
        }

    }
}
