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
            IFileRepository fileRepository = new FileRepository();
            RaceManager raceManager = new RaceManager(fileRepository);
            RunnerManager runnerManager = new RunnerManager(fileRepository);

            //file.SaveDataToFile("Halleluja.txt");
            //file.LoadDataFromFile("Halleluja.txt");

            //Console.WriteLine(($"{DateTime.Now.ToString()}{FileRepository.SEPARATOR_LAPS}"));


            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(runnerManager, stateManager, raceManager, fileRepository));
        }
    }
}