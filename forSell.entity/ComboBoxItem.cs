using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forSell.entity
{
    public class ComboBoxItem<T>
    {
        public ComboBoxItem(string label, T value, string Key) {
            this.label = label;
            this.value = value;
            this.Key = Key;
        }
        public string label { get; set; }
        public T value { get; set; }

        public string Key { get; set; }
    }
}
