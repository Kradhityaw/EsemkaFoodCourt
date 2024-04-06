using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsemkaFoodCourt
{
    internal class Session
    {
        public static EsemkaFoodcourtEntities db = new EsemkaFoodcourtEntities();
        public static int UserID;
        public static int TableID = 1;
        public static DateTime date;
    }
}
