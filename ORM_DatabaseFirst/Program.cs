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
                //Get routes and store add to our list. 
                travelRoute = ctx.TravelRoute.ToList<TravelRoute>();
                foreach (TravelRoute a in travelRoute)
                {
                    // Shows all the travel routes. 
                    Console.WriteLine("(" + a.fromId + ") To " + "(" + a.toId +")");
                    
                }
            }

            Console.ReadLine();
        }
    }
}
