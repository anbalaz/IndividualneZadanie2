using FinishLine.Core.Model;
using System.Collections.Generic;

namespace FinishLine.Core.Repository
{
    public interface IRunnerRepository
    {
        Dictionary<int, Runner> GetDictionaryOFRunners();
    }
}
