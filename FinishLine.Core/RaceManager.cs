using FinishLine.Core.Model;
using FinishLine.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinishLine.Core
{
    public class RaceManager
    {
        private readonly Dictionary<int, Runner> _runnersDirectory;

        public RaceManager(IRunnerRepository runnerRepository)
        {
            _runnersDirectory = runnerRepository.GetDictionaryOFRunners();
        }

        public bool IsTheRaceFinished(int maximumLaps, int maximumFinishers)
        {
            int count = 0;
            for (int i = 0; i < _runnersDirectory.Count; i++)
            {
                if (_runnersDirectory[i].GetLapsCount() == maximumLaps)
                {
                    count++;
                }
            }
            return count >= maximumFinishers;
        }

        public void RemoveRunnerFromRace(int keyRunner)
        {
            _runnersDirectory.Remove(keyRunner);
        }

    }
}
