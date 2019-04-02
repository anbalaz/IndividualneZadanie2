using FinishLine.Core.Model;
using FinishLine.Core.Repository;
using System.Collections.Generic;

namespace FinishLine.Core
{
    public class RaceManager
    {
        private readonly Dictionary<int, Runner> _winningDirectory = new Dictionary<int, Runner>();
        private readonly IFileRepository _runnerRepository;


        public RaceManager(IFileRepository runnerRepository)
        {
            _runnerRepository = runnerRepository;
        }

        /// <summary>
        /// checks if size of winning directory matches the parameter number, returns bool 
        /// </summary>
        public bool IsTheRaceFinished(int maximumFinishers)
        {
            return _winningDirectory.Count >= maximumFinishers;
        }

        /// <summary>
        /// adding runner to winning directory, if he already is  in it, returns bool
        /// </summary>
        public bool IsFinishedRunnerAddedToWinningDirectory(int maximumLaps, int key, Runner runner)
        {
            bool ret = false;

            foreach (var racer in _runnerRepository.GetDictionaryOFRunners())
            {
                if (racer.Value.GetFinishedLapsTimeListCount() >= maximumLaps + 1 && !_winningDirectory.ContainsKey(racer.Key))
                {
                    _winningDirectory.Add(racer.Key, racer.Value);
                    ret = true;
                }
            }
            return ret;
        }

        public Dictionary<int, Runner> GetWinningDirectory()
        {
            return _winningDirectory;
        }
    }
}