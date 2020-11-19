using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Building
    {
        public virtual int GetFloors()
        {
            return 0;
        }
    }

    public class House : Building
    {
        public override int GetFloors()
        {
            return 1;
        }
    }

    public class SkyScraper : House
    {
        public override int GetFloors()
        {
            return 30;
        }
    }

    public class OrdinaryHouse : House
    {
        public new int GetFloors()
        {
            return 5;
        }
    }

}

