using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

using System.IO;
namespace Biblioteca
{
    public static class Methods
    {
        public static void Serialize(object data, string filePath)
        {
            if ((File.Exists(filePath) && new FileInfo(filePath).Length != 0) || !File.Exists(filePath))
            {
                File.Delete(filePath);
                string output = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(filePath, output);
            }
        }
        public static bool Deserialize<T>(string path, string field, out Dictionary<string, T> dict)
        {
            List<T> list = new List<T>();
            
            if (File.Exists(path))
            {
                var tmp = JsonConvert.DeserializeObject(File.ReadAllText(path));
                string tmp2 = tmp.ToString().Trim();
                if (tmp2.StartsWith("{") && tmp2.EndsWith("}"))
                {
                    dict = JsonConvert.DeserializeObject<Dictionary<string, T>>(File.ReadAllText(path));
                }
                else
                {
                    list = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(path));
                    dict = list.ToDictionary(keySelector: m => (string)typeof(T).GetProperty(field).GetValue(m, null), elementSelector: m => m);
                }
                return true;
            }
            else
            {
                File.WriteAllText(path, String.Empty);
                dict = new Dictionary<string, T>();
                return false;
            }
        }

        public static bool Deserialize<T>(string path, string field, out List<T> list)
        {
            
            if (File.Exists(path))
            {
                if (new FileInfo(path).Length <= 3)
                {
                    list = new List<T>();
                    return false;
                }
                list = null;
                list = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(path));
                
                //Console.WriteLine(list[0].ToString());
                return true;
            } else
            {
                File.WriteAllText(path, String.Empty);
                list = new List<T>();
                return false;
            }
            
        }
    }
}
