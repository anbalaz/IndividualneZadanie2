using FinishLine.Core.Model;
using FinishLine.Core.Repository;
using System.Collections.Generic;
using System.Linq;

namespace FinishLine.Core
{
    public class RunnerManager
    {
        private IRunnerRepository _runnerRepository;
        private Dictionary<int, Runner> _runnersDirectory;
        private static int _keyId = 1;
        private const int KEY_MINIMUM_VALUE = 1;
        private const int KEY_MAXIMUM_VALUE = 999;


        public RunnerManager(IRunnerRepository runnerRepository)
        {
            _runnerRepository = runnerRepository;
            _runnersDirectory = runnerRepository.GetListOFRunners();
            _keyId = _runnersDirectory.Keys.Max();
        }

        public void RemoveRunnerFromDirectory(int key)
        {
            _runnersDirectory.Remove(key);
        }

        public void AddRunnerToList(Runner runner)
        {
            _runnersDirectory.Add(NewKeyId(), runner);
        }

        public void AddRunnerToList(int keyId, Runner runner)
        {
            _runnersDirectory.Add(keyId, runner);
        }

        private int NewKeyId()
        {
            _keyId++;

            if (_keyId > KEY_MAXIMUM_VALUE)
            {
                _keyId = KEY_MINIMUM_VALUE;
            }

            if (!_runnersDirectory.ContainsKey(_keyId))
            {
                return _keyId;
            }
            else
            {
                int count = KEY_MINIMUM_VALUE;
                while (count != KEY_MAXIMUM_VALUE)
                {
                    if (_keyId > KEY_MAXIMUM_VALUE)
                    {
                        _keyId = KEY_MINIMUM_VALUE;
                    }
                    else if (!_runnersDirectory.ContainsKey(_keyId))
                    {
                        return _keyId;
                    }

                    _keyId++;
                    count++;
                }
            }
            return 0;
        }

        public bool IsKeyIdValid(int keyId)
        {
            bool ret = false;
            if (!_runnersDirectory.ContainsKey(keyId) && keyId >= KEY_MINIMUM_VALUE && keyId <= KEY_MAXIMUM_VALUE)
            {
                ret = true;
            }
            return ret;
        }
    }
}