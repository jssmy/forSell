using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forSell.entity
{
    public class SettingColor { 
    
        public SettingColor(string name, string backHexaColor, string fontHexaColor) { 
            this.name = name;
            this.backHexaColor = backHexaColor;
            this.fontHexaColor = fontHexaColor;
        }
        public string name { get; set; }
        public string backHexaColor { get; set; }
        public string fontHexaColor { get; set; }
    }
}

