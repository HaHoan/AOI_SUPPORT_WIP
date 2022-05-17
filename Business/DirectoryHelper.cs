using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_SUPPORT_WIP.Business
{
    public static class DirectoryHelper
    {
        public static string GetModelPath()
        {
            string modelPath = "";
            var allPath = Directory.GetDirectories(Setting.Source);
            modelPath = allPath.Where(r => r.Contains(Setting.Model)).OrderByDescending(f => new DirectoryInfo(f).LastWriteTime).FirstOrDefault();
            return modelPath;
        }
        public static List<string> GetAllPathModel()
        {
            var allPath = Directory.GetDirectories(Setting.Source);
            return allPath.Where(r => r.Contains(Setting.Model)).ToList();
        }
        public static void MakeFolder(string path, string subFolder)
        {
            try
            {
                string subPath = Path.Combine(path, subFolder);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(subFolder);
                }
            }
            catch
            {

            }

        }
    }
}
