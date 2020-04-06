using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Windows.Forms;
using Test.Logic;
using Test.Logic.Subtitles;

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
            var dialog = CreateDialog();
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txtBoxMoviesPath.Text = dialog.FileName;
            }
        }

        private void btnDownloadSubtitles_Click(object sender, EventArgs e)
        {
            MovieSubtitlesCore subtitlesProvider = new MovieSubtitlesCore();
            var movies = FileExtractor.GetAllContent(Properties.Settings.Default.MovieDirectory).GetMovies();
            subtitlesProvider.DownloadSubtitles(movies, SubtitleLanguage.bul).ContinueWith( r => {

                if (r.Result.Count > 0)
                {
                    var message = "Неизтеглени субтитри за:";
                    foreach (var movieTitle in r.Result)
                    {
                        message += Environment.NewLine + movieTitle;
                    }
                    MessageBox.Show(message);
                }
            });
        }
    
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = CreateDialog();
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                Properties.Settings.Default.MovieDirectory = dialog.FileName;
                lblVideoDirectory.Text = dialog.FileName;
            }
        }

        private CommonOpenFileDialog CreateDialog()
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            var movieDir = @"D:\movies";
            dialog.AddPlace(movieDir, Microsoft.WindowsAPICodePack.Shell.FileDialogAddPlaceLocation.Top);
            dialog.IsFolderPicker = true;

            return dialog;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            lblVideoDirectory.Text = $"Видео директория: {Properties.Settings.Default.MovieDirectory}";
        }
    }
}
