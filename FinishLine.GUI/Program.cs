using FinishLine.Core;
using FinishLine.Core.Model;
using FinishLine.Core.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinishLine
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            IStateRepository stateRepository = new StateRepository();
            StateManager stateManager = new StateManager(stateRepository);
            IRunnerRepository runnerRepository = new RunnerRepository();
            RaceManager raceManager = new RaceManager(runnerRepository);
            RunnerManager runnerManager = new RunnerManager(runnerRepository);


            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(runnerManager, stateManager,raceManager));
        }
    }
}
