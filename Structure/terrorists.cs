using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    public class terrorists
    {
        public void terrorMan()
        {

            Dictionary<string, Location> terrorist = new Dictionary<string, Location>();
            terrorist["ali"] = new Location(5, 6);
        }

    }

    public class Location
    {
        public int x { get; set; }

        public int y { get; set; }

        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}


