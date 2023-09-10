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
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.mtbHexView = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.hexBox1 = new Be.Windows.Forms.HexBox();
            this.mtabReadWriteLCM = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbTrueTone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tbMtSN = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbGaussSN = new MetroFramework.Controls.MetroTextBox();
            this.lblNumCBSN = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbLCMSN = new MetroFramework.Controls.MetroTextBox();
            this.btnWrite = new MetroFramework.Controls.MetroButton();
            this.mbtnClose = new MetroFramework.Controls.MetroButton();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.mbtnReadLcmFirmware = new MetroFramework.Controls.MetroButton();
            this.mtabLCMTabs.SuspendLayout();
            this.mtabReadLCMInfo.SuspendLayout();
            this.mtbHexView.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.mtabReadWriteLCM.SuspendLayout();
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
            this.mtabLCMTabs.Controls.Add(this.mtbHexView);
            this.mtabLCMTabs.Location = new System.Drawing.Point(13, 107);
            this.mtabLCMTabs.Name = "mtabLCMTabs";
            this.mtabLCMTabs.SelectedIndex = 0;
            this.mtabLCMTabs.Size = new System.Drawing.Size(855, 647);
            this.mtabLCMTabs.TabIndex = 5;
            this.mtabLCMTabs.UseSelectable = true;
            // 
            // mtabReadLCMInfo
            // 
            this.mtabReadLCMInfo.Controls.Add(this.metroTextBox1);
            this.mtabReadLCMInfo.Controls.Add(this.metroButton1);
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
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(227, 2);
            this.metroTextBox1.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(401, 435);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(3, 62);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(841, 540);
            this.metroTextBox1.TabIndex = 22;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(5, 25);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(115, 29);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Read LCM Info";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.mbtnReadLcmInfo_Click);
            // 
            // mtbHexView
            // 
            this.mtbHexView.Controls.Add(this.metroPanel1);
            this.mtbHexView.HorizontalScrollbarBarColor = true;
            this.mtbHexView.HorizontalScrollbarHighlightOnWheel = false;
            this.mtbHexView.HorizontalScrollbarSize = 2;
            this.mtbHexView.Location = new System.Drawing.Point(4, 38);
            this.mtbHexView.Name = "mtbHexView";
            this.mtbHexView.Size = new System.Drawing.Size(847, 605);
            this.mtbHexView.TabIndex = 1;
            this.mtbHexView.Text = "HE&X View";
            this.mtbHexView.VerticalScrollbarBarColor = true;
            this.mtbHexView.VerticalScrollbarHighlightOnWheel = false;
            this.mtbHexView.VerticalScrollbarSize = 2;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.hexBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 4;
            this.metroPanel1.Location = new System.Drawing.Point(3, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(841, 542);
            this.metroPanel1.TabIndex = 26;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 3;
            // 
            // hexBox1
            // 
            this.hexBox1.ColumnInfoVisible = true;
            this.hexBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hexBox1.LineInfoVisible = true;
            this.hexBox1.Location = new System.Drawing.Point(3, 3);
            this.hexBox1.Name = "hexBox1";
            this.hexBox1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            this.hexBox1.ShadowSelectionColor = System.Drawing.Color.Transparent;
            this.hexBox1.Size = new System.Drawing.Size(835, 536);
            this.hexBox1.StringViewVisible = true;
            this.hexBox1.TabIndex = 23;
            this.hexBox1.UseFixedBytesPerLine = true;
            this.hexBox1.VScrollBarVisible = true;
            // 
            // mtabReadWriteLCM
            // 
            this.mtabReadWriteLCM.Controls.Add(this.metroProgressBar1);
            this.mtabReadWriteLCM.Controls.Add(this.mbtnReadLcmFirmware);
            this.mtabReadWriteLCM.Controls.Add(this.metroLabel4);
            this.mtabReadWriteLCM.Controls.Add(this.metroLabel5);
            this.mtabReadWriteLCM.Controls.Add(this.tbTrueTone);
            this.mtabReadWriteLCM.Controls.Add(this.metroLabel6);
            this.mtabReadWriteLCM.Controls.Add(this.metroLabel7);
            this.mtabReadWriteLCM.Controls.Add(this.tbMtSN);
            this.mtabReadWriteLCM.Controls.Add(this.metroLabel2);
            this.mtabReadWriteLCM.Controls.Add(this.metroLabel3);
            this.mtabReadWriteLCM.Controls.Add(this.tbGaussSN);
            this.mtabReadWriteLCM.Controls.Add(this.lblNumCBSN);
            this.mtabReadWriteLCM.Controls.Add(this.metroLabel1);
            this.mtabReadWriteLCM.Controls.Add(this.tbLCMSN);
            this.mtabReadWriteLCM.Controls.Add(this.btnWrite);
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
            // metroLabel4
            // 
            this.metroLabel4.Enabled = false;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(787, 199);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(55, 21);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel4.TabIndex = 32;
            this.metroLabel4.Text = "-- / --";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Enabled = false;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(10, 199);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(185, 21);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "TrueToneSN";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tbTrueTone
            // 
            this.tbTrueTone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.tbTrueTone.CustomButton.Image = null;
            this.tbTrueTone.CustomButton.Location = new System.Drawing.Point(606, 1);
            this.tbTrueTone.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tbTrueTone.CustomButton.Name = "";
            this.tbTrueTone.CustomButton.Size = new System.Drawing.Size(17, 19);
            this.tbTrueTone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTrueTone.CustomButton.TabIndex = 1;
            this.tbTrueTone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTrueTone.CustomButton.UseSelectable = true;
            this.tbTrueTone.CustomButton.Visible = false;
            this.tbTrueTone.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbTrueTone.Lines = new string[0];
            this.tbTrueTone.Location = new System.Drawing.Point(10, 222);
            this.tbTrueTone.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tbTrueTone.MaxLength = 0;
            this.tbTrueTone.Name = "tbTrueTone";
            this.tbTrueTone.PasswordChar = '\0';
            this.tbTrueTone.PromptText = "TrueToneSN";
            this.tbTrueTone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTrueTone.SelectedText = "";
            this.tbTrueTone.SelectionLength = 0;
            this.tbTrueTone.SelectionStart = 0;
            this.tbTrueTone.ShortcutsEnabled = true;
            this.tbTrueTone.Size = new System.Drawing.Size(832, 25);
            this.tbTrueTone.Style = MetroFramework.MetroColorStyle.Purple;
            this.tbTrueTone.TabIndex = 10;
            this.tbTrueTone.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTrueTone.UseSelectable = true;
            this.tbTrueTone.WaterMark = "TrueToneSN";
            this.tbTrueTone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTrueTone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Enabled = false;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(787, 141);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(55, 21);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "-- / --";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel7
            // 
            this.metroLabel7.Enabled = false;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(10, 141);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(185, 21);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel7.TabIndex = 28;
            this.metroLabel7.Text = "MtSN";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tbMtSN
            // 
            this.tbMtSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
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
            this.tbMtSN.PromptText = "MtSN";
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
            this.tbMtSN.WaterMark = "MtSN";
            this.tbMtSN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMtSN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Enabled = false;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(787, 83);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 21);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "-- / --";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Enabled = false;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(10, 83);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(185, 21);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "GaussSN";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tbGaussSN
            // 
            this.tbGaussSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
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
            this.tbGaussSN.PromptText = "GaussSN";
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
            this.tbGaussSN.WaterMark = "GaussSN";
            this.tbGaussSN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbGaussSN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNumCBSN
            // 
            this.lblNumCBSN.Enabled = false;
            this.lblNumCBSN.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNumCBSN.Location = new System.Drawing.Point(787, 25);
            this.lblNumCBSN.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.lblNumCBSN.Name = "lblNumCBSN";
            this.lblNumCBSN.Size = new System.Drawing.Size(55, 21);
            this.lblNumCBSN.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblNumCBSN.TabIndex = 23;
            this.lblNumCBSN.Text = "-- / --";
            this.lblNumCBSN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNumCBSN.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Enabled = false;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(5, 25);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(185, 21);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "LCMSN";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tbLCMSN
            // 
            this.tbLCMSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
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
            this.tbLCMSN.PromptText = "LCMSN";
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
            this.tbLCMSN.WaterMark = "LCMSN";
            this.tbLCMSN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbLCMSN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbLCMSN.TextChanged += new System.EventHandler(this.tbCoverBoardSN_TextChanged);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(727, 272);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(115, 29);
            this.btnWrite.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnWrite.TabIndex = 12;
            this.btnWrite.Text = "Write";
            this.btnWrite.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnWrite.UseSelectable = true;
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
            this.mtbHexView.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.mtabReadWriteLCM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cbModelType;
        private MetroFramework.Controls.MetroComboBox cbPort;
        private System.IO.Ports.SerialPort serialPortLCM;
        private MetroFramework.Controls.MetroTabControl mtabLCMTabs;
        private MetroFramework.Controls.MetroTabPage mtabReadLCMInfo;
        private MetroFramework.Controls.MetroTabPage mtbHexView;
        private MetroFramework.Controls.MetroTabPage mtabReadWriteLCM;
        private MetroFramework.Controls.MetroLabel lblNumCBSN;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbLCMSN;
        private MetroFramework.Controls.MetroButton btnWrite;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private Be.Windows.Forms.HexBox hexBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton mbtnClose;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbTrueTone;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox tbMtSN;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbGaussSN;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroButton mbtnReadLcmFirmware;
    }
}

