using SPC_SUPPORT_WIP.Business;
using SPC_SUPPORT_WIP.Database;
using SPC_SUPPORT_WIP.Entities;
using SPI_SUPPORT_WIP;
using SPI_SUPPORT_WIP.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SPC_SUPPORT_WIP
{
    public partial class frmMain : Form
    {
        SOFTWAREEntities _db = new SOFTWAREEntities();
        UMC_MESDB_TESTEntities _dbService = new UMC_MESDB_TESTEntities();
        int pass = 0, ng = 0, total = 0;
        System.Timers.Timer _timer;
        public frmMain()
        {
            InitializeComponent();
            LoadConfig();
            BindingControl();
            lblVersion.Text = Ultils.GetRunningVersion();
            _timer = new System.Timers.Timer();
            if (Setting.TimeSleep is int time)
            {
                _timer.Interval = time;
            }
            else
            {
                _timer.Interval = 200;
            }

            _timer.Elapsed += new System.Timers.ElapsedEventHandler(TimerElapsed);
        }

        bool on = false;
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyy hh:mm:ss tt");
            }));

            if (btnStart.Enabled == false && on == false)
            {
                on = true;
                var allPath = DirectoryHelper.GetAllPathModel();

                //if (Directory.Exists(Setting.Source))
                if (Directory.GetDirectories(Setting.Source).Count() > 0)
                {
                    //GetLogResult(modelPath);
                    GetLogResult(allPath);

                }
                else
                {
                    IS_SPECIAL();
                }

                on = false;
            }
        }

        public void LoadConfig()
        {
            try
            {
                using (var db = new SOFTWAREEntities())
                {
                    var namePC = Utility.GetValueRegistryKey(KeyName.PC_NAME);
                    var currentModel = Utility.GetValueRegistryKey(KeyName.CURRENT_MODEL);
                    var data = db.ALL_SETTINGS_THE_CUSTOMERS.Where(m => m.PC_NAME == namePC && m.MODEL == currentModel).FirstOrDefault();
                    if (data == null)
                    {
                        FAIL("NG", "Không tìm thấy model " + currentModel);
                        return;
                    }
                    Setting.Source = data.PATH_LOG;
                    Setting.Target = data.OUTPUT_LOG;
                    Setting.Backup = data.BACK_UP;
                    Setting.CurrentStation = Utility.GetValueRegistryKey(KeyName.STATION);
                    Setting.TimeSleep = int.Parse(Utility.GetValueRegistryKey(KeyName.SLEEP_TIME));
                    Setting.Model = currentModel;
                    Setting.LengthBarcode = data.LENGTH_SERIAL;
                    Setting.Location = data.LOCATION;
                    Setting.Index = data.INDEX;
                    Setting.To = data.TO;
                    Setting.PCPSheet = data.PCP_SHEET;
                    Setting.CollectType = namePC;
                    Setting.StationIndex = int.Parse(Utility.GetValueRegistryKey(KeyName.STATION_INDEX));
                    Setting.StationTo = int.Parse(Utility.GetValueRegistryKey(KeyName.STATION_TO));
                    Setting.MachineName = Utility.GetValueRegistryKey(KeyName.MACHINE_NAME);
                }

            }
            catch (Exception e)
            {
                FAIL("FAIL", e.Message.ToString());
            }

        }
        public void BindingControl()
        {
            this.tProduct.Text = Setting.Model;
            this.lblPathRoot.Text = Setting.Source;
        }


        public void GetLogResult(List<string> dir)
        {
            foreach (var item in dir)
            {

                var subFolder = Path.Combine(item, Setting.MachineName);
                this.BeginInvoke(new Action(() =>
                {
                    this.lblPathRoot.Text = subFolder;
                }));
                if (!Directory.Exists(subFolder)) continue;
                DirectoryInfo di = new DirectoryInfo(subFolder);

                List<FileInfo> files = di.GetFiles("*.csv").ToList();
                string sourceFile = "";
                string fileName = "";
                if (files.Count != 0)
                {

                    fileName = files.FirstOrDefault().ToString();
                    sourceFile = Path.Combine(subFolder, fileName);
                    this.BeginInvoke(new Action(() =>
                    {
                        lblPathLog.Text = sourceFile;
                    }));
                    if (!File.Exists(sourceFile)) continue;
                    var data = Ultils.ReadFile(sourceFile);
                    if (data == null) continue;
                    string datetime = DateTime.Now.ToString("yyMMddHHmmss");
                    if (!NetworkConnection.PingNetwork(ServerIp.AOI_SERVER))
                    {
                        FAIL("FAIL", $"Không thể kết nối đến máy chủ {ServerIp.AOI_SERVER}.\nVui lòng kiểm tra lại kết nối mạng");
                        return;
                    }
                    string msg = "";
                    if (data.serial.Length != Setting.LengthBarcode)
                    {
                        msg = FileHelper.MoveFileNG(sourceFile);
                        if (msg != "")
                        {
                            FAIL(@"NG", $"Error: {msg}!");
                            return;
                        }
                    }
                    msg = FileHelper.MoveFileOK(sourceFile);
                    if (msg != "")
                    {
                        FAIL(@"NG", $"Error: {msg}!");
                        return;
                    }
                    //
                    //Tag 2
                    List<Results> listchecktwo = new List<Results>();
                    var serials = data.serial;
                    string theFirst = serials.Substring(0, Setting.Index.GetValueOrDefault());
                    //lblFirst.Text = theFirst;
                    string lastSerial = serials.Substring(Setting.Index.GetValueOrDefault(), Setting.To.GetValueOrDefault());
                    //lblNumber.Text = lastSerial;
                    string endSerial = "";
                    string resultSerial = "";

                    int count = 0;
                    count = data.enable_1 == true ? count = 1 : count;
                    count = data.enable_2 == true ? count = 2 : count;
                    count = data.enable_3 == true ? count = 3 : count;
                    count = data.enable_4 == true ? count = 4 : count;
                    count = data.enable_5 == true ? count = 5 : count;
                    count = data.enable_6 == true ? count = 6 : count;
                    count = data.enable_7 == true ? count = 7 : count;
                    count = data.enable_8 == true ? count = 8 : count;
                    count = data.enable_9 == true ? count = 9 : count;
                    count = data.enable_10 == true ? count = 10 : count;
                    count = data.enable_11 == true ? count = 11 : count;
                    count = data.enable_12 == true ? count = 12 : count;
                    count = data.enable_13 == true ? count = 13 : count;
                    count = data.enable_14 == true ? count = 14 : count;
                    count = data.enable_15 == true ? count = 15 : count;
                    count = data.enable_16 == true ? count = 16 : count;
                    count = data.enable_17 == true ? count = 17 : count;
                    count = data.enable_18 == true ? count = 18 : count;
                    count = data.enable_19 == true ? count = 19 : count;
                    count = data.enable_20 == true ? count = 20 : count;
                    count = data.enable_21 == true ? count = 21 : count;
                    count = data.enable_22 == true ? count = 22 : count;
                    count = data.enable_0 == true ? count = count + 1 : count;
                    int auto = 0;
                    for (int i = 1; i <= count; i++)
                    {
                        auto = Setting.Location - i == 1 ? auto = i : auto;
                    }
                    int isCheck = int.Parse(lastSerial) - auto;

                    if ((isCheck - 1) % Setting.PCPSheet != 0)
                    {
                        FAIL("FAIL", $"Serial [{data.serial}]\r\nBắn sai vị trí Serial!");
                        FileHelper.MoveFileNG(sourceFile);
                        return;
                    }

                    for (int i = 1; i <= count; i++)
                    {
                        string changed = "";
                        int delserial = int.Parse(lastSerial) - auto;
                        int deleserial = delserial + i - 1;
                        string delString = deleserial.ToString();
                        var fdfsdf = Setting.To;
                        if (Setting.To == 4)
                        {
                            if (delString.Length == 1)
                            {
                                changed = "000" + delString;
                            }
                            if (delString.Length == 2)
                            {
                                changed = "00" + delString;
                            }
                            if (delString.Length == 3)
                            {
                                changed = "0" + delString;
                            }
                            if (delString.Length == 4)
                            {
                                changed = delString;
                            }
                        }
                        else if (Setting.To == 5)
                        {
                            if (delString.Length == 1)
                            {
                                changed = "0000" + delString;
                            }
                            if (delString.Length == 2)
                            {
                                changed = "000" + delString;
                            }
                            if (delString.Length == 3)
                            {
                                changed = "00" + delString;
                            }
                            if (delString.Length == 4)
                            {
                                changed = "0" + delString;
                            }
                            if (delString.Length == 5)
                            {
                                changed = delString;
                            }
                        }
                        int getEndSerial = Setting.LengthBarcode.GetValueOrDefault() - (Setting.Index.GetValueOrDefault() + Setting.To.GetValueOrDefault());
                        if (getEndSerial != 0)
                        {
                            endSerial = serials.Substring(serials.Length - getEndSerial);
                            resultSerial = theFirst + changed + endSerial;
                        }
                        else
                        {
                            resultSerial = theFirst + changed;
                        }
                        string status = "";
                        status = i == 1 ? (data.check1 == false ? status = "P" : status = "F")
                            : i == 2 ? (data.check2 == false ? status = "P" : status = "F")
                            : i == 3 ? (data.check3 == false ? status = "P" : status = "F")
                            : i == 4 ? (data.check4 == false ? status = "P" : status = "F")
                            : i == 5 ? (data.check5 == false ? status = "P" : status = "F")
                            : i == 6 ? (data.check6 == false ? status = "P" : status = "F")
                            : i == 7 ? (data.check7 == false ? status = "P" : status = "F")
                            : i == 8 ? (data.check8 == false ? status = "P" : status = "F")
                            : i == 9 ? (data.check9 == false ? status = "P" : status = "F")
                            : i == 10 ? (data.check10 == false ? status = "P" : status = "F")
                            : i == 11 ? (data.check11 == false ? status = "P" : status = "F")
                            : i == 12 ? (data.check12 == false ? status = "P" : status = "F")
                            : i == 13 ? (data.check13 == false ? status = "P" : status = "F")
                            : i == 14 ? (data.check14 == false ? status = "P" : status = "F")
                            : i == 15 ? (data.check15 == false ? status = "P" : status = "F")
                            : i == 16 ? (data.check16 == false ? status = "P" : status = "F")
                            : i == 17 ? (data.check17 == false ? status = "P" : status = "F")
                            : i == 18 ? (data.check18 == false ? status = "P" : status = "F")
                            : i == 19 ? (data.check19 == false ? status = "P" : status = "F")
                            : i == 20 ? (data.check20 == false ? status = "P" : status = "F")
                            : i == 21 ? (data.check21 == false ? status = "P" : status = "F")
                            : i == 22 ? (data.check22 == false ? status = "P" : status = "F") : null;

                        if (status == "P")
                        {
                            PASS("PASS", $"Serial [{serials}] OK");
                            pass = pass + 1;
                        }
                        else
                        {
                            FAIL("FAIL", $"Serial [{serials}] NG");
                            ng = ng + 1;
                        }
                        total = pass + ng;
                        string stationChanged = "";
                        if (data.stationInLog.Contains("SMTA"))
                        {
                            string theString = Setting.CurrentStation;
                            var aStringBuilder = new StringBuilder(theString);
                            aStringBuilder.Remove(Setting.StationIndex.GetValueOrDefault(), Setting.StationTo.GetValueOrDefault());
                            aStringBuilder.Insert(Setting.StationIndex.GetValueOrDefault(), "SMTA");
                            stationChanged = aStringBuilder.ToString();
                        }
                        else
                        {
                            stationChanged = Setting.CurrentStation;
                        }
                        var views = new Results() { model = Setting.Model, serial = resultSerial, date = DateTime.Now, state = status, station = stationChanged };
                        listchecktwo.Add(views);
                        var filepathg = Setting.Target + "\\" + $"{datetime}_{Setting.Model}_{resultSerial}.txt";
                        var format = string.Format("{0}|{1}|{2}|{3}|{4}", Setting.Model, resultSerial, datetime, status, stationChanged);
                        TextWriter tw = new StreamWriter(filepathg);
                        tw.WriteLine(format);
                        tw.Close();
                        tw.Dispose();
                    }
                    this.BeginInvoke(new Action(() => { lblPASS.Text = pass.ToString(); lblNG.Text = ng.ToString(); lblTOTAL.Text = total.ToString(); dataGridView1.DataSource = listchecktwo; }));

                }

            }
        }

        bool deletefile = false;
        public void IS_SPECIAL()
        {
            try
            {
                var di = new DirectoryInfo(Setting.Source);
                var files = di.GetFiles("*.CSV").ToList();
                if (files.Count != 0)
                {
                    Thread.Sleep(Setting.TimeSleep.GetValueOrDefault());
                    string status = "";
                    string datetime = DateTime.Now.ToString("yyMMddHHmmss");
                    var listResult = new List<Results>();
                    var newList = new List<Special>();
                    var fileName = files.FirstOrDefault().ToString();
                    var fullPath = di.ToString() + "\\" + fileName;
                    var list_string = File.ReadAllLines(fullPath).Skip(8).ToList();
                    var dele = list_string.FirstOrDefault().Split(',');
                    if (dele[40].ToString() == "" || dele[40].ToString().Length < 10)
                    {
                        deletefile = true;
                        FAIL("FAIL", $"Vui lòng đợi!\r\nĐang xử lý file không WIP!");
                        foreach (var item in files)
                        {
                            File.Delete(di + "\\" + item.ToString());
                        }
                        WAIT("Waitting", "Waitting for log file");
                        return;
                    }
                    foreach (var item in list_string)
                    {
                        string result = item.ToString();
                        var cut = result.Split(',');
                        if (cut[40].Trim() != "")
                        {
                            newList.Add(new Special() { status = int.Parse(cut[17].Trim()) == 1 ? "F" : "P", serial = cut[40].Trim() });
                        }
                    }
                    var list_Serial = newList.GroupBy(x => x.serial).Select(y => y.FirstOrDefault()).ToList();
                    foreach (var item in list_Serial)
                    {
                        var get_Status = newList.FirstOrDefault(x => x.serial == item.serial && x.status.Contains("F"));
                        if (get_Status != null)
                        {
                            status = "F";
                            ng = ng + 1;
                            FAIL("FAIL", $"Serial is [{item.serial}] NG");
                        }
                        else
                        {
                            status = "P";
                            pass = pass + 1;
                            PASS("PASS", $"Serial is [{item.serial}] OK");
                        }
                        total = pass + ng;
                        listResult.Add(new Results() { model = Setting.Model, serial = item.serial, date = DateTime.Now, state = status, station = Setting.CurrentStation });
                        if (!Directory.Exists(Setting.Target))
                        {
                            Directory.CreateDirectory(Setting.Target);
                        }
                        var filepathg = Setting.Target + "\\" + $"{datetime}_{Setting.Model}_{item.serial}.txt";
                        var format = string.Format("{0}|{1}|{2}|{3}|{4}", Setting.Model, item.serial, datetime, status, Setting.CurrentStation);
                        TextWriter tw = new StreamWriter(filepathg);
                        tw.WriteLine(format);
                        tw.Close();
                        tw.Dispose();
                    }
                    try
                    {
                        string[] cut = fileName.Split('\\');
                        var getcut = cut.LastOrDefault();
                        string path = Setting.Backup;
                        string checkpath = path + "\\" + getcut;
                        if (!NetworkConnection.PingNetwork(ServerIp.AOI_SERVER))
                        {
                            FAIL("FAIL", $"Không thể kết nối đến máy chủ {ServerIp.AOI_SERVER}.\nVui lòng kiểm tra lại kết nối mạng");
                            return;
                        }

                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        if (!File.Exists(checkpath))
                        {
                            try
                            {
                                File.Move(fullPath, checkpath);
                            }
                            catch
                            {
                                FAIL("FAIL", "Lỗi trong quá trình di chuyển Log");
                                return;
                            }
                        }
                        else
                        {
                            var cur = getcut.Split('.');
                            string oldfile = path + "\\" + cur[0] + "_" + datetime + "." + cur[1];
                            try
                            {
                                File.Move(fullPath, oldfile);
                            }
                            catch
                            {
                                FAIL("FAIL", "Lỗi trong quá trình di chuyển Log");
                                return;
                            }
                            //File.Delete(fullpath);
                        }


                    }
                    catch (Exception e)
                    {
                        FAIL("FAIL", e.Message.ToString());
                        return;
                    }
                    this.BeginInvoke(new Action(() =>
                    {
                        lblDateTime.Text = "";
                        lblPASS.Text = pass.ToString();
                        lblNG.Text = ng.ToString();
                        lblTOTAL.Text = total.ToString();
                        dataGridView1.DataSource = listResult;
                    }));
                }
            }
            catch (Exception e)
            {
                FAIL("NG", e.Message.ToString());
                return;
            }
        }


        private void linkLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bunifuTransition1.ShowSync(lblDateTime);
            _timer.Enabled = true;
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            lblConfigs.Enabled = false;
            WAIT("Wait", "Waiting for file logs...");
        }

        private void lblConfigs_Click(object sender, EventArgs e)
        {
            new frmSettting().ShowDialog();
            LoadConfig();
            BindingControl();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            section011.Visible = true;
            section021.Visible = false;
            section031.Visible = false;
            lblStatus.Text = "Status";
            lblMessage.Text = "Message";
            lblStatus.BackColor = Color.DarkOrange;
            lblStatus.ForeColor = Color.White;
            lblMessage.BackColor = Color.DarkOrange;
            lblMessage.ForeColor = Color.White;
            lblpathfile.Text = "";
            _timer.Enabled = false;
            dataGridView1.DataSource = new List<Results>();
            pass = 0; ng = 0; total = 0;
            btnStart.Enabled = true;
            lblPathRoot.Text = "Path root";
            lblPathLog.Text = "Path log";
            btnStop.Enabled = false;
            lblConfigs.Enabled = true;
            this.BeginInvoke(new Action(() => { lblPASS.Text = pass.ToString(); lblNG.Text = ng.ToString(); lblTOTAL.Text = total.ToString(); }));
            on = false;
        }


        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var boardState = row.Cells[3].Value.ToString();
                //int True = Convert.ToInt32(row.Cells[3].Value);
                if (boardState == "F")
                {
                    row.DefaultCellStyle.BackColor = Color.DarkRed;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                //else
                //{
                //    row.DefaultCellStyle.BackColor = Color.DarkGreen;
                //    row.DefaultCellStyle.ForeColor = Color.White;
                //}
            }
        }

        private void lblHidden_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        void WAIT(string status, string message)
        {
            this.BeginInvoke(new Action(() =>
            {
                section011.Visible = true;
                section021.Visible = false;
                section031.Visible = false;
                lblStatus.BackColor = Color.DarkOrange;
                lblStatus.ForeColor = Color.White;
                lblMessage.BackColor = Color.DarkOrange;
                lblMessage.ForeColor = Color.White;
                lblStatus.Text = status;
                lblMessage.Text = message;
            }));
        }
        void PASS(string status, string message)
        {
            this.BeginInvoke(new Action(() =>
            {
                section011.Visible = false;
                section031.Visible = false;
                section021.Visible = true;
                lblStatus.BackColor = Color.DarkGreen;
                lblStatus.ForeColor = Color.White;
                lblMessage.BackColor = Color.DarkGreen;
                lblMessage.ForeColor = Color.White;
                lblStatus.Text = status;
                lblMessage.Text = message;
            }));
        }
        void FAIL(string status, string message)
        {
            //this.BeginInvoke(new Action(() =>
            //{
            section011.Visible = false;
            section021.Visible = false;
            section031.Visible = true;
            lblStatus.BackColor = Color.DarkRed;
            lblStatus.ForeColor = Color.White;
            lblMessage.BackColor = Color.DarkRed;
            lblMessage.ForeColor = Color.White;
            lblStatus.Text = status;
            lblMessage.Text = message;
            //}));
        }
    }
}
