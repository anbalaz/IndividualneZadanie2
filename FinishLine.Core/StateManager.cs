using FinishLine.Core.Model;
using FinishLine.Core.Repository;
using System.Collections.Generic;
using System.Linq;

namespace FinishLine.Core
{
    public class StateManager
    {
        private IStateRepository _stateRepository;
        private Dictionary<int, State> _stateDictionary;

        public StateManager(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
            _stateDictionary = stateRepository.GetDictionaryOFStates();
        }

        public Dictionary<int, State> GetDictionaryOFStates()
        {
            return _stateDictionary;
        }

        public State GetStateBykey(int key)
        {
            return _stateDictionary[key];
        }
       
    }
}
