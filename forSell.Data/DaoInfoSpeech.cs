using forSell.entity;
using System.Collections.Generic;
using System.IO;


namespace forSell.Data
{
    public class DaoInfoSpeech
    {
        public static string fileName = "infoSpeech";

        public static List<entity.InfoSpeech> all()
        {
            return Conextion<InfoSpeech>.getDataFromFiles(DaoInfoSpeech.fileName);
        }
    }
}
