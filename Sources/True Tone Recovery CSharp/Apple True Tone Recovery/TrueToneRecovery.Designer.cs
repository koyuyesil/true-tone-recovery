namespace Apple_True_Tone_Recovery
{
    partial class TrueToneRecovery
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbModelType = new MetroFramework.Controls.MetroComboBox();
            this.cbPort = new MetroFramework.Controls.MetroComboBox();
            this.serialPortLCM = new System.IO.Ports.SerialPort(this.components);
            this.mtabLCMTabs = new MetroFramework.Controls.MetroTabControl();
            this.mtabReadLCMInfo = new MetroFramework.Controls.MetroTabPage();
            this.mtbInfo = new MetroFramework.Controls.MetroTextBox();
            this.mbtnInfo = new MetroFramework.Controls.MetroButton();
            this.mtabReadWriteLCM = new MetroFramework.Controls.MetroTabPage();
            this.mbtnOpenLCMFirmware = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.mbtnReadLcmFirmware = new MetroFramework.Controls.MetroButton();
            this.lblTrueToneSN = new MetroFramework.Controls.MetroLabel();
            this.lblTrueTone = new MetroFramework.Controls.MetroLabel();
            this.tbTrueToneSN = new MetroFramework.Controls.MetroTextBox();
            this.lblMtSN = new MetroFramework.Controls.MetroLabel();
            this.lblMt = new MetroFramework.Controls.MetroLabel();
            this.tbMtSN = new MetroFramework.Controls.MetroTextBox();
            this.lblGaussSN = new MetroFramework.Controls.MetroLabel();
            this.lblGauss = new MetroFramework.Controls.MetroLabel();
            this.tbGaussSN = new MetroFramework.Controls.MetroTextBox();
            this.lblLCMSN = new MetroFramework.Controls.MetroLabel();
            this.lblLCM = new MetroFramework.Controls.MetroLabel();
            this.tbLCMSN = new MetroFramework.Controls.MetroTextBox();
            this.mbtnWrite = new MetroFramework.Controls.MetroButton();
            this.mtabHexView = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.hexBox1 = new Be.Windows.Forms.HexBox();
            this.mbtnClose = new MetroFramework.Controls.MetroButton();
            this.mtabLCMTabs.SuspendLayout();
            this.mtabReadLCMInfo.SuspendLayout();
            this.mtabReadWriteLCM.SuspendLayout();
            this.mtabHexView.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbModelType
            // 
            this.cbModelType.FormattingEnabled = true;
            this.cbModelType.ItemHeight = 23;
            this.cbModelType.Location = new System.Drawing.Point(17, 70);
            this.cbModelType.Margin = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.cbModelType.Name = "cbModelType";
            this.cbModelType.Size = new System.Drawing.Size(150, 29);
            this.cbModelType.Style = MetroFramework.MetroColorStyle.Purple;
            this.cbModelType.TabIndex = 0;
            this.cbModelType.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbModelType.UseSelectable = true;
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.ItemHeight = 23;
            this.cbPort.Items.AddRange(new object[] {
            "COM32"});
            this.cbPort.Location = new System.Drawing.Point(177, 70);
            this.cbPort.Margin = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.cbPort.Name = "cbPort";
            this.cbPort.PromptText = "Port";
            this.cbPort.Size = new System.Drawing.Size(95, 29);
            this.cbPort.Style = MetroFramework.MetroColorStyle.Purple;
            this.cbPort.TabIndex = 1;
            this.cbPort.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbPort.UseSelectable = true;
            this.cbPort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbPort_MouseClick);
            // 
            // serialPortLCM
            // 
            this.serialPortLCM.BaudRate = 115200;
            this.serialPortLCM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortLCM_DataReceived);
            // 
            // mtabLCMTabs
            // 
            this.mtabLCMTabs.Controls.Add(this.mtabReadLCMInfo);
            this.mtabLCMTabs.Controls.Add(this.mtabReadWriteLCM);
            this.mtabLCMTabs.Controls.Add(this.mtabHexView);
            this.mtabLCMTabs.Location = new System.Drawing.Point(13, 107);
            this.mtabLCMTabs.Name = "mtabLCMTabs";
            this.mtabLCMTabs.SelectedIndex = 1;
            this.mtabLCMTabs.Size = new System.Drawing.Size(855, 647);
            this.mtabLCMTabs.TabIndex = 5;
            this.mtabLCMTabs.UseSelectable = true;
            // 
            // mtabReadLCMInfo
            // 
            this.mtabReadLCMInfo.Controls.Add(this.mtbInfo);
            this.mtabReadLCMInfo.Controls.Add(this.mbtnInfo);
            this.mtabReadLCMInfo.HorizontalScrollbarBarColor = true;
            this.mtabReadLCMInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.mtabReadLCMInfo.HorizontalScrollbarSize = 2;
            this.mtabReadLCMInfo.Location = new System.Drawing.Point(4, 38);
            this.mtabReadLCMInfo.Name = "mtabReadLCMInfo";
            this.mtabReadLCMInfo.Size = new System.Drawing.Size(847, 605);
            this.mtabReadLCMInfo.TabIndex = 0;
            this.mtabReadLCMInfo.Text = "Read LCM Info";
            this.mtabReadLCMInfo.VerticalScrollbarBarColor = true;
            this.mtabReadLCMInfo.VerticalScrollbarHighlightOnWheel = false;
            this.mtabReadLCMInfo.VerticalScrollbarSize = 2;
            // 
            // mtbInfo
            // 
            // 
            // 
            // 
            this.mtbInfo.CustomButton.Image = null;
            this.mtbInfo.CustomButton.Location = new System.Drawing.Point(227, 2);
            this.mtbInfo.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.mtbInfo.CustomButton.Name = "mtbInfo";
            this.mtbInfo.CustomButton.Size = new System.Drawing.Size(401, 435);
            this.mtbInfo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbInfo.CustomButton.TabIndex = 1;
            this.mtbInfo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbInfo.CustomButton.UseSelectable = true;
            this.mtbInfo.CustomButton.Visible = false;
            this.mtbInfo.Lines = new string[0];
            this.mtbInfo.Location = new System.Drawing.Point(3, 62);
            this.mtbInfo.MaxLength = 32767;
            this.mtbInfo.Multiline = true;
            this.mtbInfo.Name = "mtbInfo";
            this.mtbInfo.PasswordChar = '\0';
            this.mtbInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbInfo.SelectedText = "";
            this.mtbInfo.SelectionLength = 0;
            this.mtbInfo.SelectionStart = 0;
            this.mtbInfo.ShortcutsEnabled = true;
            this.mtbInfo.Size = new System.Drawing.Size(841, 540);
            this.mtbInfo.TabIndex = 22;
            this.mtbInfo.UseSelectable = true;
            this.mtbInfo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbInfo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtnInfo
            // 
            this.mbtnInfo.Location = new System.Drawing.Point(5, 25);
            this.mbtnInfo.Margin = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.mbtnInfo.Name = "mbtnInfo";
            this.mbtnInfo.Size = new System.Drawing.Size(115, 29);
            this.mbtnInfo.Style = MetroFramework.MetroColorStyle.Purple;
            this.mbtnInfo.TabIndex = 6;
            this.mbtnInfo.Text = "Read LCM Info";
            this.mbtnInfo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mbtnInfo.UseSelectable = true;
            this.mbtnInfo.Click += new System.EventHandler(this.mbtnReadLcmInfo_Click);
            // 
            // mtabReadWriteLCM
            // 
            this.mtabReadWriteLCM.Controls.Add(this.mbtnOpenLCMFirmware);
            this.mtabReadWriteLCM.Controls.Add(this.metroLabel1);
            this.mtabReadWriteLCM.Controls.Add(this.metroProgressBar1);
            this.mtabReadWriteLCM.Controls.Add(this.mbtnReadLcmFirmware);
            this.mtabReadWriteLCM.Controls.Add(this.lblTrueToneSN);
            this.mtabReadWriteLCM.Controls.Add(this.lblTrueTone);
            this.mtabReadWriteLCM.Controls.Add(this.tbTrueToneSN);
            this.mtabReadWriteLCM.Controls.Add(this.lblMtSN);
            this.mtabReadWriteLCM.Controls.Add(this.lblMt);
            this.mtabReadWriteLCM.Controls.Add(this.tbMtSN);
            this.mtabReadWriteLCM.Controls.Add(this.lblGaussSN);
            this.mtabReadWriteLCM.Controls.Add(this.lblGauss);
            this.mtabReadWriteLCM.Controls.Add(this.tbGaussSN);
            this.mtabReadWriteLCM.Controls.Add(this.lblLCMSN);
            this.mtabReadWriteLCM.Controls.Add(this.lblLCM);
            this.mtabReadWriteLCM.Controls.Add(this.tbLCMSN);
            this.mtabReadWriteLCM.Controls.Add(this.mbtnWrite);
            this.mtabReadWriteLCM.HorizontalScrollbarBarColor = true;
            this.mtabReadWriteLCM.HorizontalScrollbarHighlightOnWheel = false;
            this.mtabReadWriteLCM.HorizontalScrollbarSize = 2;
            this.mtabReadWriteLCM.Location = new System.Drawing.Point(4, 38);
            this.mtabReadWriteLCM.Name = "mtabReadWriteLCM";
            this.mtabReadWriteLCM.Size = new System.Drawing.Size(847, 605);
            this.mtabReadWriteLCM.TabIndex = 2;
            this.mtabReadWriteLCM.Text = "Read Write";
            this.mtabReadWriteLCM.VerticalScrollbarBarColor = true;
            this.mtabReadWriteLCM.VerticalScrollbarHighlightOnWheel = false;
            this.mtabReadWriteLCM.VerticalScrollbarSize = 2;
            // 
            // mbtnOpenLCMFirmware
            // 
            this.mbtnOpenLCMFirmware.Location = new System.Drawing.Point(140, 272);
            this.mbtnOpenLCMFirmware.Margin = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.mbtnOpenLCMFirmware.Name = "mbtnOpenLCMFirmware";
            this.mbtnOpenLCMFirmware.Size = new System.Drawing.Size(115, 30);
            this.mbtnOpenLCMFirmware.Style = MetroFramework.MetroColorStyle.Purple;
            this.mbtnOpenLCMFirmware.TabIndex = 36;
            this.mbtnOpenLCMFirmware.Text = "Open LCM Firmware";
            this.mbtnOpenLCMFirmware.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mbtnOpenLCMFirmware.UseSelectable = true;
            this.mbtnOpenLCMFirmware.Click += new System.EventHandler(this.mbtnOpenLCMFirmware_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 330);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 35;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(10, 580);
            this.metroProgressBar1.Maximum = 4000;
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(832, 29);
            this.metroProgressBar1.TabIndex = 34;
            // 
            // mbtnReadLcmFirmware
            // 
            this.mbtnReadLcmFirmware.Location = new System.Drawing.Point(10, 272);
            this.mbtnReadLcmFirmware.Margin = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.mbtnReadLcmFirmware.Name = "mbtnReadLcmFirmware";
            this.mbtnReadLcmFirmware.Size = new System.Drawing.Size(115, 30);
            this.mbtnReadLcmFirmware.Style = MetroFramework.MetroColorStyle.Purple;
            this.mbtnReadLcmFirmware.TabIndex = 11;
            this.mbtnReadLcmFirmware.Text = "Read LCM Firmware";
            this.mbtnReadLcmFirmware.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mbtnReadLcmFirmware.UseSelectable = true;
            this.mbtnReadLcmFirmware.Click += new System.EventHandler(this.mbtnReadLcmFirmware_Click);
            // 
            // lblTrueToneSN
            // 
            this.lblTrueToneSN.Enabled = false;
            this.lblTrueToneSN.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTrueToneSN.Location = new System.Drawing.Point(787, 199);
            this.lblTrueToneSN.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.lblTrueToneSN.Name = "lblTrueToneSN";
            this.lblTrueToneSN.Size = new System.Drawing.Size(55, 21);
            this.lblTrueToneSN.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblTrueToneSN.TabIndex = 32;
            this.lblTrueToneSN.Text = "-- / --";
            this.lblTrueToneSN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTrueToneSN.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblTrueTone
            // 
            this.lblTrueTone.Enabled = false;
            this.lblTrueTone.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTrueTone.Location = new System.Drawing.Point(10, 199);
            this.lblTrueTone.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.lblTrueTone.Name = "lblTrueTone";
            this.lblTrueTone.Size = new System.Drawing.Size(185, 21);
            this.lblTrueTone.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblTrueTone.TabIndex = 31;
            this.lblTrueTone.Text = "TrueToneSN";
            this.lblTrueTone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTrueTone.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tbTrueToneSN
            // 
            // 
            // 
            // 
            this.tbTrueToneSN.CustomButton.Image = null;
            this.tbTrueToneSN.CustomButton.Location = new System.Drawing.Point(606, 1);
            this.tbTrueToneSN.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tbTrueToneSN.CustomButton.Name = "";
            this.tbTrueToneSN.CustomButton.Size = new System.Drawing.Size(17, 19);
            this.tbTrueToneSN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTrueToneSN.CustomButton.TabIndex = 1;
            this.tbTrueToneSN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTrueToneSN.CustomButton.UseSelectable = true;
            this.tbTrueToneSN.CustomButton.Visible = false;
            this.tbTrueToneSN.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbTrueToneSN.Lines = new string[0];
            this.tbTrueToneSN.Location = new System.Drawing.Point(10, 222);
            this.tbTrueToneSN.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tbTrueToneSN.MaxLength = 0;
            this.tbTrueToneSN.Name = "tbTrueToneSN";
            this.tbTrueToneSN.PasswordChar = '\0';
            this.tbTrueToneSN.PromptText = "TrueTone Serial Number";
            this.tbTrueToneSN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTrueToneSN.SelectedText = "";
            this.tbTrueToneSN.SelectionLength = 0;
            this.tbTrueToneSN.SelectionStart = 0;
            this.tbTrueToneSN.ShortcutsEnabled = true;
            this.tbTrueToneSN.Size = new System.Drawing.Size(832, 25);
            this.tbTrueToneSN.Style = MetroFramework.MetroColorStyle.Purple;
            this.tbTrueToneSN.TabIndex = 10;
            this.tbTrueToneSN.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTrueToneSN.UseSelectable = true;
            this.tbTrueToneSN.WaterMark = "TrueTone Serial Number";
            this.tbTrueToneSN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTrueToneSN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbTrueToneSN.TextChanged += new System.EventHandler(this.tbLCMItems_TextChanged);
            this.tbTrueToneSN.DoubleClick += new System.EventHandler(this.tbLCMItems_DoubleClick);
            // 
            // lblMtSN
            // 
            this.lblMtSN.Enabled = false;
            this.lblMtSN.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMtSN.Location = new System.Drawing.Point(787, 141);
            this.lblMtSN.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.lblMtSN.Name = "lblMtSN";
            this.lblMtSN.Size = new System.Drawing.Size(55, 21);
            this.lblMtSN.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblMtSN.TabIndex = 29;
            this.lblMtSN.Text = "-- / --";
            this.lblMtSN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMtSN.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblMt
            // 
            this.lblMt.Enabled = false;
            this.lblMt.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMt.Location = new System.Drawing.Point(10, 141);
            this.lblMt.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.lblMt.Name = "lblMt";
            this.lblMt.Size = new System.Drawing.Size(185, 21);
            this.lblMt.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblMt.TabIndex = 28;
            this.lblMt.Text = "MtSN";
            this.lblMt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMt.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tbMtSN
            // 
            // 
            // 
            // 
            this.tbMtSN.CustomButton.Image = null;
            this.tbMtSN.CustomButton.Location = new System.Drawing.Point(606, 1);
            this.tbMtSN.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tbMtSN.CustomButton.Name = "";
            this.tbMtSN.CustomButton.Size = new System.Drawing.Size(17, 19);
            this.tbMtSN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMtSN.CustomButton.TabIndex = 1;
            this.tbMtSN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMtSN.CustomButton.UseSelectable = true;
            this.tbMtSN.CustomButton.Visible = false;
            this.tbMtSN.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbMtSN.Lines = new string[0];
            this.tbMtSN.Location = new System.Drawing.Point(10, 164);
            this.tbMtSN.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tbMtSN.MaxLength = 0;
            this.tbMtSN.Name = "tbMtSN";
            this.tbMtSN.PasswordChar = '\0';
            this.tbMtSN.PromptText = "Mt Serial Number (Cover Board Serial Number)";
            this.tbMtSN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMtSN.SelectedText = "";
            this.tbMtSN.SelectionLength = 0;
            this.tbMtSN.SelectionStart = 0;
            this.tbMtSN.ShortcutsEnabled = true;
            this.tbMtSN.Size = new System.Drawing.Size(832, 25);
            this.tbMtSN.Style = MetroFramework.MetroColorStyle.Purple;
            this.tbMtSN.TabIndex = 9;
            this.tbMtSN.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMtSN.UseSelectable = true;
            this.tbMtSN.WaterMark = "Mt Serial Number (Cover Board Serial Number)";
            this.tbMtSN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMtSN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbMtSN.TextChanged += new System.EventHandler(this.tbLCMItems_TextChanged);
            this.tbMtSN.DoubleClick += new System.EventHandler(this.tbLCMItems_DoubleClick);
            // 
            // lblGaussSN
            // 
            this.lblGaussSN.Enabled = false;
            this.lblGaussSN.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblGaussSN.Location = new System.Drawing.Point(787, 83);
            this.lblGaussSN.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.lblGaussSN.Name = "lblGaussSN";
            this.lblGaussSN.Size = new System.Drawing.Size(55, 21);
            this.lblGaussSN.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblGaussSN.TabIndex = 26;
            this.lblGaussSN.Text = "-- / --";
            this.lblGaussSN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGaussSN.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblGauss
            // 
            this.lblGauss.Enabled = false;
            this.lblGauss.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblGauss.Location = new System.Drawing.Point(10, 83);
            this.lblGauss.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.lblGauss.Name = "lblGauss";
            this.lblGauss.Size = new System.Drawing.Size(185, 21);
            this.lblGauss.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblGauss.TabIndex = 25;
            this.lblGauss.Text = "GaussSN";
            this.lblGauss.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGauss.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tbGaussSN
            // 
            // 
            // 
            // 
            this.tbGaussSN.CustomButton.Image = null;
            this.tbGaussSN.CustomButton.Location = new System.Drawing.Point(606, 1);
            this.tbGaussSN.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tbGaussSN.CustomButton.Name = "";
            this.tbGaussSN.CustomButton.Size = new System.Drawing.Size(17, 19);
            this.tbGaussSN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbGaussSN.CustomButton.TabIndex = 1;
            this.tbGaussSN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbGaussSN.CustomButton.UseSelectable = true;
            this.tbGaussSN.CustomButton.Visible = false;
            this.tbGaussSN.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbGaussSN.Lines = new string[0];
            this.tbGaussSN.Location = new System.Drawing.Point(10, 106);
            this.tbGaussSN.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tbGaussSN.MaxLength = 0;
            this.tbGaussSN.Name = "tbGaussSN";
            this.tbGaussSN.PasswordChar = '\0';
            this.tbGaussSN.PromptText = "Gauss Serial Number";
            this.tbGaussSN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbGaussSN.SelectedText = "";
            this.tbGaussSN.SelectionLength = 0;
            this.tbGaussSN.SelectionStart = 0;
            this.tbGaussSN.ShortcutsEnabled = true;
            this.tbGaussSN.Size = new System.Drawing.Size(832, 25);
            this.tbGaussSN.Style = MetroFramework.MetroColorStyle.Purple;
            this.tbGaussSN.TabIndex = 8;
            this.tbGaussSN.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbGaussSN.UseSelectable = true;
            this.tbGaussSN.WaterMark = "Gauss Serial Number";
            this.tbGaussSN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbGaussSN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbGaussSN.TextChanged += new System.EventHandler(this.tbLCMItems_TextChanged);
            this.tbGaussSN.DoubleClick += new System.EventHandler(this.tbLCMItems_DoubleClick);
            // 
            // lblLCMSN
            // 
            this.lblLCMSN.Enabled = false;
            this.lblLCMSN.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblLCMSN.Location = new System.Drawing.Point(787, 25);
            this.lblLCMSN.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.lblLCMSN.Name = "lblLCMSN";
            this.lblLCMSN.Size = new System.Drawing.Size(55, 21);
            this.lblLCMSN.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblLCMSN.TabIndex = 23;
            this.lblLCMSN.Text = "-- / --";
            this.lblLCMSN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLCMSN.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lblLCM
            // 
            this.lblLCM.Enabled = false;
            this.lblLCM.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblLCM.Location = new System.Drawing.Point(5, 25);
            this.lblLCM.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.lblLCM.Name = "lblLCM";
            this.lblLCM.Size = new System.Drawing.Size(185, 21);
            this.lblLCM.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblLCM.TabIndex = 22;
            this.lblLCM.Text = "LCMSN";
            this.lblLCM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLCM.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tbLCMSN
            // 
            // 
            // 
            // 
            this.tbLCMSN.CustomButton.Image = null;
            this.tbLCMSN.CustomButton.Location = new System.Drawing.Point(606, 1);
            this.tbLCMSN.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tbLCMSN.CustomButton.Name = "";
            this.tbLCMSN.CustomButton.Size = new System.Drawing.Size(17, 19);
            this.tbLCMSN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLCMSN.CustomButton.TabIndex = 1;
            this.tbLCMSN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLCMSN.CustomButton.UseSelectable = true;
            this.tbLCMSN.CustomButton.Visible = false;
            this.tbLCMSN.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbLCMSN.Lines = new string[0];
            this.tbLCMSN.Location = new System.Drawing.Point(10, 48);
            this.tbLCMSN.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tbLCMSN.MaxLength = 0;
            this.tbLCMSN.Name = "tbLCMSN";
            this.tbLCMSN.PasswordChar = '\0';
            this.tbLCMSN.PromptText = "LCM Serial Number";
            this.tbLCMSN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLCMSN.SelectedText = "";
            this.tbLCMSN.SelectionLength = 0;
            this.tbLCMSN.SelectionStart = 0;
            this.tbLCMSN.ShortcutsEnabled = true;
            this.tbLCMSN.Size = new System.Drawing.Size(832, 25);
            this.tbLCMSN.Style = MetroFramework.MetroColorStyle.Purple;
            this.tbLCMSN.TabIndex = 7;
            this.tbLCMSN.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLCMSN.UseSelectable = true;
            this.tbLCMSN.WaterMark = "LCM Serial Number";
            this.tbLCMSN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbLCMSN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbLCMSN.TextChanged += new System.EventHandler(this.tbLCMItems_TextChanged);
            this.tbLCMSN.DoubleClick += new System.EventHandler(this.tbLCMItems_DoubleClick);
            // 
            // mbtnWrite
            // 
            this.mbtnWrite.Location = new System.Drawing.Point(727, 272);
            this.mbtnWrite.Margin = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.mbtnWrite.Name = "mbtnWrite";
            this.mbtnWrite.Size = new System.Drawing.Size(115, 29);
            this.mbtnWrite.Style = MetroFramework.MetroColorStyle.Purple;
            this.mbtnWrite.TabIndex = 12;
            this.mbtnWrite.Text = "Write";
            this.mbtnWrite.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mbtnWrite.UseSelectable = true;
            this.mbtnWrite.Click += new System.EventHandler(this.mbtnWrite_Click);
            // 
            // mtabHexView
            // 
            this.mtabHexView.Controls.Add(this.metroPanel1);
            this.mtabHexView.HorizontalScrollbarBarColor = true;
            this.mtabHexView.HorizontalScrollbarHighlightOnWheel = false;
            this.mtabHexView.HorizontalScrollbarSize = 2;
            this.mtabHexView.Location = new System.Drawing.Point(4, 38);
            this.mtabHexView.Name = "mtabHexView";
            this.mtabHexView.Size = new System.Drawing.Size(847, 605);
            this.mtabHexView.TabIndex = 1;
            this.mtabHexView.Text = "HE&X View";
            this.mtabHexView.VerticalScrollbarBarColor = true;
            this.mtabHexView.VerticalScrollbarHighlightOnWheel = false;
            this.mtabHexView.VerticalScrollbarSize = 2;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.hexBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 2;
            this.metroPanel1.Location = new System.Drawing.Point(3, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(841, 542);
            this.metroPanel1.TabIndex = 26;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 2;
            // 
            // hexBox1
            // 
            this.hexBox1.ColumnInfoVisible = true;
            this.hexBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hexBox1.LineInfoVisible = true;
            this.hexBox1.Location = new System.Drawing.Point(3, 3);
            this.hexBox1.Name = "hexBox1";
            this.hexBox1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            this.hexBox1.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBox1.Size = new System.Drawing.Size(835, 536);
            this.hexBox1.StringViewVisible = true;
            this.hexBox1.TabIndex = 23;
            this.hexBox1.UseFixedBytesPerLine = true;
            this.hexBox1.VScrollBarVisible = true;
            // 
            // mbtnClose
            // 
            this.mbtnClose.Location = new System.Drawing.Point(282, 70);
            this.mbtnClose.Margin = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.mbtnClose.Name = "mbtnClose";
            this.mbtnClose.Size = new System.Drawing.Size(115, 29);
            this.mbtnClose.Style = MetroFramework.MetroColorStyle.Purple;
            this.mbtnClose.TabIndex = 2;
            this.mbtnClose.Text = "Close";
            this.mbtnClose.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mbtnClose.UseSelectable = true;
            this.mbtnClose.Click += new System.EventHandler(this.mbtnClose_Click);
            // 
            // TrueToneRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 767);
            this.Controls.Add(this.mbtnClose);
            this.Controls.Add(this.mtabLCMTabs);
            this.Controls.Add(this.cbModelType);
            this.Controls.Add(this.cbPort);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.Name = "TrueToneRecovery";
            this.Padding = new System.Windows.Forms.Padding(10, 70, 10, 10);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Apple LCM Dumper";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrueToneRecovery_FormClosing);
            this.mtabLCMTabs.ResumeLayout(false);
            this.mtabReadLCMInfo.ResumeLayout(false);
            this.mtabReadWriteLCM.ResumeLayout(false);
            this.mtabReadWriteLCM.PerformLayout();
            this.mtabHexView.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cbModelType;
        private MetroFramework.Controls.MetroComboBox cbPort;
        private System.IO.Ports.SerialPort serialPortLCM;
        private MetroFramework.Controls.MetroTabControl mtabLCMTabs;
        private MetroFramework.Controls.MetroTabPage mtabReadLCMInfo;
        private MetroFramework.Controls.MetroTabPage mtabHexView;
        private MetroFramework.Controls.MetroTabPage mtabReadWriteLCM;
        private MetroFramework.Controls.MetroLabel lblLCMSN;
        private MetroFramework.Controls.MetroLabel lblLCM;
        private MetroFramework.Controls.MetroTextBox tbLCMSN;
        private MetroFramework.Controls.MetroButton mbtnWrite;
        private MetroFramework.Controls.MetroTextBox mtbInfo;
        private MetroFramework.Controls.MetroButton mbtnInfo;
        private Be.Windows.Forms.HexBox hexBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton mbtnClose;
        private MetroFramework.Controls.MetroLabel lblTrueToneSN;
        private MetroFramework.Controls.MetroLabel lblTrueTone;
        private MetroFramework.Controls.MetroTextBox tbTrueToneSN;
        private MetroFramework.Controls.MetroLabel lblMtSN;
        private MetroFramework.Controls.MetroLabel lblMt;
        private MetroFramework.Controls.MetroTextBox tbMtSN;
        private MetroFramework.Controls.MetroLabel lblGaussSN;
        private MetroFramework.Controls.MetroLabel lblGauss;
        private MetroFramework.Controls.MetroTextBox tbGaussSN;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroButton mbtnReadLcmFirmware;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton mbtnOpenLCMFirmware;
    }
}

