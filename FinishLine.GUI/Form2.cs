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
            SetRowsToDatagrid();
            PopulateDataGrid();
            InitCountrycmbx();
            InitSex();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SetRowsToDatagrid()
        {
            dtGrdRegisteredRunnersVw.Columns.Add("Key", "NUMBER");
            dtGrdRegisteredRunnersVw.Columns.Add("Name", "NAME");
            dtGrdRegisteredRunnersVw.Columns.Add("StateOfOrigin", "STATE");
            dtGrdRegisteredRunnersVw.Columns.Add("Age", "AGE");
            dtGrdRegisteredRunnersVw.Columns.Add("Sex", "SEX");
        }

        private void PopulateDataGrid()
        {
            foreach (var runner in _runnerManager.GetDictionaryOFRunners())
            {
                dtGrdRegisteredRunnersVw.Rows.Add(_runnerManager.KeyValueToString(runner.Key),
                    runner.Value.Name,
                    _stateManager.GetStateBykey(runner.Value.StateOfOrigin).SlovakShortName,
                    runner.Value.Age,
                    runner.Value.Sex);
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

        private void bttn_AddRunnerWithGeneratedId_Click(object sender, EventArgs e)
        {
            if (!txtBxRunnerNameAdd.Text.Equals(string.Empty) &&
                cmbBxSexAdd.SelectedValue.ToString() != Gender.Unknown.ToString() &&
                (int)cmbBxCountryAdd.SelectedValue != 0)
            {
                _runnerManager.AddRunnerToList(new Runner(
                    txtBxRunnerNameAdd.Text,
                    (int)cmbBxCountryAdd.SelectedValue,
                    (int)nmrcUpDwnAgeAdd.Value,
                    (Gender)Enum.Parse(typeof(Gender), cmbBxSexAdd.SelectedValue.ToString()
                    )));

                dtGrdRegisteredRunnersVw.Rows.Clear();
                PopulateDataGrid();
            }
            else
            {
                MessageBox.Show("Please select a value");
                return;
            }
        }

        private void cmbBxCountryAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
