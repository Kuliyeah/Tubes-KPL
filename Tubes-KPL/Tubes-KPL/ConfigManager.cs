using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL
{
    class ConfigManager
    {
        private String pathDirectory = Environment.CurrentDirectory;
        private String pathJson = @"\cofig.json";

        public InputJasaModel GetConfig()
        {
            InputJasaModel config = null;
            try
            {
                config = ReadFromJson<InputJasaModel>(pathDirectory + pathJson);
            }
            catch (Exception)
            {
                config = new InputJasaModel("UnknownToko", "UnknownJasa", 5000, 1, "Tidak Ada Deskripsi");
                SaveToJson<InputJasaModel>(config, pathDirectory + pathJson);
            }
            return config;
        }

        public static T ReadFromJson<T>(String path)
        {
            String json = File.ReadAllText(path);
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }

        public static void SaveToJson<T>(T obj, String path)
        {
            String json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(path, json);
        }
    }
}
