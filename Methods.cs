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

        public static bool FileIsLocked(string filename)
        {
            bool Locked = false;
            try
            {
                FileStream fs =
                    File.Open(filename, FileMode.OpenOrCreate,
                    FileAccess.ReadWrite, FileShare.None);
                fs.Close();
            }
            catch (IOException)
            {
                Locked = true;
            }
            return Locked;
        }
        public static void Deserialize<T>(string path, string field, ref Dictionary<string, T> dict)
        {
            List<T> list = new List<T>();
            if (!FileIsLocked(path))
            {
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
                }
                else
                {
                    File.WriteAllText(path, String.Empty);
                    dict = new Dictionary<string, T>();
                }
                
            }
            
        }

        public static void Deserialize<T>(string path, string field, ref List<T> list)
        {
            if (!FileIsLocked(path))
            {
                if (File.Exists(path))
                {
                    if (new FileInfo(path).Length <= 3)
                    {
                        list = new List<T>();
                    }
                    list = null;
                    list = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(path));

                    //Console.WriteLine(list[0].ToString());

                }
                else
                {
                    File.WriteAllText(path, String.Empty);
                    list = new List<T>();

                }
            }           
            
        }

        public static void ReloadData<T>(string path, string field, ref Dictionary<string, T> dict)
        {
            dict = null;
            Methods.Deserialize(path, field, ref dict);
        }
        public static void ReloadData<T>(string path, string field, ref List<T> list)
        {
            list = null;
            Methods.Deserialize(path, field, ref list);
        }
    }
}
