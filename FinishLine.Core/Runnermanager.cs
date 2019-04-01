using FinishLine.Core.Model;
using FinishLine.Core.Repository;
using System.Collections.Generic;
using System.Linq;

namespace FinishLine.Core
{
    public class RunnerManager
    {
        private IFileRepository _runnerRepository;
        private readonly Dictionary<int, Runner> _runnersDirectory;
        private static int _keyId = 0;
        private const int KEY_MINIMUM_VALUE = 1;
        private const int KEY_MAXIMUM_VALUE = 999;


        public RunnerManager(IFileRepository runnerRepository)
        {
            _runnerRepository = runnerRepository;
            _runnersDirectory = runnerRepository.GetDictionaryOFRunners();
        }

        public Dictionary<int, Runner> GetDictionaryOFRunners()
        {
            return _runnersDirectory;
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

        public bool IsKeyIdFree(int keyId)
        {
            bool ret = false;
            if (!_runnersDirectory.ContainsKey(keyId) && keyId >= KEY_MINIMUM_VALUE && keyId <= KEY_MAXIMUM_VALUE)
            {
                ret = true;
            }
            return ret;
        }

        public string KeyValueToString(int key)
        {
            return key.ToString("000");
        }


    }
}