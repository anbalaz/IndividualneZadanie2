using FinishLine.Core.Model;
using System.Collections.Generic;

namespace FinishLine.Core.Repository
{
    public interface IStateRepository
    {
        Dictionary<int, State> GetListOFStates();
    }
}
