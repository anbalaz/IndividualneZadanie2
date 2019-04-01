using FinishLine.Core.Model;
using FinishLine.Core.Repository;
using System.Collections.Generic;

namespace FinishLine.Core
{
    public class RaceManager
    {
        private readonly Dictionary<int, Runner> _winningDirectory=new Dictionary<int, Runner>();
        private readonly IRunnerRepository _runnerRepository;

        public RaceManager(IRunnerRepository runnerRepository)
        {
            _runnerRepository = runnerRepository;
        }

        public bool IsTheRaceFinished(int maximumFinishers)
        {
            return _winningDirectory.Count >= maximumFinishers;
        }

        public void AddRunnerToWinningDirectory(int key, Runner runner)
        {
            if (!_winningDirectory.ContainsKey(key))
            {
                _winningDirectory.Add(key, runner);
            }
        }

        public void AddFinishedRunnerToWinningDirectory(int maximumLaps)
        {
            foreach (var runner in _runnerRepository.GetDictionaryOFRunners())
            {
                if (runner.Value.GetLapsCount() >= maximumLaps)
                {
                    AddRunnerToWinningDirectory(runner.Key, runner.Value);
                }
            }
        }

        public Dictionary<int, Runner> GetWinningDirectory()
        {
            return _winningDirectory;
        }
    }
}