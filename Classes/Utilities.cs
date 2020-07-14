using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyInstaLive_GUI
{
    public static class Utilities
    {
        internal static string LocateFile(string binary)
        {
            if (File.Exists(binary))
            {
                return Path.GetFullPath(binary);
            }

            string pathEnv = Environment.GetEnvironmentVariable("PATH");
            foreach (string path in pathEnv.Split(Path.PathSeparator))
            {
                var fullPath = Path.Combine(path, binary);
                if (File.Exists(fullPath))
                {
                    return fullPath;
                }
            }
            return null;
        }
    }
}
