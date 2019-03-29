using FinishLine.Core.Model;
using FinishLine.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class RunnerManager
    {
        private IRunnerRepository _runnerRepository;
        private Dictionary<string, Runner> _runnerList;


        public RunnerManager(IRunnerRepository runnerRepository, Dictionary<string, Runner> runnerList)
        {
            _runnerRepository = runnerRepository;
            _runnerList = runnerList;
        }

        public void PopulateDB()
        {
            _runnerList= _runnerRepository.GetListOFRunners();
        }

        public void RemoveRunnerFromList(string key)
        {
            _runnerList.Remove(key);
        }

        public void AddRunnerToList( Runner runner)
        {
        }
    }
}
