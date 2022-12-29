using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forSell.entity
{
    public class Option
    {

        public string stylebutton { get; set; }
        public string color { get; set; }
        public string value { get; set; }
        public string key { get; set; }
        public List<AdditionalData> validations { get; set; }
    }
}
