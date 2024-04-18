using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadEx
{
    public class Hleb
    {
        public int CostForVes(int ves,string vid)
        {
            int cost;
            cost = ves * 36;
            if (vid == "Ржаной")
                cost =cost + 42;
            else if (vid == "Белый")
                cost = cost + 53;
            else
                cost = cost + 101;

            return cost;
        }
    }
}
