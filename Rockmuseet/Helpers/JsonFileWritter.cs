using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Rockmuseet.models;

namespace Rockmuseet.Helpers
{
    public class JsonFileWritter
    {
        public static void WriteToJson(Dictionary<int, History> pizzas, string JsonFileName)
        {
            string output = JsonConvert.SerializeObject(pizzas, Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }
    }
}
