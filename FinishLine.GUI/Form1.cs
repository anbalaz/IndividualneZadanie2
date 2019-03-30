using FinishLine.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinishLine
{
    public partial class Form1 : Form
    {
        private RunnerManager _runnerManager;
        private StateManager _stateManager;

        public Form1(RunnerManager runnerManager, StateManager stateManager)
        {
            _runnerManager = runnerManager;
            InitializeComponent();
            _stateManager = stateManager;
        }

        private void addRunnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(_runnerManager, _stateManager);
            form.Show();
        }
    }
}
