using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using spotter.Models;

namespace spotter.DAL
{
    public class SpotInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SpotContext>
    {
        protected override void Seed(SpotContext context)
        {
            var spots = new List<Spot>
            {
        new Spot{lat=40.45225689999999,lng=-86.1270723},
        new Spot{lat=40.0479672,lng=-86.1322524},
        new Spot{lat=39.9107272,lng=-86.2388994},
        new Spot{lat=39.9220246,lng=-86.2223944},
        new Spot{lat=39.8927069,lng=-86.2141299},
        new Spot{lat=39.9073707,lng=-86.22197779999999},
        new Spot{lat=40.03042600000001,lng=-85.84284199999999},
        new Spot{lat=39.9153553,lng=-86.06655359999999},
        new Spot{lat=39.9546491,lng=-86.2422428},
        new Spot{lat=40.0417282,lng=-86.1282634},
        new Spot{lat=39.811414,lng=-86.1560901},
        new Spot{lat=39.8399234,lng=-86.1491224},
        new Spot{lat=39.80743409999999,lng=-86.1562615},
        new Spot{lat=40.002108,lng=-86.129966},
        new Spot{lat=39.9994355,lng=-86.129431},
        new Spot{lat=40.0479672,lng=-86.1322524},
        new Spot{lat=39.806843,lng=-86.1560446},
        new Spot{lat=39.8076166,lng=-86.1573312},
        new Spot{lat=39.8246639,lng=-86.15277890000002},
        new Spot{lat=39.800108,lng=-86.156543},
        new Spot{lat=39.9189678,lng=-86.111159},
        new Spot{lat=39.848306,lng=-86.126514},
        new Spot{lat=40.0460878,lng=-86.01536899999999},
        new Spot{lat=40.0397109,lng=-86.002647},
        new Spot{lat=39.852091,lng=-86.15803319999999},
        new Spot{lat=39.8645672,lng=-86.1569552},
        new Spot{lat=40.0085331,lng=-86.1265581},
        new Spot{lat=39.848322,lng=-86.12467},
        new Spot{lat=40.0363209,lng=-85.9922722},
        new Spot{lat=39.8284847,lng=-86.15619149999999},
        new Spot{lat=39.9236069,lng=-86.099177},
        new Spot{lat=39.929378,lng=-86.102729},
        new Spot{lat=39.9242877,lng=-86.1099921}
            };
            spots.ForEach(s => context.Spots.Add(s));
            context.SaveChanges();
        }
    }
}
    