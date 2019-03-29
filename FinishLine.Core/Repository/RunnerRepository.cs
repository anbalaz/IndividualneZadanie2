using FinishLine.Core.Model;
using System.Collections.Generic;

namespace FinishLine.Core.Repository
{
    public class RunnerRepository : IRunnerRepository
    {
        private static Dictionary<string, Runner> runMTFCKR = new Dictionary<string, Runner>();

        private void PopulateDB()
        {
            runMTFCKR.Add("001", new Runner("Martin Brnko", 1, 20, Gender.Man));
            runMTFCKR.Add("002", new Runner("Andrej Balaz", 5, 30, Gender.Man));
            runMTFCKR.Add("003", new Runner("Jozo Buco", 10, 20, Gender.Man));
            runMTFCKR.Add("004", new Runner("Martin Brnko", 2, 25, Gender.Man));
            runMTFCKR.Add("005", new Runner("Jan Paholik", 13, 50, Gender.Man));
            runMTFCKR.Add("006", new Runner("Samuel Marec", 25, 30, Gender.Man));
            runMTFCKR.Add("007", new Runner("Viera Balazka", 100, 28, Gender.Woman));
        }

        public Dictionary<string, Runner> GetListOFRunners()
        {
            return runMTFCKR;
        }
    }
}
