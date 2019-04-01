using FinishLine.Core;
using FinishLine.Core.Model;
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

        public MainForm(RunnerManager runnerManager, StateManager stateManager, RaceManager raceManager)
        {
            _runnerManager = runnerManager;
            _raceManager = raceManager;
            InitializeComponent();
            _stateManager = stateManager;
            form = new RunnersForm(_runnerManager, _stateManager);
            bttnRunnerAddLap.Enabled = false;
            bttnRunnerSteppingOut.Enabled = false;
            SetRowsToDatagrid();
        }

        private void addRunnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Do you want to save data?";
            var result = MessageBox.Show(message, "Question",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            RunnerSaveDialog loadRunnersDialog = new RunnerSaveDialog();
            var result = loadRunnersDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //loadRunnersDialog.SelectedPath;
            }
        }

        private void SetRowsToDatagrid()
        {
            dtGrdVwMainRaceForm.Columns.Add("Key", "NUMBER");
            dtGrdVwMainRaceForm.Columns.Add("_finishedLapsTime", "Finished lap at time");
            dtGrdVwMainRaceForm.Columns.Add("Sex", "Time Of Lap");
        }

        private void bttnStartTheRace_Click(object sender, EventArgs e)
        {
            if (nmrcUpDwnNumberOfLaps.Value != 0 && nmrcUpDwnLengthOfLap.Value != 0 && nmrcUpDwnNumberOfWinners.Value != 0)
            {
                nmrcUpDwnNumberOfLaps.Enabled = false;
                nmrcUpDwnLengthOfLap.Enabled = false;
                nmrcUpDwnNumberOfWinners.Enabled = false;
                race = new Race((int)nmrcUpDwnNumberOfLaps.Value, (decimal)nmrcUpDwnLengthOfLap.Value, (int)nmrcUpDwnNumberOfWinners.Value);

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

        private void PopulateDataGridStart()
        {
            foreach (var runner in _runnerManager.GetDictionaryOFRunners())
            {
                dtGrdVwMainRaceForm.Rows.Add(_runnerManager.KeyValueToString(runner.Key),
                    runner.Value.GetFinishedLapsTime().Last().ToString()
                   );
            }
        }

        private void bttnRunnerAddLap_Click(object sender, EventArgs e)
        {
            if (!_runnerManager.IsKeyIdFree((int)nmercUpDwnRunnerAddLap.Value)&&
                _runnerManager.GetDictionaryOFRunners()[(int)nmercUpDwnRunnerSteppingOut.Value].IsOutOfRace == false)
            {
                _runnerManager.GetDictionaryOFRunners()[(int)nmercUpDwnRunnerAddLap.Value].AddLapTime(DateTime.Now);
                dtGrdVwMainRaceForm.Rows.Add(_runnerManager.KeyValueToString((int)nmercUpDwnRunnerAddLap.Value),
                    DateTime.Now.ToString(),
                _runnerManager.GetDictionaryOFRunners()[(int)nmercUpDwnRunnerAddLap.Value].CountDifferenceBetweenLaps().ToString()
              );
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
    }
}
