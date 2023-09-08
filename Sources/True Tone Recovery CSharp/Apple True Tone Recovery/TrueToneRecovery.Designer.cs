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
            this.mtabReadFromLCM = new MetroFramework.Controls.MetroTabControl();
            this.mtabReadInfoLCM = new MetroFramework.Controls.MetroTabPage();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.hexBox1 = new Be.Windows.Forms.HexBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.mbtnReadLcmFirmware = new MetroFramework.Controls.MetroButton();
            this.mtabWriteToLCM = new MetroFramework.Controls.MetroTabPage();
            this.lblNumCBSN = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbCoverBoardSN = new MetroFramework.Controls.MetroTextBox();
            this.btnWrite = new MetroFramework.Controls.MetroButton();
            this.mbtnClose = new MetroFramework.Controls.MetroButton();
            this.mtabReadFromLCM.SuspendLayout();
            this.mtabReadInfoLCM.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.mtabWriteToLCM.SuspendLayout();
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
            // mtabReadFromLCM
            // 
            this.mtabReadFromLCM.Controls.Add(this.mtabReadInfoLCM);
            this.mtabReadFromLCM.Controls.Add(this.metroTabPage1);
            this.mtabReadFromLCM.Controls.Add(this.mtabWriteToLCM);
            this.mtabReadFromLCM.Location = new System.Drawing.Point(13, 107);
            this.mtabReadFromLCM.Name = "mtabReadFromLCM";
            this.mtabReadFromLCM.SelectedIndex = 2;
            this.mtabReadFromLCM.Size = new System.Drawing.Size(855, 647);
            this.mtabReadFromLCM.TabIndex = 14;
            this.mtabReadFromLCM.UseSelectable = true;
            // 
            // mtabReadInfoLCM
            // 
            this.mtabReadInfoLCM.Controls.Add(this.metroTextBox1);
            this.mtabReadInfoLCM.Controls.Add(this.metroButton1);
            this.mtabReadInfoLCM.HorizontalScrollbarBarColor = true;
            this.mtabReadInfoLCM.HorizontalScrollbarHighlightOnWheel = false;
            this.mtabReadInfoLCM.HorizontalScrollbarSize = 2;
            this.mtabReadInfoLCM.Location = new System.Drawing.Point(4, 38);
            this.mtabReadInfoLCM.Name = "mtabReadInfoLCM";
            this.mtabReadInfoLCM.Size = new System.Drawing.Size(847, 605);
            this.mtabReadInfoLCM.TabIndex = 0;
            this.mtabReadInfoLCM.Text = "Read Info LCM";
            this.mtabReadInfoLCM.VerticalScrollbarBarColor = true;
            this.mtabReadInfoLCM.VerticalScrollbarHighlightOnWheel = false;
            this.mtabReadInfoLCM.VerticalScrollbarSize = 2;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(538, 2);
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
            this.metroButton1.TabIndex = 21;
            this.metroButton1.Text = "Read LCM Info";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.Controls.Add(this.metroProgressBar1);
            this.metroTabPage1.Controls.Add(this.mbtnReadLcmFirmware);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 2;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(847, 605);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Read from LCM";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 2;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.hexBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 8;
            this.metroPanel1.Location = new System.Drawing.Point(3, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(841, 542);
            this.metroPanel1.TabIndex = 26;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 8;
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
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(3, 25);
            this.metroProgressBar1.Maximum = 4000;
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(715, 29);
            this.metroProgressBar1.TabIndex = 25;
            // 
            // mbtnReadLcmFirmware
            // 
            this.mbtnReadLcmFirmware.Location = new System.Drawing.Point(726, 25);
            this.mbtnReadLcmFirmware.Margin = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.mbtnReadLcmFirmware.Name = "mbtnReadLcmFirmware";
            this.mbtnReadLcmFirmware.Size = new System.Drawing.Size(115, 30);
            this.mbtnReadLcmFirmware.Style = MetroFramework.MetroColorStyle.Purple;
            this.mbtnReadLcmFirmware.TabIndex = 24;
            this.mbtnReadLcmFirmware.Text = "Read LCM Firmware";
            this.mbtnReadLcmFirmware.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mbtnReadLcmFirmware.UseSelectable = true;
            this.mbtnReadLcmFirmware.Click += new System.EventHandler(this.mbtnReadLcmInfo_Click);
            // 
            // mtabWriteToLCM
            // 
            this.mtabWriteToLCM.Controls.Add(this.lblNumCBSN);
            this.mtabWriteToLCM.Controls.Add(this.metroLabel1);
            this.mtabWriteToLCM.Controls.Add(this.tbCoverBoardSN);
            this.mtabWriteToLCM.Controls.Add(this.btnWrite);
            this.mtabWriteToLCM.HorizontalScrollbarBarColor = true;
            this.mtabWriteToLCM.HorizontalScrollbarHighlightOnWheel = false;
            this.mtabWriteToLCM.HorizontalScrollbarSize = 2;
            this.mtabWriteToLCM.Location = new System.Drawing.Point(4, 38);
            this.mtabWriteToLCM.Name = "mtabWriteToLCM";
            this.mtabWriteToLCM.Size = new System.Drawing.Size(847, 605);
            this.mtabWriteToLCM.TabIndex = 2;
            this.mtabWriteToLCM.Text = "Write to LCM";
            this.mtabWriteToLCM.VerticalScrollbarBarColor = true;
            this.mtabWriteToLCM.VerticalScrollbarHighlightOnWheel = false;
            this.mtabWriteToLCM.VerticalScrollbarSize = 2;
            // 
            // lblNumCBSN
            // 
            this.lblNumCBSN.Enabled = false;
            this.lblNumCBSN.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNumCBSN.Location = new System.Drawing.Point(335, 25);
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
            this.metroLabel1.Text = "Cover Board Serial Number";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tbCoverBoardSN
            // 
            this.tbCoverBoardSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.tbCoverBoardSN.CustomButton.Image = null;
            this.tbCoverBoardSN.CustomButton.Location = new System.Drawing.Point(267, 1);
            this.tbCoverBoardSN.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tbCoverBoardSN.CustomButton.Name = "";
            this.tbCoverBoardSN.CustomButton.Size = new System.Drawing.Size(17, 19);
            this.tbCoverBoardSN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCoverBoardSN.CustomButton.TabIndex = 1;
            this.tbCoverBoardSN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCoverBoardSN.CustomButton.UseSelectable = true;
            this.tbCoverBoardSN.CustomButton.Visible = false;
            this.tbCoverBoardSN.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbCoverBoardSN.Lines = new string[0];
            this.tbCoverBoardSN.Location = new System.Drawing.Point(10, 48);
            this.tbCoverBoardSN.Margin = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tbCoverBoardSN.MaxLength = 0;
            this.tbCoverBoardSN.Name = "tbCoverBoardSN";
            this.tbCoverBoardSN.PasswordChar = '\0';
            this.tbCoverBoardSN.PromptText = "Cover Board SN";
            this.tbCoverBoardSN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCoverBoardSN.SelectedText = "";
            this.tbCoverBoardSN.SelectionLength = 0;
            this.tbCoverBoardSN.SelectionStart = 0;
            this.tbCoverBoardSN.ShortcutsEnabled = true;
            this.tbCoverBoardSN.Size = new System.Drawing.Size(380, 25);
            this.tbCoverBoardSN.Style = MetroFramework.MetroColorStyle.Purple;
            this.tbCoverBoardSN.TabIndex = 21;
            this.tbCoverBoardSN.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCoverBoardSN.UseSelectable = true;
            this.tbCoverBoardSN.WaterMark = "Cover Board SN";
            this.tbCoverBoardSN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCoverBoardSN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbCoverBoardSN.TextChanged += new System.EventHandler(this.tbCoverBoardSN_TextChanged);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(275, 80);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(115, 29);
            this.btnWrite.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnWrite.TabIndex = 20;
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
            this.mbtnClose.TabIndex = 21;
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
            this.Controls.Add(this.mtabReadFromLCM);
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
            this.mtabReadFromLCM.ResumeLayout(false);
            this.mtabReadInfoLCM.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.mtabWriteToLCM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cbModelType;
        private MetroFramework.Controls.MetroComboBox cbPort;
        private System.IO.Ports.SerialPort serialPortLCM;
        private MetroFramework.Controls.MetroTabControl mtabReadFromLCM;
        private MetroFramework.Controls.MetroTabPage mtabReadInfoLCM;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage mtabWriteToLCM;
        private MetroFramework.Controls.MetroLabel lblNumCBSN;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbCoverBoardSN;
        private MetroFramework.Controls.MetroButton btnWrite;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton mbtnReadLcmFirmware;
        private Be.Windows.Forms.HexBox hexBox1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton mbtnClose;
    }
}

