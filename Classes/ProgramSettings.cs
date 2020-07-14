using PyInstaLive_GUI.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyInstaLive_GUI
{
    public sealed class ProgramSettings
    {
        private static ProgramSettings instance = null;
        private static readonly object padlock = new object();

        public static ProgramSettings Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ProgramSettings();
                    }
                    return instance;
                }
            }
        }

        private string _FFmpegLocation;
        private string _OriginalFFmpegLocation;
        private string _PyInstaLiveLocation;
        private string _PyInstaLiveIniLocation;

        public string FFmpegLocation { get => _FFmpegLocation; set => _FFmpegLocation = value; }
        public string OriginalFFmpegLocation { get => _FFmpegLocation; set => _FFmpegLocation = value; }

        public string PyInstaLiveLocation { get => _PyInstaLiveLocation; set => _PyInstaLiveLocation = value; }
        public string PyInstaLiveIniLocation { get => _PyInstaLiveIniLocation; set => _PyInstaLiveIniLocation = value; }

        public ProgramSettings()
        {
            // Load locations from settings
            _FFmpegLocation = Properties.Settings.Default.FFmpegLocation;
            _PyInstaLiveLocation = Properties.Settings.Default.PyInstaLiveLocation;
            _PyInstaLiveIniLocation = Properties.Settings.Default.PyInstaLiveIniLocation;


            // If loaded settings are invalid, try locating file locally and from PATH if available
            if (!File.Exists(_FFmpegLocation))
            {
                _FFmpegLocation = Utilities.LocateFile("ffmpeg.exe");
                _OriginalFFmpegLocation = _FFmpegLocation;
            }
            if (!File.Exists(_PyInstaLiveLocation))
            {
                _PyInstaLiveLocation = Utilities.LocateFile("pyinstalive_win.exe");
            }
            if (!File.Exists(_PyInstaLiveIniLocation))
            {
                _PyInstaLiveLocation = Utilities.LocateFile("pyinstalive.ini");
            }
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.FFmpegLocation = FFmpegLocation;
            Properties.Settings.Default.PyInstaLiveLocation = PyInstaLiveLocation;
            Properties.Settings.Default.PyInstaLiveIniLocation = PyInstaLiveIniLocation;
            Properties.Settings.Default.Save();
        }
    }
}
