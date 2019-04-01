using FinishLine.Core;
using FinishLine.Core.Model;
using FinishLine.Core.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinishLine
{
    public partial class MainForm : Form
    {
        private RaceManager _raceManager;
        private RunnerManager _runnerManager;
        private StateManager _stateManager;
        private RunnersForm form;
        private Race race;
        private IFileRepository _fileRepository;

        public MainForm(RunnerManager runnerManager, StateManager stateManager, RaceManager raceManager, IFileRepository fileRepository)
        {
            InitializeComponent();

            _runnerManager = runnerManager;
            _raceManager = raceManager;
            _fileRepository = fileRepository;
            _stateManager = stateManager;
            bttnRunnerAddLap.Enabled = false;
            bttnRunnerSteppingOut.Enabled = false;
            SetRowsToDatagrid();
            SetRowsToDtGrdVwFinishedRunners();
            form = new RunnersForm(_runnerManager, _stateManager);
        }

        private void SetRowsToDatagrid()
        {
            dtGrdVwMainRaceForm.Columns.Add("Key", "NUMBER");
            dtGrdVwMainRaceForm.Columns.Add("_finishedLapsTime", "Finished lap at time");
            dtGrdVwMainRaceForm.Columns.Add("Sex", "Time Of Lap");
        }

        private void SetRowsToDtGrdVwFinishedRunners()
        {
            dtGrdVwFinishedRunners.Columns.Add("Key", "NUMBER");
            dtGrdVwFinishedRunners.Columns.Add("_finishedLapsTime", "Finished lap at time");
            dtGrdVwFinishedRunners.Columns.Add("TotalTime", "Total time");
        }

        private void PopulateDataGridStart()
        {
            foreach (var runner in _runnerManager.GetDictionaryOFRunners())
            {
                dtGrdVwMainRaceForm.Rows.Add(_runnerManager.KeyValueToString(runner.Key),
                    runner.Value.GetFinishedLapsTime().Last().ToString()
                   );
            }
        }

        private void PopulateDtGrdVwFinishedRunners()
        {
            foreach (var runner in _raceManager.GetWinningDirectory())
            {
                dtGrdVwFinishedRunners.Rows.Add(_runnerManager.KeyValueToString(runner.Key),
                    runner.Value.GetFinishedLapsTime().Last().ToString(), runner.Value.CountTimeTotal().ToString());
            }
            if (_raceManager.IsTheRaceFinished(race.NumberOfWinners))
            {
                MessageBox.Show("The race has ended");
                bttnRunnerAddLap.Enabled = false;
                bttnRunnerSteppingOut.Enabled = false;
            }
        }

        private void SaveFile()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string strfilename = saveFileDialog.InitialDirectory + saveFileDialog.FileName;
                try
                {
                    _fileRepository.SaveDataToFile(strfilename);
                }
                catch (Exception e)
                {

                    MessageBox.Show("Could not save the file " + e.Message);
                } 

            }
        }

        private void LoadFile()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string strfilename = openFileDialog.InitialDirectory + openFileDialog.FileName;
                try
                {
                    _fileRepository.LoadDataFromFile(strfilename);
                    _runnerManager = new RunnerManager(_fileRepository);
                    _raceManager = new RaceManager(_fileRepository);
                    race = _fileRepository.GetRace();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not open the file "+e.Message);
                }
            }
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Do you want to save data?";
            var result = MessageBox.Show(message, "Question",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SaveFile();
            }

        }

        private void addRunnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.ShowDialog();
        }

        private void bttnStartTheRace_Click(object sender, EventArgs e)
        {
            if (nmrcUpDwnNumberOfLaps.Value != 0 && nmrcUpDwnLengthOfLap.Value != 0 && nmrcUpDwnNumberOfWinners.Value != 0)
            {
                nmrcUpDwnNumberOfLaps.Enabled = false;
                nmrcUpDwnLengthOfLap.Enabled = false;
                nmrcUpDwnNumberOfWinners.Enabled = false;
                race = new Race((int)nmrcUpDwnNumberOfLaps.Value, nmrcUpDwnLengthOfLap.Value, (int)nmrcUpDwnNumberOfWinners.Value);

                lblRaceStartTime.Text = DateTime.Now.ToString();
                bttnStartTheRace.Enabled = false;
                bttnRunnerAddLap.Enabled = true;
                bttnRunnerSteppingOut.Enabled = true;
                RunnerToolStripMenuItem.Enabled = false;

                foreach (var runner in _runnerManager.GetDictionaryOFRunners())
                {
                    runner.Value.AddLapTime(DateTime.Now);
                }
                PopulateDataGridStart();
            }
            else
            {
                MessageBox.Show("Please check if you selected all values");
            }
        }

        private void bttnRunnerAddLap_Click(object sender, EventArgs e)
        {
            if (!_runnerManager.IsKeyIdFree((int)nmercUpDwnRunnerAddLap.Value) &&
                _runnerManager.GetDictionaryOFRunners()[(int)nmercUpDwnRunnerAddLap.Value].IsOutOfRace == false)
            {
                _runnerManager.GetDictionaryOFRunners()[(int)nmercUpDwnRunnerAddLap.Value].AddLapTime(DateTime.Now);
                dtGrdVwMainRaceForm.Rows.Add(_runnerManager.KeyValueToString((int)nmercUpDwnRunnerAddLap.Value),
                    DateTime.Now.ToString(),
                _runnerManager.GetDictionaryOFRunners()[(int)nmercUpDwnRunnerAddLap.Value].CountDifferenceBetweenLaps().ToString());


                if (_raceManager.IsFinishedRunnerAddedToWinningDirectory(race.NumberofLaps,
                    (int)nmercUpDwnRunnerAddLap.Value,
                    _runnerManager.GetDictionaryOFRunners()[(int)nmercUpDwnRunnerAddLap.Value]))
                {
                    _runnerManager.GetDictionaryOFRunners()[(int)nmercUpDwnRunnerAddLap.Value].IsOutOfRace = true;
                    dtGrdVwFinishedRunners.Rows.Clear();
                    PopulateDtGrdVwFinishedRunners();
                }
            }
            else
            {
                MessageBox.Show("There is no racer running with selected number");
            }
        }

        private void bttnRunnerSteppingOut_Click(object sender, EventArgs e)
        {
            if (!_runnerManager.IsKeyIdFree((int)nmercUpDwnRunnerAddLap.Value))
            {
                _runnerManager.GetDictionaryOFRunners()[(int)nmercUpDwnRunnerSteppingOut.Value].IsOutOfRace = true;
            }
            else
            {
                MessageBox.Show("There is no racer running with selected number");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
    }
}
