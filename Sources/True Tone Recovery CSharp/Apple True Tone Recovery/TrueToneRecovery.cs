﻿using Apple_True_Tone_Recovery.Properties;
using Be.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
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
        Dictionary<string, List<string>> seriNumaralari = new Dictionary<string, List<string>>
        {
            { "tbLCMSN", new List<string> { "0-56", "1851-2867", "3694-3710", "4608-4629" } },
            { "tbGaussSN", new List<string> { "15104-15129" } },
            { "tbMtSN", new List<string> { "14903-14946" } },
            { "tbTrueToneSN", new List<string> { "16320-16348" } }
        };
        public TrueToneRecovery()
        {
            InitializeComponent();
            PortPreparation();
            ElemetsDefaultValue();



            hexBox1.Dock = DockStyle.Fill; // Formun içini dolduracak şekilde boyutlandırın
            hexBox1.ByteProvider = new DynamicByteProvider(Encoding.ASCII.GetBytes(""));
            hexBox1.ColumnInfoVisible = true;
            hexBox1.LineInfoVisible = true;
            hexBox1.ShadowSelectionVisible = true;
            hexBox1.StringViewVisible = true;
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

        private void mbtnClose_Click(object sender, EventArgs e)
        {
            hexBox1.ByteProvider.DeleteBytes(0, hexBox1.ByteProvider.Length);
            hexBox1.Refresh(); // refresh normal
            //hexBox1.Invalidate();// refresh invoke
            serialPortLCM.Close();
        }

        // Standard Serial Preperations
        private void ButtonCheck()
        {
            if (cbPort.Text == string.Empty ||
                tbLCMSN.Text.Length < Convert.ToInt32(Resources.LIMIT_COVER_BOARD))//need fix
            {
                mbtnWrite.Enabled = false;
            }
            else
            {
                mbtnWrite.Enabled = true;
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
            metroLabel1.Text = "LCMSN: Bu kodun ilk 17 hanesi yanlışsa, bir açılır pencere oluşturabilir ve denetim yazılımı tarafından tanınabilir.\n" +
                "GaussSN: Bu kodun şu an için herhangi bir işlevsel etkisi yok.\n" +
                "MTSN: Bu kod, TrueTone'u etkiler; kaybedilirse, orijinal ekran olmadan Cover Board Serial ile TrueTone onarılabilir.\n" +
                "TrueToneSN: Bu kod, TrueTone'u etkiler; kaybedilirse, orijinal dokunmatik IC (MtSN kodu) verilerini kopyalayabilirsiniz.";
            //tbCoverBoardSN.MaxLength = Convert.ToInt32(Resources.LIMIT_COVER_BOARD);
            //lblCoverBoardSN.Text = string.Format("{0} / {1}", tbCoverBoardSN.Text.Length.ToString(CultureInfo.InvariantCulture), Resources.LIMIT_COVER_BOARD);



        }

        private void ResetForms()
        {
            i = 0;
            //kutuları sıfırla
            hexBox1.ByteProvider.DeleteBytes(0, hexBox1.ByteProvider.Length);
            hexBox1.Refresh(); // refresh normal
        }

        private void SaveChanges()
        {
            //Settings.Default.LAST_VALUE = tbLCMSN.Text;
            //Settings.Default.LAST_VALUE = tbLCMSN.Text;
            //Settings.Default.LAST_VALUE = tbLCMSN.Text;
            //Settings.Default.LAST_VALUE = tbLCMSN.Text;
            //Settings.Default.MODEL_TYPE = cbModelType.Text;
            Settings.Default.Save();
        }

        private string DataPrepare()//veri okunduktan sonra da çağır
        {
            string data = tbMtSN.Text;

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

        private void tbLCMItems_DoubleClick(object sender, EventArgs e)
        {
            //yazı null değilse hexboxda yazının bulunduğu konumu seç ? yada tanımlı adrese göre yazıyı adresten seç hexbota
            List<string> degerler = seriNumaralari.ContainsKey(((MetroTextBox)sender).Name) ? seriNumaralari[((MetroTextBox)sender).Name] : new List<string>();
            foreach (string deger in degerler)
            {
                string[] araliklar = deger.Split('-');
                int start = int.Parse(araliklar[0]);
                int end = int.Parse(araliklar[1]);
                hexBox1.Select(start, end - start + 1);
            }
            mtabLCMTabs.SelectTab(2);
        }

        private void tbLCMItems_TextChanged(object sender, EventArgs e)
        {
            foreach (Control ChildCntl in this.mtabLCMTabs.Controls[1].Controls)
            {
                if (ChildCntl.Name == "lbl" + ((MetroTextBox)sender).Name.Substring(2))
                {
                    ChildCntl.Text = string.Format("{0} / {1}", ((MetroTextBox)sender).Text.Length.ToString(CultureInfo.InvariantCulture), 44);
                }
            }
            ButtonCheck();

            //if (((MetroTextBox)sender).Name == "tbCoverBoardSN")
            //{
            //    foreach (Control ChildCntl in this.mtabLCMTabs.Controls[1].Controls)
            //    {
            //        if (ChildCntl.Name == "lbl" + ((MetroTextBox)sender).Name.Substring(2))
            //        {
            //            ChildCntl.Text = string.Format("{0} / {1}", ((MetroTextBox)sender).Text.Length.ToString(CultureInfo.InvariantCulture), 79);
            //        }
            //    }
            //}
            //else if (((MetroTextBox)sender).Name == "tbGaussSN")
            //{
            //    foreach (Control ChildCntl in this.mtabLCMTabs.Controls[1].Controls)
            //    {
            //        if (ChildCntl.Name == "lbl" + ((MetroTextBox)sender).Name.Substring(2))
            //        {
            //            ChildCntl.Text= string.Format("{0} / {1}", ((MetroTextBox)sender).Text.Length.ToString(CultureInfo.InvariantCulture), 26);
            //        }  
            //    }
            //}
            //else if (((MetroTextBox)sender).Name == "tbMtSN")
            //{
            //    foreach (Control ChildCntl in this.mtabLCMTabs.Controls[1].Controls)
            //    {
            //        if (ChildCntl.Name == "lbl" + ((MetroTextBox)sender).Name.Substring(2))
            //        {
            //            ChildCntl.Text = string.Format("{0} / {1}", ((MetroTextBox)sender).Text.Length.ToString(CultureInfo.InvariantCulture), 0);
            //        }
            //    }
            //}
            //else if (((MetroTextBox)sender).Name == "tbTrueToneSN")
            //{
            //    foreach (Control ChildCntl in this.mtabLCMTabs.Controls[1].Controls)
            //    {
            //        if (ChildCntl.Name == "lbl"+((MetroTextBox)sender).Name.Substring(2))
            //        {
            //            ChildCntl.Text = string.Format("{0} / {1}", ((MetroTextBox)sender).Text.Length.ToString(CultureInfo.InvariantCulture), 28);
            //        }
            //    }
            //}



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
                serialPortLCM.Write(String.Format("{0}-{1}:READINFO!!", "0", "56"));

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
                ResetForms();
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
                    tbMtSN.Text = ReadStringFromProvider(14903, 14947);
                    tbTrueToneSN.Text = ReadStringFromProvider(16320, 16348);
                }


            }
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

        private void mbtnOpenLCMFirmware_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary Files (*.bin)|*.bin|Tüm Dosyalar (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            //openFileDialog.InitialDirectory=Application.StartupPath;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ResetForms();
                try
                {
                    string kaynakDosyaYolu = openFileDialog.FileName;
                    byte[] okunanBaytlar;

                    // Dosyayı açın ve baytları okuyun
                    using (FileStream kaynakDosya = File.OpenRead(kaynakDosyaYolu))
                    {
                        okunanBaytlar = new byte[kaynakDosya.Length];
                        kaynakDosya.Read(okunanBaytlar, 0, (int)kaynakDosya.Length);
                    }
                    hexBox1.ByteProvider.InsertBytes(0, okunanBaytlar);
                    //8
                    tbLCMSN.Text = ReadStringFromProvider(0, 57) + ReadStringFromProvider(4608, 4630);
                    tbGaussSN.Text = ReadStringFromProvider(15104, 15130);
                    tbMtSN.Text = ReadStringFromProvider(14903, 14947);
                    tbTrueToneSN.Text = ReadStringFromProvider(16320, 16348);
                    //x
                    tbLCMSN.Text = ReadStringFromProvider(9113, 9248);
                    tbGaussSN.Text = ReadStringFromProvider(15756, 15782);
                    tbMtSN.Text = ReadStringFromProvider(15664, 15704);
                    tbTrueToneSN.Text = ReadStringFromProvider(16320, 16348);

                    //// Kaydedilecek dosyanın yolunu belirleyin
                    //SaveFileDialog saveFileDialog = new SaveFileDialog();
                    //saveFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
                    //saveFileDialog.FilterIndex = 1;
                    //saveFileDialog.RestoreDirectory = true;

                    //if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    //{
                    //    string hedefDosyaYolu = saveFileDialog.FileName;

                    //    // Okunan baytları yeni dosyaya kaydedin
                    //    using (FileStream hedefDosya = File.Create(hedefDosyaYolu))
                    //    {
                    //        hedefDosya.Write(okunanBaytlar, 0, okunanBaytlar.Length);
                    //    }

                    //    Console.WriteLine("Dosya başarıyla kopyalandı.");
                    //}
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }
        }

        private void mbtnWrite_Click(object sender, EventArgs e)
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
    }
}
