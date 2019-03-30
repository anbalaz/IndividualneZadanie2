using FinishLine.Core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FinishLine
{
    public partial class Form2 : Form
    {
        private RunnerManager _runnerManager;

        public Form2(RunnerManager runnerManager)
        {
            InitializeComponent();
            _runnerManager = runnerManager;
            populateDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void populateDataGrid()
        {
            Dictionary<char, double> myList = new Dictionary<char, double>();

            dtGrdRegisteredRunnersVw.Columns.Add("Key", "NUMBER");
            dtGrdRegisteredRunnersVw.Columns.Add("Name", "NAME");
            dtGrdRegisteredRunnersVw.Columns.Add("StateOfOrigin", "STATE");
            dtGrdRegisteredRunnersVw.Columns.Add("Age", "AGE");
            dtGrdRegisteredRunnersVw.Columns.Add("Sex", "SEX");

            foreach (var runner in _runnerManager._runnersDirectory)
            {
                dtGrdRegisteredRunnersVw.Rows.Add(runner.Key, runner.Value.Name, runner.Value.StateOfOrigin, runner.Value.Age, runner.Value.Sex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void com(object sender, EventArgs e)
        {

        }
    }
}
