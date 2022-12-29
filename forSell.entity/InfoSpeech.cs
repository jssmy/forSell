using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forSell.entity
{
    public class InfoSpeech
    {
        public string[] scenary { get; set; }
        public string[] diagnosisFlow { get; set; }
        public bool enable { get; set; }
        public string type { get; set; }
        public string header { get; set; }
        public string description { get; set; }
        public List<Option> options { get; set; }

        public string scenarys { get => string.Join("|", this.scenary); }
        public string flows { get => string.Join("|", this.diagnosisFlow); }

    }
}
