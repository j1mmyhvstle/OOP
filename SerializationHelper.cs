using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Do_an_nhom
{
    internal class SerializationHelper
    {
        public static void Serialize<T>(List<T> list, string filePath)
        {
            try
            {
                string json = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
                Console.WriteLine("Serialization successful.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Serialization failed: {ex.Message}");
            }
        }
        public static void Deserialize<T>(List<T> list, string filePath)
        {
            try
            {
                string newJson = File.ReadAllText(filePath);
                List<T> deserializedList = JsonSerializer.Deserialize<List<T>>(newJson);
                Console.WriteLine("Deserialization successful.");
                foreach (T item in list)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Deserialization failed: {ex.Message}");
            }
        }
    }
}
