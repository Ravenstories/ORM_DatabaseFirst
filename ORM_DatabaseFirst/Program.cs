using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TravelRoute> travelRoute;
            using (var ctx = new ORM_DatabaseFirstEntities())
            {
                travelRoute = ctx.TravelRoutes.ToList<TravelRoute>();
                foreach (TravelRoute a in travelRoute)
                {
                    Console.WriteLine("(" + a.Airport.IATA + ") " + a.Airport.country);
                    
                }
            }

            Console.ReadLine();
        }
    }
}
