using FinishLine.Core.Model;
using FinishLine.Core.Repository;
using System.Collections.Generic;

namespace FinishLine.Core
{
    public class RaceManager
    {
        private readonly Dictionary<int, Runner> _runnersDirectory;
        private  Dictionary<int, Runner> _runnersWinnersDirectory= new Dictionary<int, Runner>();

        private int _count = 0;

        public RaceManager(IRunnerRepository runnerRepository)
        {
            _runnersDirectory = runnerRepository.GetDictionaryOFRunners();
        }

        public void CheckForWinningRunners(int maximumLaps)
        {
            for (int i = 0; i < _runnersDirectory.Count; i++)
            {
                if (_runnersDirectory[i].GetLapsCount() == maximumLaps)
                {
                    _count++;
                    _runnersWinnersDirectory.Add(i,_runnersDirectory[i]);
                    _runnersDirectory.Remove(i);
                    break;
                }

            }
        }

        public void RemoveRunnerFromRace(int keyRunner)
        {
            _runnersDirectory.Remove(keyRunner);
        }

        public bool IsTheRaceFinished(int maximumFinishers)
        {
            return _count >= maximumFinishers;
        }

        public void CountDifferencebetweenlaps()
        {

        }

    }
}
