using SPC_SUPPORT_WIP.Business;
using SPC_SUPPORT_WIP.Database;
using SPC_SUPPORT_WIP.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPC_SUPPORT_WIP
{
    public partial class frmSettting : Form
    {
        SOFTWAREEntities _db = new SOFTWAREEntities();
        string namepc = Properties.Settings.Default.NamePC;
        public frmSettting()
        {
            InitializeComponent();
            GetTaskWindows();
        }
        private void GetTaskWindows()
        {
            // Get the desktopwindow handle
            int nDeshWndHandle = NativeWin32.GetDesktopWindow();
            // Get the first child window
            int nChildHandle = NativeWin32.GetWindow(nDeshWndHandle, NativeWin32.GW_CHILD);
            while (nChildHandle != 0)
            {
                //If the child window is this (SendKeys) application then ignore it.
                if (nChildHandle == this.Handle.ToInt32())
                {
                    nChildHandle = NativeWin32.GetWindow(nChildHandle, NativeWin32.GW_HWNDNEXT);
                }

                // Get only visible windows
                if (NativeWin32.IsWindowVisible(nChildHandle) != 0)
                {
                    StringBuilder sbTitle = new StringBuilder(1024);
                    // Read the Title bar text on the windows to put in combobox
                    NativeWin32.GetWindowText(nChildHandle, sbTitle, sbTitle.Capacity);
                    string sWinTitle = sbTitle.ToString();
                    {
                        if (sWinTitle.Length > 0)
                        {
                            //cbbprocess.Items.Add(sWinTitle);
                        }
                    }
                }
                // Look for the next child.
                nChildHandle = NativeWin32.GetWindow(nChildHandle, NativeWin32.GW_HWNDNEXT);
            }

            LoadSetting();
        }
        public void LoadSetting()
        {
            int found = 0;
            string[] spiNames = Setting.SpiName.GetSpiName();
            for (int i = 0; i < spiNames.Length; i++)
            {
                string name = spiNames[i];
                cbbMachineName.Items.Add(name);
                if (name == Setting.MachineName)
                {
                    found = i;
                }
            }
            cbbMachineName.SelectedIndex = found;
            Setting.Source = Properties.Settings.Default.Source;
            Setting.Target = Properties.Settings.Default.Target;
            Setting.Backup = Properties.Settings.Default.Backup;
            Setting.CurrentStation = Properties.Settings.Default.Station;
            Setting.TimeSleep = Properties.Settings.Default.TimeSleep;
            Setting.Process = Properties.Settings.Default.Process;
            Setting.Model = Properties.Settings.Default.Model;
            Setting.LengthBarcode = Properties.Settings.Default.LengBarcode;
            Setting.Location = Properties.Settings.Default.Location;
            Setting.Index = Properties.Settings.Default.Index;
            Setting.To = Properties.Settings.Default.To;
            Setting.PCPSheet = Properties.Settings.Default.PCPSheet;
            Setting.CollectType = Properties.Settings.Default.NamePC;
            Setting.StationIndex = Properties.Settings.Default.StationIndex;
            Setting.StationTo = Properties.Settings.Default.StationTo;
            Setting.COMPort = Properties.Settings.Default.COMPort;
            Setting.EnableCOM = Properties.Settings.Default.EnableCOM;
            Setting.DataMode = Properties.Settings.Default.DataModel;
            Setting.DataModelStop = Properties.Settings.Default.DataModelStop;
            Setting.MachineName = Properties.Settings.Default.MachineName;
            
        }


        private void btnSaveChanged_Click(object sender, EventArgs e)
        {
            if (txtCurrentStation.Text == "")
            {
                MessageBox.Show("Current Station not null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtCurrentStation.Text.Length > 40)
            {
                MessageBox.Show("Less than 25 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTimesleep.Text.Length > 10)
            {
                MessageBox.Show("Less than 10 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(cbbMachineName.Text))
            {
                MessageBox.Show("Machine Name is not null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Utility.WriteRegistry(KeyName.MACHINE_NAME, cbbMachineName.Text.Trim());
            Utility.WriteRegistry(KeyName.CURRENT_MODEL, cbbModel.Text.Trim());
            Utility.WriteRegistry(KeyName.PC_NAME, cbbNamePC.Text.Trim());
            Utility.WriteRegistry(KeyName.SLEEP_TIME, txtTimesleep.Text.Trim());
            Utility.WriteRegistry(KeyName.STATION, txtCurrentStation.Text.Trim());
            Utility.WriteRegistry(KeyName.STATION_INDEX, txtStationIndex.Text.Trim());
            Utility.WriteRegistry(KeyName.STATION_TO, txtStationTo.Text.Trim());
            using (var _db = new SOFTWAREEntities())
            {
                var datacheck = _db.ALL_SETTINGS_THE_CUSTOMERS.Where(x => x.MODEL.Contains(cbbModel.Text.Trim()) && x.PC_NAME == cbbNamePC.Text.Trim() && !string.IsNullOrEmpty(x.PC_NAME)).FirstOrDefault();

                if (datacheck == null)
                {
                    var data = new ALL_SETTINGS_THE_CUSTOMERS()
                    {
                        PATH_LOG = cbbSource.Text.Trim(),
                        OUTPUT_LOG = txtTarget.Text.Trim(),
                        TIME_SLEEP = int.Parse(txtTimesleep.Text.Trim()),
                        LOCATION = int.Parse(txtLocation.Text.Trim()),
                        MODEL = cbbModel.Text.Trim(),
                        LENGTH_SERIAL = int.Parse(txtlengthBarcode.Text.Trim()),
                        TO = int.Parse(txtTo.Text.Trim()),
                        PCP_SHEET = int.Parse(txtPCP.Text.Trim()),
                        INDEX = int.Parse(txtIndex.Text.Trim()),
                        PC_NAME = cbbNamePC.Text.Trim(),
                        BACK_UP = txtBackup.Text.Trim()
                    };
                    if (string.IsNullOrEmpty(data.BACK_UP)) data.BACK_UP = $@"\\{ServerIp.AOI_SERVER}\s43-new\AOI";
                    _db.ALL_SETTINGS_THE_CUSTOMERS.Add(data);
                    _db.SaveChanges();
                }
                else
                {
                    var id = datacheck.TABLE_ID;
                    var entity = _db.ALL_SETTINGS_THE_CUSTOMERS.FirstOrDefault(item => item.TABLE_ID == id);
                    entity.PATH_LOG = cbbSource.Text;
                    entity.OUTPUT_LOG = txtTarget.Text;
                    entity.TIME_SLEEP = int.Parse(txtTimesleep.Text);
                    entity.LENGTH_SERIAL = int.Parse(txtlengthBarcode.Text);
                    entity.LOCATION = int.Parse(txtLocation.Text);
                    entity.TO = int.Parse(txtTo.Text);
                    entity.PCP_SHEET = int.Parse(txtPCP.Text);
                    entity.INDEX = int.Parse(txtIndex.Text);
                    entity.BACK_UP = txtBackup.Text.Trim();
                    if (string.IsNullOrEmpty(entity.BACK_UP)) entity.BACK_UP = $@"\\{ServerIp.AOI_SERVER}\s43-new\AOI";
                  
                    _db.Entry(entity).State = EntityState.Modified;
                    _db.SaveChanges();

                }
                lblthongbao.Text = $"[{cbbModel.Text}] Lưu thành công!";
                lblthongbao.ForeColor = Color.DarkGreen;
            }
            
        }

        private void frmSettting_Load(object sender, EventArgs e)
        {
            using (var db = new SOFTWAREEntities())
            {
                var namePC = Utility.GetValueRegistryKey(KeyName.PC_NAME);
              
                
                var listNamePC = db.ALL_SETTINGS_THE_CUSTOMERS.GroupBy(m => m.PC_NAME).Select(m => m.Key).ToList();
                cbbNamePC.DataSource = listNamePC;
                cbbNamePC.Text = namePC;
            }
            cbbMachineName.Text = Utility.GetValueRegistryKey(KeyName.MACHINE_NAME);
            txtCurrentStation.Text = Utility.GetValueRegistryKey(KeyName.STATION);
            txtStationIndex.Text = Utility.GetValueRegistryKey(KeyName.STATION_INDEX);
            txtStationTo.Text = Utility.GetValueRegistryKey(KeyName.STATION_TO);
            txtTimesleep.Text = Utility.GetValueRegistryKey(KeyName.SLEEP_TIME);
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var outputLog = new FolderBrowserDialog();
            var open = outputLog.ShowDialog();
            if (open == DialogResult.OK)
            {
                txtTarget.Text = outputLog.SelectedPath;
                if (string.IsNullOrEmpty(txtTarget.Text))
                {
                    btnSaveChanged.Focus();
                }
                else
                {
                    lblInputLog.Focus();
                }
            }
        }

        private void txtTimesleep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTimesleep_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSaveChanged.Focus();
            }
        }

        private void txttimeauto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtkeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }



        private void frmSettting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.Cancel == false)
            {
                Properties.Settings.Default.ONOFF = false;
                Properties.Settings.Default.Save();
            }
        }


        private void txtCurrentStation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new frmLogin().ShowDialog();
            if (Properties.Settings.Default.ONOFF == true)
            {
                btnEdit.Visible = true;
                txtlengthBarcode.ReadOnly = false;
                txtLocation.ReadOnly = false;
                txtCurrentStation.ReadOnly = false;
                txtTimesleep.ReadOnly = false;
                txtIndex.ReadOnly = false;
                txtPCP.ReadOnly = false;
                txtTo.ReadOnly = false;
                btnLogin.Enabled = false;
                cbbNamePC.Enabled = true;
                txtStationIndex.ReadOnly = false;
                txtStationTo.ReadOnly = false;
            }
        }

        private void lblBrowseICTLog_Click(object sender, EventArgs e)
        {
            var outputLog = new FolderBrowserDialog();
            var open = outputLog.ShowDialog();
            if (open == DialogResult.OK)
            {
                cbbSource.Text = outputLog.SelectedPath;
                if (string.IsNullOrEmpty(cbbSource.Text))
                {
                    btnSaveChanged.Focus();
                }
                else
                {
                    cbbSource.Focus();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var info = _db.ALL_SETTINGS_THE_CUSTOMERS.Where(x => x.MODEL.Contains(cbbModel.Text) && x.PC_NAME == cbbNamePC.Text.Trim()).FirstOrDefault();

            var dialogResult = MessageBox.Show($"Do you really want to delete the model [{cbbModel.Text}]?", "Delete Model", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (info != null)
                {
                    _db.ALL_SETTINGS_THE_CUSTOMERS.Remove(info);
                    _db.SaveChanges();
                    lblthongbao.Text = $"Model [{cbbModel.Text}]Delete successfull";
                    lblthongbao.ForeColor = Color.DarkGreen;
                }
            }
        }

        private void cbbNamePC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var model = from ALL_SETTINGS_THE_CUSTOMERS in _db.ALL_SETTINGS_THE_CUSTOMERS where ALL_SETTINGS_THE_CUSTOMERS.PC_NAME == cbbNamePC.Text.Trim() select ALL_SETTINGS_THE_CUSTOMERS.MODEL;
                var rever = model.ToList();
                rever.Reverse();
                cbbModel.DataSource = rever;
                var currentModel = Utility.GetValueRegistryKey(KeyName.CURRENT_MODEL);
                cbbModel.Text = currentModel;
            }
            catch (Exception)
            {

            }
        }

        private void cbbModel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var viewData = _db.ALL_SETTINGS_THE_CUSTOMERS.Where(x => x.MODEL.Contains(cbbModel.Text.Trim()) && x.PC_NAME == cbbNamePC.Text.Trim()).FirstOrDefault();
                if (viewData != null)
                {
                    cbbSource.Text = viewData.PATH_LOG;
                    txtTarget.Text = viewData.OUTPUT_LOG;
                    txtBackup.Text = viewData.BACK_UP;
                    txtCurrentStation.Text = viewData.STATION;
                    txtlengthBarcode.Text = viewData.LENGTH_SERIAL.ToString();
                    txtLocation.Text = viewData.LOCATION.ToString();
                    txtIndex.Text = viewData.INDEX.ToString();
                    txtPCP.Text = viewData.PCP_SHEET.ToString();
                    txtTo.Text = viewData.TO.ToString();
                    txtStationIndex.Text = viewData.STATION_INDEX.ToString();
                    txtStationTo.Text = viewData.STATION_TO.ToString();
                    lblchecknullmodel.Text = "OK";
                    lblchecknullmodel.ForeColor = Color.DarkGreen;
                }
                else
                {
                    lblchecknullmodel.Text = "NULL";
                    lblchecknullmodel.ForeColor = Color.DarkBlue;
                    txtBackup.Text = $@"\\{ServerIp.AOI_SERVER}\s43-new\AOI";
                }
            }
            catch (Exception)
            {

            }
        }
        private void txtStationIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtStationTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cbEnableCOM_Click(object sender, EventArgs e)
        {
            if (cbEnableCOM.Checked == true)
            {
                groupBoxComSerialPortSettings.Enabled = true;
                groupBoxDataMode.Enabled = true;
            }
            else
            {
                groupBoxComSerialPortSettings.Enabled = false;
                groupBoxDataMode.Enabled = false;
            }
        }

        private void btnTestConnect_Click(object sender, EventArgs e)
        {
            cboCOMPort.DataSource = SerialPort.GetPortNames();
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblInputLog_Click(object sender, EventArgs e)
        {
            var outputLog = new FolderBrowserDialog();
            var open = outputLog.ShowDialog();
            if (open == DialogResult.OK)
            {
                txtTarget.Text = outputLog.SelectedPath;
                if (string.IsNullOrEmpty(txtTarget.Text))
                {
                    btnSaveChanged.Focus();
                }
                else
                {
                    lblInputLog.Focus();
                }
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            var outputLog = new FolderBrowserDialog();
            var open = outputLog.ShowDialog();
            if (open == DialogResult.OK)
            {
                txtBackup.Text = outputLog.SelectedPath;
                if (string.IsNullOrEmpty(txtBackup.Text))
                {
                    btnSaveChanged.Focus();
                }
                else
                {
                    btnBackup.Focus();
                }
            }
        }
    }
}
