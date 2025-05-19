using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tools hammer = new Hammer(5, "Hammer", 2);
            hammer.describe();
            hammer.use();
            Tools wrench = new Wrench(3, "Wrench", 1);
            wrench.describe();
            wrench.use();
            Tools screwdriver = new Screwdriver(4, "Screwdriver", 1);
            screwdriver.describe();
            screwdriver.use();
            Tools Saw = new Saw(2, "Saw", 3);
            Saw.describe();
            Saw.use();
            Tools Drill = new Drill(1, "Shovel", 4);
            Drill.describe();
            Drill.use();
            Tools
            Tools[] tools = { hammer, wrench, screwdriver };
        }
    }
}
