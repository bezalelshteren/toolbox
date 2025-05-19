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
            
            Tools wrench = new Wrench( -1);
            Tools screwdriver = new Screwdriver( 51);  
            Tools Saw = new Saw(2, "Saw", 3);
            Tools Drill = new Drill(1, "Shovel", 4);
            Tools hammer = new Hammer(5, "Hammer", 0);

            Tools[] toolslist = { hammer, wrench, screwdriver, Saw, Drill ,null,null};
            foreach (Tools tool in toolslist) {
                 tool.use();
                 tool.describe();
            }
            Tools hammar1 = new Hammer(5, "uigygi", 96);
            Tools wrench1 = new Wrench( 96);
            toolslist[-1] = hammar1;
            toolslist[-2] = hammar1;
            Screwdriver i = new Screwdriver(56);
        }
    }
}
