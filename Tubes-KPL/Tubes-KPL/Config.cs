using Newtonsoft.Json;
using System.IO;

namespace Tubes_KPL
{
    class Config
    {
        // Membaca file JSON dari path yang ada di parameter
        // dan me-return data pada file tersebut sesuai dengan tipe generik yang dimasukan.
        public static T ReadFromJson<T>(string path)
        {
            string json = File.ReadAllText(path);
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }

        // Menyimpan file JSON ke lokasi path yang ada di parameter dengan tipe generik yang dimasukan.
        public static void SaveToJson<T>(T obj, string path)
        {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(path, json);
        }
    }
}
