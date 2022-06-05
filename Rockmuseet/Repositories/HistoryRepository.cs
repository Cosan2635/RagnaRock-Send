using System;
using System.Collections.Generic;
using Rockmuseet.Helpers;
using Rockmuseet.Interfaces;
using Rockmuseet.models;

namespace Rockmuseet.Repositories
{
    public class HistoryRepository : IHistoryRepository
    {
        string JsonFileName = @"Data/Histories.json";

        public Dictionary<int, History> GetAllHistories()
        {
            Console.WriteLine(JsonFileName);
            return JsonFileReader.ReadJsonHistory(JsonFileName);
        }


        public void DeleteHistory(History history)
        {
            Dictionary<int, History> histories = JsonFileReader.ReadJsonHistory(JsonFileName);
            histories.Remove(history.Id);
            JsonFileWritter.WriteToJson(histories, JsonFileName);
        }

        public void AddHistory(History history)
        {
            Dictionary<int, History> histories = JsonFileReader.ReadJsonHistory(JsonFileName);
            histories.Add(history.Id, history);
            JsonFileWritter.WriteToJson(histories, JsonFileName);
        }

        public History GetHistory(int Id)
        {
            Dictionary<int, History> histories = JsonFileReader.ReadJsonHistory(JsonFileName);

            return histories[Id];
        }

        public void UpdateHistory(History history)
        {
            Dictionary<int, History> histories = JsonFileReader.ReadJsonHistory(JsonFileName);

            if (history != null)
            {
                histories[history.Id] = history;
            }
            JsonFileWritter.WriteToJson(histories, JsonFileName);
        }
    }
}
