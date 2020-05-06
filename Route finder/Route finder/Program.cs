using System;

namespace Route_finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int exist = 1;
            while (exist != 0) 
            { 
           
                Console.WriteLine("Type the country name or address to get the route number..");
            
                var query = Console.ReadLine();
           
                GetRoute find = new GetRoute(query);
           
                find.FindRoute();
            }


            Console.ReadLine();
        }

       
    }
}
