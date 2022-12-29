using System;
using System.Collections.Generic;
using forSell.entity;
using forSell.Data;

namespace forSell.business
{
    public class BSSubFlow
    {
        public static List<SubFlow> all()
        {
            return DaoSubFlow.all();
        }

        public static List<SubFlow> getAllByParentId(string parentId)
        {
            return DaoSubFlow.all().FindAll(subFlow => subFlow.parent_id.Equals(parentId));
        }
    }
}
