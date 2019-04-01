using FinishLine.Core.Model;
using System.Collections.Generic;

namespace FinishLine.Core.Repository
{

    /// <summary>
    /// Class used mostly for testing, now is obsolete
    /// </summary>
    public class RunnerRepository : IFileRepository
    {
        private static Dictionary<int, Runner> runMTFCKR = new Dictionary<int, Runner>();

        public RunnerRepository()
        {
            PopulateDB();
        }

        private void PopulateDB()
        {
            runMTFCKR.Add(1, new Runner("Martin Brnko", 1, 20, Gender.Man));
            runMTFCKR.Add(2, new Runner("Andrej Balaz", 5, 30, Gender.Man));
            runMTFCKR.Add(3, new Runner("Jozo Buco", 10, 20, Gender.Man));
            runMTFCKR.Add(4, new Runner("Martin Brnko", 2, 25, Gender.Man));
            runMTFCKR.Add(5, new Runner("Jan Paholik", 13, 50, Gender.Man));
            runMTFCKR.Add(6, new Runner("Samuel Marec", 25, 30, Gender.Man));
            runMTFCKR.Add(999, new Runner("Viera Balazka", 100, 28, Gender.Woman));
        }

        public Dictionary<int, Runner> GetDictionaryOFRunners()
        {
            return runMTFCKR;
        }

        public Race GetRace()
        {
            throw new System.NotImplementedException();
        }

        public void LoadDataFromFile(string localDatabase)
        {
            throw new System.NotImplementedException();
        }

        public void SaveDataToFile(string localDatabase)
        {
            throw new System.NotImplementedException();
        }
    }
}