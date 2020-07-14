using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyInstaLive_GUI
{
    public partial class MainForm : Form
    {
        ProgramSettings programSettings;
        PyInstaLiveSettings pyInstaLiveSettings;

        public MainForm()
        {
            InitializeComponent();
            LoadProgramInformation();
        }

        private void LoadProgramInformation()
        {
            programSettings = new ProgramSettings();
            pyInstaLiveSettings = new PyInstaLiveSettings();

            if (File.Exists(programSettings.PyInstaLiveIniLocation))
            {
                pyInstaLiveSettings.LoadConfiguration(programSettings.PyInstaLiveIniLocation);
                UsernameTextBox.Text = pyInstaLiveSettings.Username;
                PasswordTextBox.Text = pyInstaLiveSettings.Password;
                DownloadPathTextBox.Text = pyInstaLiveSettings.DownloadPath;

                DownloadLivestreamsCheckBox.Checked = pyInstaLiveSettings.DownloadLives;
                DownloadReplaysCheckBox.Checked = pyInstaLiveSettings.DownloadReplays;
                DownloadCommentsCheckBox.Checked = pyInstaLiveSettings.DownloadComments;
                ShowCookieExpiryCheckBox.Checked = pyInstaLiveSettings.ShowCookieExpiry;
                LogToFileCheckBox.Checked = pyInstaLiveSettings.LogToFile;
                UseLocksCheckBox.Checked = pyInstaLiveSettings.UseLocks;
                ClearTempFilesCheckBox.Checked = pyInstaLiveSettings.ClearTempFiles;
                DoHeartbeatCheckBox.Checked = pyInstaLiveSettings.DoHeartbeat;
                SkipMergeCheckBox.Checked = pyInstaLiveSettings.SkipMerge;

                FFmpegBinaryPathTextBox.Text = programSettings.FFmpegLocation;
                PyInstaLiveBinaryPathTextBox.Text = programSettings.PyInstaLiveLocation;
                PyInstaliveIniFileTextBox.Text = programSettings.PyInstaLiveIniLocation;

                PyInstaLiveIniTextBox.Text = File.ReadAllText(programSettings.PyInstaLiveIniLocation);
            }
            else
            {
                MessageBox.Show("No PyInstaLive ini file located. No settings have been loaded.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            FinalCommandStringTextBox.Text = BuildCommandString();
        }


        private void FFmpegLocateButtonClicked(object sender, EventArgs e)
        {
            OpenFileDialog locateDialog = new OpenFileDialog();
            locateDialog.Filter = "Executable files (*.exe)|*.exe";
            locateDialog.FilterIndex = 1;
            locateDialog.FileName = "";
            DialogResult locateDialogResult = locateDialog.ShowDialog();
            if (locateDialogResult == DialogResult.OK)
            {
                FFmpegBinaryPathTextBox.Text = locateDialog.FileName;
                programSettings.FFmpegLocation = FFmpegBinaryPathTextBox.Text;
                programSettings.SaveSettings();
            }
            FinalCommandStringTextBox.Text = BuildCommandString();
        }

        private void PyInstaLiveLocateButtonClicked(object sender, EventArgs e)
        {
            OpenFileDialog locateDialog = new OpenFileDialog();
            locateDialog.Filter = "Executable files (*.exe)|*.exe";
            locateDialog.FilterIndex = 1;
            locateDialog.FileName = "";
            DialogResult locateDialogResult = locateDialog.ShowDialog();
            if (locateDialogResult == DialogResult.OK)
            {
                PyInstaLiveBinaryPathTextBox.Text = locateDialog.FileName;
                programSettings.PyInstaLiveLocation = PyInstaLiveBinaryPathTextBox.Text;
                programSettings.SaveSettings();
            }
        }

        private void PyInstaLiveIniLocateButtonClicked(object sender, EventArgs e)
        {
            OpenFileDialog locateDialog = new OpenFileDialog();
            locateDialog.Filter = "INI Configuration files (*.ini)|*.ini";
            locateDialog.FilterIndex = 1;
            locateDialog.FileName = "";
            DialogResult locateDialogResult = locateDialog.ShowDialog();
            if (locateDialogResult == DialogResult.OK)
            {
                PyInstaliveIniFileTextBox.Text = locateDialog.FileName;
                programSettings.PyInstaLiveIniLocation = PyInstaliveIniFileTextBox.Text;
                programSettings.SaveSettings();
            }
        }

        private void DownloadPathSelectButtonClicked(object sender, EventArgs e)
        {
            FolderBrowserDialog selectDialog = new FolderBrowserDialog();
            DialogResult selectDialogResult = selectDialog.ShowDialog();
            if (selectDialogResult == DialogResult.OK)
            {
                DownloadPathTextBox.Text = selectDialog.SelectedPath;
            }
            FinalCommandStringTextBox.Text = BuildCommandString();
        }

        private string BuildCommandString(bool includeBinaryPath = true)
        {
            return $"{ (includeBinaryPath ? Path.GetFileName(PyInstaLiveBinaryPathTextBox.Text) : null) }{ (UsernameTextBox.Text.Length > 0 && PasswordTextBox.Text.Length > 0 ? " --username " + UsernameTextBox.Text : null)}" +
                $"{ (DownloadUserTextBox.Text.Length > 0 ? " --download " + DownloadUserTextBox.Text : null)}" +
                $"{ (UsernameTextBox.Text.Length > 0 && PasswordTextBox.Text.Length > 0 ? " --password " + PasswordTextBox.Text : null)} { (DownloadPathTextBox.Text != pyInstaLiveSettings.OriginalDownloadPath ? " --download-path " + DownloadPathTextBox.Text : null)}" +
                $"{ (!DownloadLivestreamsCheckBox.Checked ? " --no-lives" : null)}{ (!DownloadReplaysCheckBox.Checked ? " --no-replays" : null)}" + //{ (DownloadCommentsCheckBox.Checked ? " --generate-comments" : null)}" +
                $"{ (!DoHeartbeatCheckBox.Checked ? " --no-heartbeat" : null)}{ (SkipMergeCheckBox.Checked ? " --skip-merge" : null)}";
                //$"{ (FFmpegBinaryPathTextBox.Text != pyInstaLiveSettings.OriginalDownloadPath ? "--ffmpeg-path " + FFmpegBinaryPathTextBox.Text : null)}";
        }

        private void CheckBoxesStateChanged(object sender, EventArgs e)
        {
            FinalCommandStringTextBox.Text = BuildCommandString();
        }

        private void TextBoxesTextChanged(object sender, EventArgs e)
        {
            FinalCommandStringTextBox.Text = BuildCommandString();
        }

        private void ExecuteScriptButtonClicked(object sender, EventArgs e)
        {
            //ExecuteForm executeForm = new ExecuteForm(programSettings.PyInstaLiveLocation, BuildCommandString(false));
            //executeForm.ShowDialog();
            Process pilProcess;
            var startInfo = new ProcessStartInfo("cmd.exe")
            {
                WorkingDirectory = Path.GetDirectoryName(programSettings.PyInstaLiveLocation),
                Arguments = $"/K {programSettings.PyInstaLiveLocation} {BuildCommandString(false)}",
            };

            using (pilProcess = new Process())
            {
                try
                {
                    pilProcess.StartInfo = startInfo;
                    pilProcess.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Could not start PyInstaLive process:\n\n{ex.Message}\n\nIn case of a permissions issue try running this program as Administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
