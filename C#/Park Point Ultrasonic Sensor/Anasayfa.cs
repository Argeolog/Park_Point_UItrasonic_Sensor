using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Park_Point_Ultrasonic_Sensor
{
    public partial class Anasayfa : Form
    {
        private bool CihazAraAktif;
        private string TarananID = "";

        public Anasayfa()
        {
            InitializeComponent();
        }


        
        public bool Seriport_Ayarlandi()
        {
            TarananID = "";
            if (Comport_Combo.Text == "") return false;
            if (SerialPortx.IsOpen) return true;



   

            try
            {
                SerialPortx.Close();
                SerialPortx.BaudRate = 38400;
                SerialPortx.Parity = System.IO.Ports.Parity.None;
                SerialPortx.StopBits = System.IO.Ports.StopBits.One;
                SerialPortx.DataBits = 8;
                SerialPortx.PortName = Comport_Combo.Text;
                SerialPortx.Open();
                Portu_Ac_Buton.Text = "Kapat";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }


        private void Anasayfa_Load(object sender, EventArgs e)
        {
            Comport_Combo.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (Comport_Combo.Items.Count > 0)
                Comport_Combo.SelectedIndex = Comport_Combo.Items.Count - 1;// Sonuncu Olur genelde...
        }

        private void Yenile_Buton_Click(object sender, EventArgs e)
        {
            Comport_Combo.Items.Clear();
            Comport_Combo.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            Comport_Combo.SelectedIndex = -1;
            if (Comport_Combo.Items.Count > 0)
                Comport_Combo.SelectedIndex = Comport_Combo.Items.Count - 1;// Sonuncu Olur genelde...
        }


        public void GelenData(string Data)
        {
            try
            {
                if ((Data.Length > 5) && (Data.IndexOf(Convert.ToChar(13)) > -1))
                {
                    string Sperator = Data.Substring(0, 1);
                    int CihazID =Convert.ToInt32(Data.Substring(3, 3));
                    string Komut = Data.Substring(1, 2);
                    Cihaz_ID_Text.Value = CihazID;

                    if (Sperator == "#")
                    {
                        if (Komut == "DS")
                        {
                            Yeni_Cihaz_ID_Text.Value = CihazID;

                            Min_Algilama_Mesafe_Text.Value = Convert.ToInt32(Data.Substring(6, 3));
                            Max_Algilama_Mesafe_Text.Value = Convert.ToInt32(Data.Substring(9, 3));
                            Kirmizi_Yakma_Text.Value = Convert.ToInt32(Data.Substring(12, 2));
                            Yesile_Donme_Text.Value = Convert.ToInt32(Data.Substring(14, 2));
                            Sensor_Durumu_Setle(Convert.ToInt32(Data.Substring(16, 1)));
                            string Versionx = Data.Substring(18, 5);
                            string[] Arr = Versionx.Split(Convert.ToChar("."));
                            Donanim_Versiyon_Label.Text = Convert.ToInt32(Arr[0]) + "." + Convert.ToInt32(Arr[1]);
                            Cihaz_Ara_Buton.Text = "Cihaz Ara";
                            MessageBox.Show("Bulunan Cihaz ID: " + CihazID);
                        }
                        else if (Komut == "SM")
                        {
                            Olculen_Mesafe_Text.Text = Convert.ToString(Data.Substring(6, 3)) + " cm";
                            Sensor_Durumu_Setle(Convert.ToInt32(Data.Substring(9, 1)));
                        }
                        else if (Komut == "SS")
                            Sensor_Durumu_Setle(Convert.ToInt32(Data.Substring(6, 1)));
                    }
                    else if (Sperator == "%")
                    {
                        if (Data.IndexOf("E") > -1)
                            MessageBox.Show("Hata İşlem Başarısız !","Hata !",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        else
                           
                        MessageBox.Show("İşlem Başarılı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }






        public void Sensor_Durumu_Setle(int SensorDurumu)
        {
            if (SensorDurumu == 0)
                Sensor_Rengi_Picturebox.BackColor = Color.SpringGreen;
            else
                Sensor_Rengi_Picturebox.BackColor = Color.Tomato;
        }

        int ID;
        private void Cihaz_Ara_Buton_Click(object sender, EventArgs e)
        {
            if (CihazAraAktif == false)
            {
                if (Seriport_Ayarlandi())
                {
                    Cihaz_Ara_Timer.Start();
                    CihazAraAktif = true;
                    Cihaz_Ara_Buton.Text = "Durdur";
                }
            }
            else
            {
                CihazAraAktif = false;
                Cihaz_Ara_Timer.Stop();
                Cihaz_Ara_Buton.Text = "Cihaz Ara";
            }
        }

        private void Cihaz_Ara_Timer_Tick(object sender, EventArgs e)
        {
            Application.DoEvents();

            if (TarananID == "")
            {
                ID =Convert.ToInt32(Cihaz_ID_Text.Value);
                TarananID = ID.ToString();
            }
            Taranan_ID_Text.Text = ID.ToString();

            string Str = "$DS" + ID.ToString().PadLeft(3,Convert.ToChar("0")) + "**" + Convert.ToChar(13);
            SerialPortx.Write(Str);

            ID += 1;
            if (ID >= 1000)
            {
                Taranan_ID_Text.Text = "999";
                Cihaz_Ara_Timer.Stop();
                TarananID = "";
                CihazAraAktif = false;
            }
        }

        private void SerialPortx_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(50);
            TarananID = "";
            CihazAraAktif = false;
            Cihaz_Ara_Timer.Stop();
            Invoke(new Action(() => GelenData(SerialPortx.ReadExisting())));
        }

        private void Cihaz_ID_Degistir_Buton_Click(object sender, EventArgs e)
        {
            if (CihazAraAktif == false)
            {
                if (Seriport_Ayarlandi())
                {
                    string Komut = "$DN";
                    string EskiID = Cihaz_ID_Text.Value.ToString().PadLeft(3,Convert.ToChar("0"));
                    string YeniID = Yeni_Cihaz_ID_Text.Value.ToString().PadLeft(3, Convert.ToChar("0"));
                    string GonderilecekKomut = Komut + EskiID + YeniID + "**" + Convert.ToChar(13);
                    SerialPortx.Write(GonderilecekKomut);
                }
            }
        }

        private void Mesafe_Olc_Buton_Click(object sender, EventArgs e)
        {
            if (CihazAraAktif == false)
            {
                if (Seriport_Ayarlandi())
                {
                    string Komut = "$SM";
                    string CihazID = Cihaz_ID_Text.Value.ToString().PadLeft(3, Convert.ToChar("0"));
                    string GonderilecekKomut = Komut + CihazID + "**" + Convert.ToChar(13);
                    SerialPortx.Write(GonderilecekKomut);
                }
            }
        }

        private void Sensor_Algilama_Mesafe_Ayarla_Buton_Click(object sender, EventArgs e)
        {
            if (CihazAraAktif == false)
            {
                if (Seriport_Ayarlandi())
                {
                    string Komut = "$SD";
                    string CihazID = Cihaz_ID_Text.Value.ToString().PadLeft(3, Convert.ToChar("0"));
                    string MinAlgilama = Min_Algilama_Mesafe_Text.Value.ToString().PadLeft(3, Convert.ToChar("0"));
                    string MaxAlgilama = Max_Algilama_Mesafe_Text.Value.ToString().PadLeft(3, Convert.ToChar("0"));
                    string GonderilecekKomut = Komut + CihazID + MinAlgilama + MaxAlgilama + "**" + Convert.ToChar(13);
                    SerialPortx.Write(GonderilecekKomut);
                }
            }
        }

        private void Led_Durum_Degistirme_Sureleri_Buton_Click(object sender, EventArgs e)
        {
            if (CihazAraAktif == false)
            {
                if (Seriport_Ayarlandi())
                {
                    string Komut = "$SL";
                    string CihazID = Cihaz_ID_Text.Value.ToString().PadLeft(3, Convert.ToChar("0"));
                    string KirmiziYakmaSuresi = Kirmizi_Yakma_Text.Value.ToString().PadLeft(2, Convert.ToChar("0"));
                    string YesileDonmeSuresi = Yesile_Donme_Text.Value.ToString().PadLeft(2, Convert.ToChar("0"));
                    string GonderilecekKomut = Komut + CihazID + KirmiziYakmaSuresi + YesileDonmeSuresi + "**" + Convert.ToChar(13);
                    SerialPortx.Write(GonderilecekKomut);
                }
            }
        }

        private void Led_Durum_Ogren_Buton_Click(object sender, EventArgs e)
        {
            if (CihazAraAktif == false)
            {
                if (Seriport_Ayarlandi())
                {
                    string Komut = "$SS";
                    string CihazID = Cihaz_ID_Text.Value.ToString().PadLeft(3, Convert.ToChar("0"));
                    string GonderilecekKomut = Komut + CihazID + "**" + Convert.ToChar(13);
                    SerialPortx.Write(GonderilecekKomut);
                }
            }
        }

        private void Portu_Ac_Buton_Click(object sender, EventArgs e)
        {

            if (Portu_Ac_Buton.Text == "Kapat") {

                Portu_Ac_Buton.Text = "Aç";
            SerialPortx.Close();
            }
           
           else
            {
                Seriport_Ayarlandi();
            }
            
      


        }
    }
}
