using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadEx
{
    public class Zakaz
    {
        public static int allcost = 0;
        public string OrderForBusket(int ves, string vid, int cost)
        {
            string order;
            order = $"Хлеб {vid}, количество: {ves} кг, цена: {cost}";
            allcost += cost;
            return order;
        }
    }
}
