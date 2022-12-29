using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forSell.entity
{
    public class AdditionalData
    {
        public AdditionalData(string key, string value) {
            this.key = key;
            this.value = value;
        }
        public string key { get; set; }
        public string value { get; set; }
    }
}
