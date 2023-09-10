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
            hexBox1.ByteProvider = new DynamicByteProvider(Encoding.ASCII.GetBytes(""));
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
                tbLCMSN.Text.Length < Convert.ToInt32(Resources.LIMIT_COVER_BOARD))
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
            Icon = Resources.TrueToneRecovery;

            cbModelType.Items.AddRange(new object[] {
            Resources.TEXT_8_8P,
            Resources.TEXT_XR,
            Resources.TEXT_X_XS_XSM});

            cbModelType.Text = Settings.Default.MODEL_TYPE;
            serialPortLCM.BaudRate = Settings.Default.SERIAL_BAUDRATE;
            tbLCMSN.Text = Settings.Default.LAST_VALUE;
            tbLCMSN.MaxLength = Convert.ToInt32(Resources.LIMIT_COVER_BOARD);
            lblNumCBSN.Text = string.Format("{0} / {1}", tbLCMSN.Text.Length.ToString(CultureInfo.InvariantCulture), Resources.LIMIT_COVER_BOARD);



        }

        private void SaveChanges()
        {
            Settings.Default.LAST_VALUE = tbLCMSN.Text;
            Settings.Default.MODEL_TYPE = cbModelType.Text;
            Settings.Default.Save();
        }

        private string DataPrepare()//veri okunduktan sonra da çağır
        {
            string data = tbLCMSN.Text;

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
            lblNumCBSN.Text = string.Format("{0} / {1}", tbLCMSN.Text.Length.ToString(CultureInfo.InvariantCulture), Resources.LIMIT_COVER_BOARD);
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
                hexBox1.ByteProvider.DeleteBytes(0, hexBox1.ByteProvider.Length);
                hexBox1.Refresh(); // refresh normal
                serialPortLCM.PortName = Convert.ToString(cbPort.Text);
                serialPortLCM.Open();
                serialPortLCM.Write($"{"var"}-{"var"}:READINFO!!");
                serialPortLCM.Write(String.Format("{0}-{1}:READINFO!!","0","56"));

            }
            catch (Exception ex)
            {
                serialPortLCM.Close();
                MetroMessageBox.Show(this,
                    Messages.ERROR_WRONG_COMMAND + " :" + ex.Message,
                    Messages.ERROR,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void mbtnReadLcmFirmware_Click(object sender, EventArgs e)
        {
            try
            {
                i = 0;
                //kutuları sıfırla
                hexBox1.ByteProvider.DeleteBytes(0, hexBox1.ByteProvider.Length);
                hexBox1.Refresh(); // refresh normal

                serialPortLCM.PortName = Convert.ToString(cbPort.Text);
                serialPortLCM.Open();
                serialPortLCM.Write("DUMP!!");

            }
            catch (Exception ex)
            {
                serialPortLCM.Close();
                MetroMessageBox.Show(this,
                    Messages.ERROR_WRONG_COMMAND + " :" + ex.Message,
                    Messages.ERROR,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Standard Serial Preperations
        private delegate void ReceivedEvent(byte[] data);
        private void serialPortLCM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytesRead = serialPortLCM.BytesToRead;
            byte[] buffer = new byte[bytesRead];
            serialPortLCM.Read(buffer, 0, bytesRead);

            // Verileri doğrudan DataProcessing metoduna gönderin
            BeginInvoke(new ReceivedEvent(DataProcessing), buffer);

        }
        int i = 0;
        private void DataProcessing(byte[] receivedData)
        {

            try
            {
                hexBox1.ByteProvider.InsertBytes(i, receivedData);
                hexBox1.Invalidate();// refresh invoke
                i = i + receivedData.Length;
                metroProgressBar1.Value = i;

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this,
                    Messages.DATA_TYPE + " :" + ex.Message,
                    Messages.ERROR,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (hexBox1.ByteProvider.Length >= 16383)
                {
                    //need fix
                    serialPortLCM.Close();
                    tbLCMSN.Text = ReadStringFromProvider(0, 57) + ReadStringFromProvider(4608, 4630);
                    tbGaussSN.Text = ReadStringFromProvider(15104, 15130);
                    tbMtSN.Text = ReadStringFromProvider(16384, 16432);
                    tbTrueTone.Text = ReadStringFromProvider(16320, 16348);
                }


            }
        }

        private void mbtnClose_Click(object sender, EventArgs e)
        {
            hexBox1.ByteProvider.DeleteBytes(0, hexBox1.ByteProvider.Length);
            hexBox1.Refresh(); // refresh normal
            //hexBox1.Invalidate();// refresh invoke
            serialPortLCM.Close();
        }
        public string ReadStringFromProvider(int startOffset, int endOffset)
        {
            if (startOffset >= 0 && endOffset <= hexBox1.ByteProvider.Length)
            {
                byte[] selectedData = new byte[endOffset - startOffset];

                // Belirli bir adres aralığındaki verileri okuma
                for (long address = startOffset, i = 0; address < endOffset; address++, i++)
                {
                    selectedData[i] = hexBox1.ByteProvider.ReadByte(address);
                }

                // Okunan veriyi kullanabilirsiniz
                string asciiData = System.Text.Encoding.ASCII.GetString(selectedData);
                return asciiData;

                // Dışa aktarma işlemlerini burada devam ettirebilirsiniz.
            }
            else
            {
                return null;
            }
        }


    }
}
