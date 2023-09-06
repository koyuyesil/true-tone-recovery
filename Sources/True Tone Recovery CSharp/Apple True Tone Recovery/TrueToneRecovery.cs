using Apple_True_Tone_Recovery.Properties;
using Be.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Globalization;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using static MetroFramework.Drawing.MetroPaint.BackColor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/**
 * Apple True Tone Recovery
 * 
 * Приложение формирует и отправляет в serial port пакет из байт серийного номера mtSN (Cover Board Number)
 * 
 * Copyright (C) 2020. v1.0 / Скляр Роман S-LAB
 * BUILD IN Microsoft Visual Studio Professional 2019 v16.6.2
 * .NET framework 4.8
 * 
*/

namespace Apple_True_Tone_Recovery
{
    public partial class TrueToneRecovery : MetroForm
    {
        public TrueToneRecovery()
        {
            InitializeComponent();
            PortPreparation();
            ElemetsDefaultValue();
            hexBox1.Dock = DockStyle.Fill; // Formun içini dolduracak şekilde boyutlandırın
            hexBox1.ByteProvider= new DynamicByteProvider(Encoding.ASCII.GetBytes(""));
            hexBox1.Show();
        }

        // Standard Serial Preperations
        private void PortPreparation()
        {
            string[] ports = SerialPort.GetPortNames();
            cbPort.Items.Clear();
            cbPort.Items.AddRange(ports);
            cbPort.SelectedIndex = (ports.Length != 0) ? 0 : -1;
            ButtonCheck();
            //sender eklenebilir orneğin basılan tuşa gore scope edilerek gelinir hangi tuştan basılırsa onu bloke eder nasıl ama? typecasting ile ledbulb örneğine bak!
        }
        // Standard Serial Preperations
        private void ButtonCheck()
        {
            if (cbPort.Text == string.Empty ||
                tbCoverBoardSN.Text.Length < Convert.ToInt32(Resources.LIMIT_COVER_BOARD))
            {
                btnWrite.Enabled = false;
            }
            else
            {
                btnWrite.Enabled = true;
            }
        }

        private void ElemetsDefaultValue()
        {
            cbModelType.Items.AddRange(new object[] {
            Resources.TEXT_8_8P,
            Resources.TEXT_XR,
            Resources.TEXT_X_XS_XSM});
            tbCoverBoardSN.Text = Settings.Default.LAST_VALUE;
            tbCoverBoardSN.MaxLength = Convert.ToInt32(Resources.LIMIT_COVER_BOARD);
            lblNumCBSN.Text = string.Format(Resources.FORMAT_LABLE + Resources.LIMIT_COVER_BOARD, tbCoverBoardSN.Text.Length.ToString(CultureInfo.InvariantCulture));
            cbModelType.Text = Settings.Default.MODEL_TYPE;
            serialPortLCM.BaudRate = Settings.Default.SERIAL_BAUDRATE;
            Icon = Resources.TrueToneRecovery;
        }

        private void SaveChanges()
        {
            Settings.Default.LAST_VALUE = tbCoverBoardSN.Text;
            Settings.Default.MODEL_TYPE = cbModelType.Text;
            Settings.Default.Save();
        }

        private string DataPrepare()
        {
            string data = tbCoverBoardSN.Text;

            if (cbModelType.Text == Resources.TEXT_8_8P)
            {
                data += Settings.Default.KEY_8_8P; //xxxxxxxxxxxxxxxxx+yyyyyyyyyyyyyyyyyyyyyyyyyyA
            }
            else if (cbModelType.Text == Resources.TEXT_XR)
            {
                data += Settings.Default.KEY_XR; //xxxxxxxxxxxxxxxxx+yyyyyyyyyyyyyyyyyyyyyyyyyyB
            }
            else if (cbModelType.Text == Resources.TEXT_X_XS_XSM)
            {
                data += Settings.Default.KEY_X_XS_XSM; //xxxxxxxxxxxxxxxxx+yyyyyyyyyyyyyyyyyyyyyyyyyyC
            }

            return data;
        }


        private void TrueToneRecovery_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveChanges();
        }

        private void cbPort_MouseClick(object sender, MouseEventArgs e)
        {
            PortPreparation();
        }

        private void tbCoverBoardSN_TextChanged(object sender, EventArgs e)
        {
            //Textbox char count example ==> 44/44 
            lblNumCBSN.Text = string.Format(Resources.FORMAT_LABLE + Resources.LIMIT_COVER_BOARD, tbCoverBoardSN.Text.Length.ToString(CultureInfo.InvariantCulture));
            ButtonCheck();
        }


        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                serialPortLCM.PortName = Convert.ToString(cbPort.Text);
                serialPortLCM.Open();
                serialPortLCM.Write(DataPrepare());
                serialPortLCM.Close();
            }
            catch
            {
                serialPortLCM.Close();
                MetroMessageBox.Show(this,
                    Messages.ERROR_RELATION,
                    Messages.ERROR,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void mbtnReadLcmInfo_Click(object sender, EventArgs e)
        {
            try
            {
                i = 0;
                serialPortLCM.PortName = Convert.ToString(cbPort.Text);
                serialPortLCM.Open();
                var send = "A";
                serialPortLCM.WriteLine(send);

            }
            catch (Exception ex)
            { 
                serialPortLCM.Close();
                MetroMessageBox.Show(this,
                    Messages.ERROR_WRONG_COMMAND+" :"+ex.Message,
                    Messages.ERROR,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        // Standard Serial Preperations
        private delegate void ReceivedEvent(string data);
        private void serialPortLCM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            BeginInvoke(new ReceivedEvent(DataProcessing), serialPortLCM.ReadExisting());
            //serialPortLCM.Close();
        }
        int i=0;
        private void DataProcessing(string receivedData)
        {

            try
            {
                metroTextBox1.Text += receivedData;
                hexBox1.ByteProvider.InsertBytes(i, Encoding.ASCII.GetBytes(receivedData));
                hexBox1.Invalidate();
                i++;
                //metroTextBox1.Text=i.ToString();
                metroProgressBar1.Value = i;
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this,
                    Messages.DATA_TYPE + " :" + ex.Message,
                    Messages.ERROR,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}
