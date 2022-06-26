using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace WpfTelegram.Services
{
    public class ServicesOfJSON
    {
        public static void Write<T>(string path, T content) => File.WriteAllText(path, JsonSerializer.Serialize(content));

        public static T? Read<T>(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            try
            {
                return (T)JsonSerializer.Deserialize(File.ReadAllText(path), typeof(T));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
