using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Windows.Forms;
using Test.Logic;

namespace VideoShortcutCreator.Ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShortcuts_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxMoviesPath.Text))
                MessageBox.Show("Path to movies not provided", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (!chkUseRealName.Checked && string.IsNullOrEmpty(txtBoxName.Text))
                MessageBox.Show("Custom file name not provided", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            var path = txtBoxMoviesPath.Text;
            var name = txtBoxName.Text ?? string.Empty;

            ShortcutOptions ops = new ShortcutOptions()
            {
                Destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                IsSeries = chkIsSeries.Checked,
                Name = name,
                UseRealName = chkUseRealName.Checked
            };

            FileExtractor.GetAllContent(path).GetMovies().Process(ops);
        }

        private void btnGetMoviePath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtBoxMoviesPath.Text = dialog.FileName;
            }
        }
    }
}
