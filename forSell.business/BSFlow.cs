using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using forSell.entity;
using forSell.Data;

namespace forSell.business
{
    public static class BSFlow
    {
        public static List<Flow> all()
        {
            return DaoFlow.all();
        }
    }
}
