using FinishLine.Core.Model;
using System.Collections.Generic;

namespace FinishLine.Core.Repository
{
    public interface IFileRepository
    {
        Dictionary<int, Runner> GetDictionaryOFRunners();
        Race GetRace();
        void LoadDataFromFile(string localDatabase);
        void SaveDataToFile(string localDatabase);
    }
}
