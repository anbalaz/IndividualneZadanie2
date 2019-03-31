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

            //IStateRepository file = new StateRepository();
            //file.GetListOFStates();
            //string number = 5.ToString("000");
            //Debug.WriteLine(number);
            IStateRepository stateRepository = new StateRepository();
            StateManager stateManager = new StateManager(stateRepository);
            IRunnerRepository runnerRepository = new RunnerRepository();
            RunnerManager runnerManager = new RunnerManager(runnerRepository);
            //runnerManager.RemoveRunnerFromDirectory(3);
            //runnerManager.IsKeyIdValid(999);
            //runnerManager.AddRunnerToList(new Runner("Jozino",20,20,Gender.Unknown));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(runnerManager, stateManager));
        }
    }
}
