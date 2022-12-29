using System;
using System.Collections.Generic;
using forSell.entity;
using forSell.Data;
namespace forSell.business
{
    public static class BSScenary
    {
        public static List<Scenary> all()
        {
            return DaoScenary.all();
        }
    }
}
