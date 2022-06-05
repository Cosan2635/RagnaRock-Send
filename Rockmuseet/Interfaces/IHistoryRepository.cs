using System;
using System.Collections.Generic;
using Rockmuseet.models;

namespace Rockmuseet.Interfaces
{
        public interface IHistoryRepository
        {
        Dictionary<int, History> GetAllHistories();
        History GetHistory(int Id);
        void AddHistory(History history);
        void DeleteHistory(History history);
        void UpdateHistory(History history);
        }
}
