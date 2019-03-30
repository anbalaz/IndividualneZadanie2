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

        public Form1(RunnerManager runnerManager)
        {
            _runnerManager = runnerManager;
            InitializeComponent();
        }

        private void addRunnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(_runnerManager);
            form.Show();
        }
    }
}
