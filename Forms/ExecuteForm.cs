using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyInstaLive_GUI
{
    public partial class ExecuteForm : Form
    {
        Process pilProcess;

        public ExecuteForm(string processPath, string processArgs)
        {
            InitializeComponent();
            StartProcess(processPath, processArgs);
        }

        private void StartProcess(string processPath, string processArgs)
        {
            BackgroundWorker waitThread = new BackgroundWorker();
            waitThread.WorkerSupportsCancellation = true;
            waitThread.DoWork += (s, e) =>
            {

                var startInfo = new ProcessStartInfo(processPath)
                {
                    WorkingDirectory = Path.GetDirectoryName(processPath),
                    Arguments = processArgs,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,


            };

                using (pilProcess = new Process())
                {
                    try
                    {
                        pilProcess.StartInfo = startInfo;
                        pilProcess.Start();

                        while (!pilProcess.HasExited)
                        {
                            var output = pilProcess.StandardOutput.ReadLine();
                            ExecutionOutputTextBox.Invoke((Action)delegate
                            {
                                ExecutionOutputTextBox.Text += output + Environment.NewLine;
                            });

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Could not start PyInstaLive process:\n\n{ex.Message}\n\nIn case of a permissions issue try running this program as Administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Invoke((Action)delegate
                        {
                            Close();
                        });
                        
                    }
                }
            };

            waitThread.RunWorkerAsync();

        }

        private void SendCtrlCButtonClicked(object sender, EventArgs e)
        {
            pilProcess.StandardInput.Close();
        }

        private void KillProcessButtonClicked(object sender, EventArgs e)
        {
            pilProcess.Kill();
            KillProcessButton.Enabled = false;
            SendCtrlCButton.Enabled = false;
        }
    }
}
