using FinishLine.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core.Repository
{
    public interface IRunnerRepository
    {
        Dictionary<string, Runner> GetListOFRunners();
    }
}
