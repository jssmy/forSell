using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using forSell.entity;
namespace forSell.business
{
    public class BSSettingColor
    {
      public static  List<SettingColor> all()
        {
            return new List<SettingColor>()
            {
                new SettingColor("primary","#019DF4","#FFFFFF"),
                new SettingColor("secondary-2","#0B2739","#FFFFFF"),
                new SettingColor("highlight-1","#5CB615","#FFFFFF"),
                new SettingColor("highlight-2","#A13EA1","#FFFFFF"),
                new SettingColor("highlight-3","#E63780","#FFFFFF"),
                new SettingColor("highlight-4","#EC624B","#FFFFFF"),
            };
        }
    }
}
