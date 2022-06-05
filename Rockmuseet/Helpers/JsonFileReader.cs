using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;
using Rockmuseet.models;

namespace Rockmuseet.Helpers
{
    public class JsonFileReader
    {
            public static Dictionary<int, History> ReadJsonHistory(string JsonFileName)
            {
            string jsonString = File.ReadAllText(JsonFileName);
            return JsonConvert.DeserializeObject<Dictionary<int, History>>(jsonString);
        }
        }
}
