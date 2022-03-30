using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

using System.IO;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Methods
    {
        public static bool Serialize(object data, string filePath)
        {
            if (FileIsLocked(filePath))
            {
                Serialize(data, filePath);
            } 
            
                if ((File.Exists(filePath) && new FileInfo(filePath).Length != 0) || !File.Exists(filePath))
                {
                    File.Delete(filePath);
                    string output = JsonConvert.SerializeObject(data, Formatting.Indented);
                    File.WriteAllText(filePath, output);
                }
                return true;
            
            
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
        //public static bool Deserialize<T>(string path, string field, Dictionary<string, T> dict)
        //{


        //    List<T> list = new List<T>();
        //    if (File.Exists(path))
        //    {
        //        var tmp = JsonConvert.DeserializeObject(File.ReadAllText(path));
        //        string tmp2 = tmp.ToString().Trim();
        //        if (tmp2.StartsWith("{") && tmp2.EndsWith("}"))
        //        {
        //            dict = JsonConvert.DeserializeObject<Dictionary<string, T>>(File.ReadAllText(path));
        //        }
        //        else
        //        {
        //            list = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(path));
        //            dict = list.ToDictionary(keySelector: m => (string)typeof(T).GetProperty(field).GetValue(m, null), elementSelector: m => m);
        //            Serialize(dict, path);
        //        }
        //    }
        //    else
        //    {
        //        File.WriteAllText(path, String.Empty);
        //        dict = new Dictionary<string, T>();
        //    }
        //    return dict;


        //}

        //public static async Task<List<T>> Deserialize<T>(string path, string field, List<T> list)
        //{
        //    tsc = new TaskCompletionSource<bool>();
        //    FileIsLocked(path);
        //    await tsc.Task;

        //    if (File.Exists(path))
        //    {
        //        if (new FileInfo(path).Length <= 3)
        //        {
        //            list = new List<T>();
        //        } else
        //        {
        //            list = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(path));
        //        }
        //    }
        //    else
        //    {
        //        File.WriteAllText(path, String.Empty);
        //        list = new List<T>();

        //    }
        //    return list;


        //}
        public static bool Deserialize<T>(string path, string field, ref Dictionary<string, T> dict)
        {
            if (FileIsLocked(path))
            {
                Deserialize(path, field, ref dict);
            }


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
                        Serialize(dict, path);
                    }
                }
                else
                {
                    File.WriteAllText(path, String.Empty);
                    dict = new Dictionary<string, T>();
                }
                return true;
            

        }

        public static bool Deserialize<T>(string path, string field, ref List<T> list)
        {
            if (FileIsLocked(path))
            {
                Deserialize(path, field, ref list);
            }
                        
            if (File.Exists(path))
            {
                if (new FileInfo(path).Length <= 3)
                {
                    list = new List<T>();
                }
                else
                {
                    list = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(path));
                }
                //Console.WriteLine(list[0].ToString());

            }
            else
            {
                File.WriteAllText(path, String.Empty);
                list = new List<T>();

            }
            return true;
            

        }
        //public async static void ReloadData<T>(string path, string field, Dictionary<string, T> dict)
        //{
        //    await Methods.Deserialize(path, field, dict);
        //}
        //public async static void ReloadData<T>(string path, string field, List<T> list)
        //{
        //    await Methods.Deserialize(path, field, list);

        //}
        public static bool ReloadData<T>(string path, string field, ref Dictionary<string, T> dict)
        {
            return Methods.Deserialize(path, field, ref dict);
        }
        public static bool ReloadData<T>(string path, string field, ref List<T> list)
        {
            return Methods.Deserialize(path, field, ref list);
        }
    }
}
