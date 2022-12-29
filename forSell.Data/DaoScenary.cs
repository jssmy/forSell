using forSell.entity;
using System.Collections.Generic;

namespace forSell.Data
{
    public class DaoScenary
    {
        public static List<Scenary> all()
        {
            return Conextion<Scenary>.getDataFromFile("setting/scenary.json");
        }
    }
}
