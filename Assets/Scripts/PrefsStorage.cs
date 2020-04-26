using System;
using System.Collections.Generic;
using System.Text.Json;

namespace GDSerializer
{
    public class PrefsStorage : IPrefsStorage
    {
        public T Deserealize<T>(string key) where T : class
        {
            string jsonString = this.storage[key];
            return JsonSerializer.Deserialize<T>(jsonString);
        }

        public void Serialize<T>(string key, T obj)
        {
            string jsonString = JsonSerializer.Serialize(obj);
            this.storage.Add(key, jsonString);
        }

        private Dictionary<String, String> storage = new Dictionary<string, string>();
    }
}