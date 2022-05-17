using SPC_SUPPORT_WIP.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SPI_SUPPORT_WIP.Entities
{
    public class Ultils
    {
        public static string GetRunningVersion()
        {
            try
            {
                return ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }
            catch
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
        public static Getdata ReadFile(string file)
        {
            try
            {
                var list = new List<Getdata>();
                var data = new Getdata();
                var infos = File.ReadAllLines(file);
                var model = infos[2];
                var modelsp = model.Split(',');
                data.serial = modelsp[4].Trim();

                string path = file.ToString();
                var pathsplit = path.Split('.');
                var getsplit = pathsplit[0];
                data.stationInLog = modelsp[1];
                var listcheck = new List<string>();
                List<string> info = File.ReadAllLines(file).Skip(8).ToList();

                //var block1 = info.Where(r => r == "1").ToList();
                foreach (string line in info)
                {
                    var col = line.Split(',');
                    if (col[1] != "")
                    {
                        int blockno = int.Parse(col[1].Trim());
                        if (blockno == 0)
                        {
                            data.enable_0 = true;
                        }
                        if (blockno == 1)
                        {
                            data.enable_1 = true;
                        }
                        if (blockno == 2)
                        {
                            data.enable_2 = true;
                        }
                        if (blockno == 3)
                        {
                            data.enable_3 = true;
                        }
                        if (blockno == 4)
                        {
                            data.enable_4 = true;
                        }
                        if (blockno == 5)
                        {
                            data.enable_5 = true;
                        }
                        if (blockno == 6)
                        {
                            data.enable_6 = true;
                        }
                        if (blockno == 7)
                        {
                            data.enable_7 = true;
                        }
                        if (blockno == 8)
                        {
                            data.enable_8 = true;
                        }
                        if (blockno == 9)
                        {
                            data.enable_9 = true;
                        }
                        if (blockno == 10)
                        {
                            data.enable_10 = true;
                        }
                        if (blockno == 11)
                        {
                            data.enable_11 = true;
                        }
                        if (blockno == 12)
                        {
                            data.enable_12 = true;
                        }
                        if (blockno == 13)
                        {
                            data.enable_13 = true;
                        }
                        if (blockno == 14)
                        {
                            data.enable_14 = true;
                        }
                        if (blockno == 15)
                        {
                            data.enable_15 = true;
                        }
                        if (blockno == 16)
                        {
                            data.enable_16 = true;
                        }
                        if (blockno == 17)
                        {
                            data.enable_17 = true;
                        }
                        if (blockno == 18)
                        {
                            data.enable_18 = true;
                        }
                        if (blockno == 19)
                        {
                            data.enable_19 = true;
                        }
                        if (blockno == 20)
                        {
                            data.enable_20 = true;
                        }
                        if (blockno == 21)
                        {
                            data.enable_21 = true;
                        }
                        if (blockno == 22)
                        {
                            data.enable_22 = true;
                        }
                        var opjudge = col[17].Trim();
                        var state = Convert.ToInt32(col[17]) == 1 ? "F" : "P";
                        if (blockno == 1 && state != "P")
                        {
                            data.check1 = true;
                        }
                        //
                        if (blockno == 2 && state != "P")
                        {
                            data.check2 = true;
                        }//
                        if (blockno == 3 && state != "P")
                        {
                            data.check3 = true;
                        }
                        //
                        if (blockno == 4 && state != "P")
                        {
                            data.check4 = true;
                        }
                        //
                        if (blockno == 5 && state != "P")
                        {
                            data.check5 = true;
                        }
                        //
                        if (blockno == 6 && state != "P")
                        {
                            data.check6 = true;
                        }
                        //
                        if (blockno == 7 && state != "P")
                        {
                            data.check7 = true;
                        }
                        //
                        if (blockno == 8 && state != "P")
                        {
                            data.check8 = true;
                        }
                        //
                        if (blockno == 9 && state != "P")
                        {
                            data.check9 = true;
                        }
                        //
                        if (blockno == 10 && state != "P")
                        {
                            data.check10 = true;
                        }
                        ///
                        if (blockno == 11 && state != "P")
                        {
                            data.check11 = true;
                        }
                        //
                        if (blockno == 12 && state != "P")
                        {
                            data.check12 = true;
                        }
                        if (blockno == 13 && state != "P")
                        {
                            data.check13 = true;
                        }
                        if (blockno == 14 && state != "P")
                        {
                            data.check14 = true;
                        }
                        if (blockno == 15 && state != "P")
                        {
                            data.check15 = true;
                        }
                        if (blockno == 16 && state != "P")
                        {
                            data.check16 = true;
                        }
                        if (blockno == 17 && state != "P")
                        {
                            data.check17 = true;
                        }
                        if (blockno == 18 && state != "P")
                        {
                            data.check18 = true;
                        }
                        if (blockno == 19 && state != "P")
                        {
                            data.check19 = true;
                        }
                        if (blockno == 20 && state != "P")
                        {
                            data.check20 = true;
                        }
                        if (blockno == 21 && state != "P")
                        {
                            data.check21 = true;
                        }
                        if (blockno == 22 && state != "P")
                        {
                            data.check22 = true;
                        }
                    }
                }
                //data.date = DateTime.Now;
                return data;
            }
            catch (Exception)
            {
                return null;
            }
           

        }
        //public static Results ViewFile(string file)
        //{
        //    //var list = new List<Results>();
        //    //var data = new Results();
        //    //string path = file.ToString();
        //    //var pathsplit = path.Split('.');
        //    //var getsplit = pathsplit[0];
        //    //var info = File.ReadAllLines(file);
        //    //var model = info[2];
        //    //var modelsp = model.Split(',');

        //    //List<string> infodata = File.ReadAllLines(file).Skip(8).ToList();
        //    //foreach (var item in infodata)
        //    //{
        //    //    var col = item.Split(',');
        //    //    if (col[1].Trim() != "" && col[17].Trim() != "")
        //    //    {
        //    //        var blockno = col[1].Trim();
        //    //        var opjudge = col[17].Trim();
        //    //        var state = Convert.ToInt32(col[17]) == 1 ? "F" : "P";
        //    //        //data.model = modelsp[1];
        //    //        var getmodel = modelsp[4];
        //    //        data.serial = modelsp[4];
        //    //        string modelcut = getmodel.Substring(0, 8).Trim();
        //    //        data.model = modelcut;
        //    //        //data.state = state;
        //    //        data.date = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        //    //    }
        //    //}
        //    //return data;
        //}
        //public static GetString GetFile(string file)
        //{
        //    var data = new GetString();
        //    var files = File.ReadAllLines(file);
        //    data.file = files;
        //    return data;
        //}


        public static void ActiveProcess(string title)
        {
            Process[] processes = Process.GetProcesses();
            int windowHandle = 0;
            foreach (Process p in processes)
            {
                if (p.MainWindowTitle.Contains(title))
                {
                    windowHandle = (int)p.MainWindowHandle;
                    break;
                }

            }
            NativeWin32.SetForegroundWindow(windowHandle);
        }
    }
}
