using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BreadEx
{
    public class Sklad
    {
        public bool Kolvo(int ves,string vid)
        {
            if (vid == "Ржаной")
            {
                if(ves > 2)
                    return false;
                else 
                    return true;
            }
            else if (vid == "Белый")
            {
                if (ves > 4)
                    return false;
                else 
                    return true;
            }
            else 
            {
                if (ves > 3)
                    return false;
                else 
                    return true;
            }

           
        }
    }
}
