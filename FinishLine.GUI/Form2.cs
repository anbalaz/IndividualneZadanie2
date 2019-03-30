using FinishLine.Core;
using FinishLine.Core.Model;
using System;
using System.Windows.Forms;

namespace FinishLine
{
    public partial class Form2 : Form
    {
        private RunnerManager _runnerManager;
        private StateManager _stateManager;

        public Form2(RunnerManager runnerManager, StateManager stateManager)
        {
            InitializeComponent();

            _runnerManager = runnerManager;
            _stateManager = stateManager;
            PopulateDataGrid();
            InitCountrycmbx();
            InitSex();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PopulateDataGrid()
        {
            dtGrdRegisteredRunnersVw.Columns.Add("Key", "NUMBER");
            dtGrdRegisteredRunnersVw.Columns.Add("Name", "NAME");
            dtGrdRegisteredRunnersVw.Columns.Add("StateOfOrigin", "STATE");
            dtGrdRegisteredRunnersVw.Columns.Add("Age", "AGE");
            dtGrdRegisteredRunnersVw.Columns.Add("Sex", "SEX");

            foreach (var runner in _runnerManager._runnersDirectory)
            {
                dtGrdRegisteredRunnersVw.Rows.Add(_runnerManager.KeyValueToString(runner.Key), runner.Value.Name, _stateManager.GetStateBykey(runner.Value.StateOfOrigin).SlovakShortName, runner.Value.Age, runner.Value.Sex);
            }
        }

        private void InitCountrycmbx()
        {
            cmbBxCountryAdd.DataSource = new BindingSource(_stateManager.GetDictionaryOFStates(), null);
            cmbBxCountryAdd.DisplayMember = "Value";
            cmbBxCountryAdd.ValueMember = "Key";

            cmbBxCountryEdit.DataSource = new BindingSource(_stateManager.GetDictionaryOFStates(), null);
            cmbBxCountryEdit.DisplayMember = "Value";
            cmbBxCountryEdit.ValueMember = "Key";
        }

        private void InitSex()
        {
            cmbBxSexAdd.DataSource = Enum.GetValues(typeof(Gender));
            cmbBxSexEdit.DataSource = Enum.GetValues(typeof(Gender));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void com(object sender, EventArgs e)
        {

        }
    }
}
