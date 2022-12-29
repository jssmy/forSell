using System;
using System.Collections.Generic;
using System.IO;

namespace forSell.Data
{
    public class Conextion<T>
    {
        private static string[] getFiles(string dirString) {
            try
            {
                String dir = Environment.CurrentDirectory.Replace("forSell.presentation\\bin\\Debug", "forSell.data\\" + dirString);
                return System.IO.Directory.GetFiles(dir, "*.json");
            } catch (Exception ex){
                return new string[] { };
            }
        }

        private static string getFile(string dirString) {
            return Environment.CurrentDirectory.Replace("forSell.presentation\\bin\\Debug", "forSell.data\\" + dirString);
        }

        public static List<T> getDataFromFile(string locationFile)
        {
            try
            {
                string file = Conextion<T>.getFile(locationFile);
                List<T> genericList = new List<T>();
                using (StreamReader json = File.OpenText(file))
                {
                    var serializer = new Newtonsoft.Json.JsonSerializer();
                    genericList = (List<T>)serializer.Deserialize(json, typeof(List<T>));
                }
                return genericList;
            }
            catch
            {
                return new List<T>() { };
            }
        }

        public static List<T> getDataFromFiles(string locationFile)
        {
            try
            {
                string[] files = Conextion<T>.getFiles(locationFile);
                List<T> genericList = new List<T>();
                foreach (string file in files)
                {
                    using (StreamReader json = File.OpenText(file))
                    {
                        var serializer = new Newtonsoft.Json.JsonSerializer();
                        List<T> currenGenericList = (List<T>)serializer.Deserialize(json, typeof(List<T>));
                        genericList.AddRange(currenGenericList);
                    }
                }
                
                return genericList;
            }
            catch
            {
                return new List<T>() { };
            }
        }

    }

   
}
