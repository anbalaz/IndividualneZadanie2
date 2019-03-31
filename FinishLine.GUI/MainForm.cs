using FinishLine.Core;
using System;
using System.Windows.Forms;

namespace FinishLine
{
    public partial class MainForm : Form
    {
        private RunnerManager _runnerManager;
        private StateManager _stateManager;
        private RunnersForm form;

        public MainForm(RunnerManager runnerManager, StateManager stateManager)
        {
            _runnerManager = runnerManager;
            InitializeComponent();
            _stateManager = stateManager;
            form = new RunnersForm(_runnerManager, _stateManager);

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
    }
}
