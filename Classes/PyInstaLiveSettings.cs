using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser.Model;
using IniParser.Model.Configuration;
using IniParser.Parser;

namespace PyInstaLive_GUI
{
    public sealed class PyInstaLiveSettings
    {
        IniDataParser iniDataParser;
        private static PyInstaLiveSettings instance = null;
        private static readonly object padlock = new object();


        private string _username;
        private string _password;
        private string _downloadPath;
        private string _originalDownloadPath;
        private bool _downloadLives;
        private bool _downloadReplays;
        private bool _downloadComments;
        private bool _showCookieExpiry;
        private bool _logToFile;
        private string _ffmpegPath;
        private string _runAtStart;
        private string _runAtFinish;
        private bool _useLocks;
        private bool _clearTempFiles;
        private bool _doHeartbeat;
        private string _proxy;
        private bool _skipMerge;

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string DownloadPath { get => _downloadPath; set => _downloadPath = value; }
        public string OriginalDownloadPath { get => _originalDownloadPath; set => _originalDownloadPath = value; }
        public bool DownloadLives { get => _downloadLives; set => _downloadLives = value; }
        public bool DownloadReplays { get => _downloadReplays; set => _downloadReplays = value; }
        public bool DownloadComments { get => _downloadComments; set => _downloadComments = value; }
        public bool ShowCookieExpiry { get => _showCookieExpiry; set => _showCookieExpiry = value; }
        public bool LogToFile { get => _logToFile; set => _logToFile = value; }
        public string FfmpegPath { get => _ffmpegPath; set => _ffmpegPath = value; }
        public string RunAtStart { get => _runAtStart; set => _runAtStart = value; }
        public string RunAtFinish { get => _runAtFinish; set => _runAtFinish = value; }
        public bool UseLocks { get => _useLocks; set => _useLocks = value; }
        public bool ClearTempFiles { get => _clearTempFiles; set => _clearTempFiles = value; }
        public bool DoHeartbeat { get => _doHeartbeat; set => _doHeartbeat = value; }
        public string Proxy { get => _proxy; set => _proxy = value; }
        public bool SkipMerge { get => _skipMerge; set => _skipMerge = value; }




        public static PyInstaLiveSettings Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new PyInstaLiveSettings();
                    }
                    return instance;
                }
            }
        }

        public PyInstaLiveSettings()
        {
            IniParserConfiguration configuration = new IniParserConfiguration();
            configuration.SkipInvalidLines = true;
            configuration.CaseInsensitive = false;
            iniDataParser = new IniDataParser(configuration);
        }

        public void LoadConfiguration(string iniPath)
        {
            try
            {
                IniData iniConfig = iniDataParser.Parse(File.ReadAllText(iniPath));
                var config = iniConfig.Sections["pyinstalive"];
                _username = config.GetKeyData("username").Value;
                _password = config.GetKeyData("password").Value;

                _downloadPath = config.GetKeyData("download_path").Value;
                _originalDownloadPath = _downloadPath;

                _downloadLives = bool.Parse(config.GetKeyData("download_lives").Value);
                _downloadReplays = bool.Parse(config.GetKeyData("download_replays").Value);
                _downloadComments = bool.Parse(config.GetKeyData("download_comments").Value);
                _showCookieExpiry = bool.Parse(config.GetKeyData("show_cookie_expiry").Value);
                _logToFile = bool.Parse(config.GetKeyData("log_to_file").Value);

                _ffmpegPath = config.GetKeyData("ffmpeg_path").Value;
                _runAtStart = config.GetKeyData("run_at_start").Value;
                _runAtFinish = config.GetKeyData("run_at_finish").Value;

                _useLocks = bool.Parse(config.GetKeyData("use_locks").Value);
                _clearTempFiles = bool.Parse(config.GetKeyData("clear_temp_files").Value);
                _doHeartbeat = bool.Parse(config.GetKeyData("do_heartbeat").Value);

                _proxy = config.GetKeyData("proxy").Value;

                _skipMerge = bool.Parse(config.GetKeyData("skip_merge").Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while parsing configuration file:\n\n{ex.Message}\n\nEnsure all values are valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
