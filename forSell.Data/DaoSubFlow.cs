using System;
using System.Collections.Generic;
using forSell.entity;
using forSell.Data;


namespace forSell.Data
{
    public class DaoSubFlow
    {
        public static List<SubFlow> all()
        {
            return Conextion<SubFlow>.getDataFromFile("setting/sub-flows.json");
        }
    }
}
