using forSell.Data;
using forSell.entity;
using System;
using System.Collections.Generic;

namespace forSell.business
{
    public class BSpeechInfo
    {

        public List<InfoSpeech> all() {  
            return DaoInfoSpeech.all();
        }

    }
}
