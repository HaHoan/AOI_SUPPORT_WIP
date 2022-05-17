using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_SUPPORT_WIP.Business
{
    public class FileHelper
    {
        private static string MakeNewFile(string file)
        {
            string newFile = Guid.NewGuid().ToString() + file;
            return newFile;
        }
        private static string MoveFile(string sourceFileName, string destFileName)
        {
            string msg = "";
            try
            {
                File.Move(sourceFileName, destFileName);
            }
            catch (Exception ex)
            {

                msg = ex.Message;
            }
            return msg;
        }
        public static string MoveFileOK(string sourceFileName)
        {
            var fileName = Path.GetFileName(sourceFileName);
            string subPath = Path.Combine(Setting.Backup, DateTime.Now.ToString("yyMMdd"));
            if (!Directory.Exists(subPath)) Directory.CreateDirectory(subPath);
            string destFileName = Path.Combine(Setting.Backup, subPath, fileName);
            if (File.Exists(destFileName))
            {
                fileName = MakeNewFile(fileName);
            }
            destFileName = Path.Combine(Setting.Backup, subPath, fileName);
            return MoveFile(sourceFileName, destFileName);
        }
        public static string MoveFileNG(string sourceFileName)
        {
            var fileName = Path.GetFileName(sourceFileName);
            string subPath = Path.Combine(Setting.Backup, "AOI NG BARCODE", DateTime.Now.ToString("yyMMdd"));
            if (!Directory.Exists(subPath)) Directory.CreateDirectory(subPath);
            string destFileName = Path.Combine(Setting.Backup, subPath, fileName);
            if (File.Exists(destFileName))
            {
                fileName = MakeNewFile(fileName);
            }
            destFileName = Path.Combine(Setting.Backup, subPath, fileName);
            return MoveFile(sourceFileName, destFileName);
        }
    }
}
