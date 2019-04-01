using FinishLine.Core;
using FinishLine.Core.Model;
using System;
using System.Windows.Forms;

namespace FinishLine
{
    public partial class RunnersForm : Form
    {
        private RunnerManager _runnerManager;
        private StateManager _stateManager;

        public RunnersForm(RunnerManager runnerManager, StateManager stateManager)
        {
            InitializeComponent();

            _runnerManager = runnerManager;
            _stateManager = stateManager;
            SetRowsToDatagrid();
            PopulateDataGrid();
            InitCountrycmbx();
            InitSex();
            EditbuttonsAvailable(false);
        }

        private void SetRowsToDatagrid()
        {
            dtGrdRegisteredRunnersVw.Columns.Add("Key", "NUMBER");
            dtGrdRegisteredRunnersVw.Columns.Add("Name", "NAME");
            dtGrdRegisteredRunnersVw.Columns.Add("StateOfOrigin", "STATE");
            dtGrdRegisteredRunnersVw.Columns.Add("Age", "AGE");
            dtGrdRegisteredRunnersVw.Columns.Add("Sex", "SEX");
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
                MessageBox.Show("Please check if you selected all values");
                return;
            }
        }

        private void bttnAddRunnerWithCustomId_Click(object sender, EventArgs e)
        {
            if (!txtBxRunnerNameAdd.Text.Equals(string.Empty) &&
                cmbBxSexAdd.SelectedValue.ToString() != Gender.Unknown.ToString() &&
                (int)cmbBxCountryAdd.SelectedValue != 0)
            {

                if (_runnerManager.IsKeyIdFree((int)nmrcUpDwnNumberAdd.Value))
                {
                    _runnerManager.AddRunnerToList((int)nmrcUpDwnNumberAdd.Value, new Runner(
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
                    MessageBox.Show("The Number is already in use");
                }

            }
            else
            {
                MessageBox.Show("Please check if you selected all values");
            }
        }

        private void bttnOkNumberEdit_Click(object sender, EventArgs e)
        {
            if (!_runnerManager.IsKeyIdFree((int)nmrcUpDwnPickNumberToEdit.Value))
            {
                EditbuttonsAvailable(true);
                bttnOkNumberEdit.Enabled = false;
                nmrcUpDwnPickNumberToEdit.Enabled = false;
            }
            else
            {
                MessageBox.Show("There is no such runner with that number");
            }
        }

        private void EditbuttonsAvailable(bool areTheyAvailable)
        {
            txtBxRunnerNameEdit.Enabled = areTheyAvailable;
            cmbBxCountryEdit.Enabled = areTheyAvailable;
            nmrcUpDwnAgeEdit.Enabled = areTheyAvailable;
            cmbBxSexEdit.Enabled = areTheyAvailable;
            bttnOkRunnerEdit.Enabled = areTheyAvailable;
        }

        private void bttnOkRunnerEdit_Click(object sender, EventArgs e)
        {
            if (!txtBxRunnerNameEdit.Text.Equals(string.Empty) &&
               cmbBxSexEdit.SelectedValue.ToString() != Gender.Unknown.ToString() &&
               (int)cmbBxCountryEdit.SelectedValue != 0)
            {

                _runnerManager.GetDictionaryOFRunners()[(int)nmrcUpDwnPickNumberToEdit.Value] = new Runner(txtBxRunnerNameEdit.Text,
                    (int)cmbBxCountryEdit.SelectedValue,
                    (int)nmrcUpDwnAgeEdit.Value,
                    (Gender)Enum.Parse(typeof(Gender), cmbBxSexEdit.SelectedValue.ToString()));

                dtGrdRegisteredRunnersVw.Rows.Clear();
                PopulateDataGrid();
                EditbuttonsAvailable(false);
                bttnOkNumberEdit.Enabled = true;
                nmrcUpDwnPickNumberToEdit.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please check if you selected all values");
            }
        }

        private void bttnOkRunnerDelete_Click(object sender, EventArgs e)
        {
            if (!_runnerManager.IsKeyIdFree((int)nmrcUpDwnNumberDelete.Value))
            {
                string message = "Do you want to delete this runner?";
                string title = "Delete Runner";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    _runnerManager.RemoveRunnerFromDirectory((int)nmrcUpDwnNumberDelete.Value);
                    dtGrdRegisteredRunnersVw.Rows.Clear();
                    PopulateDataGrid();
                }
            }
            else
            {
                MessageBox.Show("There is no such runner with that number");
            }
        }

        private void bttnContinue_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}