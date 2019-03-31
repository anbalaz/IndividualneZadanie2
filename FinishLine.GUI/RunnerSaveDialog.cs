using System;
using System.Windows.Forms;

namespace FinishLine
{
    public partial class RunnerSaveDialog : Form
    {

        public String SelectedPath
        {
            get
            {
                return txtPath.Text;
            }
        }

        public RunnerSaveDialog()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //var result = saveFileDialog.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //}


            var result = this.folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.txtPath.Text = this.folderBrowserDialog.SelectedPath;
            }
        }


        //private void btnOk_Click(object sender, EventArgs e)
        //{
        //    this.DialogResult = DialogResult.OK;
        //    this.Close();
        //}
    }
}
