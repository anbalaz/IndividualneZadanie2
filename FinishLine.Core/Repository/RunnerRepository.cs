using FinishLine.Core.Model;
using System.Collections.Generic;

namespace FinishLine.Core.Repository
{
    public class RunnerRepository : IRunnerRepository
    {
        private static Dictionary<int, Runner> runMTFCKR = new Dictionary<int, Runner>();

        private void PopulateDB()
        {
            runMTFCKR.Add(1, new Runner("Martin Brnko", 1, 20, Gender.Man));
            runMTFCKR.Add(2, new Runner("Andrej Balaz", 5, 30, Gender.Man));
            runMTFCKR.Add(3, new Runner("Jozo Buco", 10, 20, Gender.Man));
            runMTFCKR.Add(4, new Runner("Martin Brnko", 2, 25, Gender.Man));
            runMTFCKR.Add(5, new Runner("Jan Paholik", 13, 50, Gender.Man));
            runMTFCKR.Add(6, new Runner("Samuel Marec", 25, 30, Gender.Man));
            runMTFCKR.Add(7, new Runner("Viera Balazka", 100, 28, Gender.Woman));
        }

        public Dictionary<int, Runner> GetListOFRunners()
        {
            return runMTFCKR;
        }
    }
}
