using System;
using System.Collections.Generic;
using forSell.entity;
using forSell.Data;
namespace forSell.Data
{
    public static class DaoFlow
    {
        public static List<Flow> all()
        {
            return Conextion<Flow>.getDataFromFile("setting/main-flows.json");
        }
    }
}
