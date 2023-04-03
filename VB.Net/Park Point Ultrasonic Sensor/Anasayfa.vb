Imports System.Security

Public Class Anasayfa
    Dim CihazAraAktif As Boolean
    Dim TarananID As String = ""
    Function Seriport_Ayarlandi() As Boolean
        TarananID = ""
        If Comport_Combo.Text = "" Then
            Return False
        End If
        If SerialPortx.IsOpen Then
            Return True
        End If


        Try

            SerialPortx.Close()
            SerialPortx.BaudRate = 38400
            SerialPortx.Parity = IO.Ports.Parity.None
            SerialPortx.StopBits = IO.Ports.StopBits.One
            SerialPortx.DataBits = 8
            SerialPortx.PortName = Comport_Combo.Text
            SerialPortx.Open()
            Portu_Ac_Buton.Text = "Kapat"
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return False
    End Function



    Private Sub Anasayfa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Comport_Combo.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames)
        If Comport_Combo.Items.Count > 0 Then
            Comport_Combo.SelectedIndex = Comport_Combo.Items.Count - 1 ' Sonuncu Olur genelde...
        End If
    End Sub

    Private Sub Yenile_Buton_Click(sender As Object, e As EventArgs) Handles Yenile_Buton.Click
        Comport_Combo.Items.Clear()
        Comport_Combo.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames)
        Comport_Combo.SelectedIndex = -1
        If Comport_Combo.Items.Count > 0 Then
            Comport_Combo.SelectedIndex = Comport_Combo.Items.Count - 1 ' Sonuncu Olur genelde...
        End If
    End Sub

    Sub GelenData(ByVal Data As String)
        Try

            If Data.Length > 5 AndAlso Data.IndexOf(Chr(13)) > -1 Then

                Dim Sperator As String = Data.Substring(0, 1)
                Dim CihazID As Integer = Data.Substring(3, 3)
                Dim Komut As String = Data.Substring(1, 2)
                Cihaz_ID_Text.Value = CihazID

                If Sperator = "#" Then

                    If Komut = "DS" Then ' Device Source
                        Yeni_Cihaz_ID_Text.Value = CihazID

                        Min_Algilama_Mesafe_Text.Value = CInt(Data.Substring(6, 3))
                        Max_Algilama_Mesafe_Text.Value = CInt(Data.Substring(9, 3))
                        Kirmizi_Yakma_Text.Value = CInt(Data.Substring(12, 2))
                        Yesile_Donme_Text.Value = CInt(Data.Substring(14, 2))
                        Sensor_Durumu_Setle(CInt(Data.Substring(16, 1)))
                        Dim Versionx As String = Data.Substring(18, 5)
                        Dim Arr() As String = Versionx.Split(".")
                        Donanim_Versiyon_Label.Text = CInt(Arr(0)) & "." & CInt(Arr(1))
                        Cihaz_Ara_Buton.Text = "Cihaz Ara"
                        MsgBox("Bulunan Cihaz ID: " & CihazID)

                    ElseIf Komut = "SM" Then
                        Olculen_Mesafe_Text.Text = CInt(Data.Substring(6, 3)) & " cm"
                        Sensor_Durumu_Setle(CInt(Data.Substring(9, 1)))

                    ElseIf Komut = "SS" Then
                        Sensor_Durumu_Setle(CInt(Data.Substring(6, 1)))

                    End If





                ElseIf Sperator = "%" Then

                    If Data.IndexOf("E") > -1 Then
                        MsgBox("Hata İşlem Başarısız !", 16, "Hata")
                    Else
                        MsgBox("İşlem Başarılı !", 64, "Bilgi")
                    End If





                End If

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Cihaz_Ara_Buton_Click(sender As Object, e As EventArgs) Handles Cihaz_Ara_Buton.Click
        If CihazAraAktif = False Then
            If Seriport_Ayarlandi() Then
                Cihaz_Ara_Timer.Start()
                CihazAraAktif = True
                Cihaz_Ara_Buton.Text = "Durdur"

            End If
        Else
            CihazAraAktif = False
            Cihaz_Ara_Timer.Stop()
            Cihaz_Ara_Buton.Text = "Cihaz Ara"
        End If



    End Sub



    Sub Sensor_Durumu_Setle(ByVal SensorDurumu As Integer)
        If SensorDurumu = 0 Then
            Sensor_Rengi_Picturebox.BackColor = Color.SpringGreen
        Else
            Sensor_Rengi_Picturebox.BackColor = Color.Tomato
        End If
    End Sub
    Dim ID As Integer
    Private Sub Cihaz_Ara_Timer_Tick(sender As Object, e As EventArgs) Handles Cihaz_Ara_Timer.Tick
        Application.DoEvents()

        If TarananID = "" Then
            ID = Cihaz_ID_Text.Value
            TarananID = ID
        End If
        Taranan_ID_Text.Text = ID.ToString

        Dim Str As String = "$DS" & ID.ToString.PadLeft(3, "0") & "**" & Chr(13)
        SerialPortx.Write(Str)

        ID += 1
        If ID >= 1000 Then
            Taranan_ID_Text.Text = "999"
            Cihaz_Ara_Timer.Stop()
            TarananID = ""
            CihazAraAktif = False
            Cihaz_Ara_Buton.Text = "Cihaz Ara"
        End If

    End Sub

    Private Sub SerialPortx_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPortx.DataReceived
        System.Threading.Thread.Sleep(50)
        TarananID = ""
        CihazAraAktif = False
        Cihaz_Ara_Timer.Stop()
        Me.Invoke(Sub() GelenData(SerialPortx.ReadExisting))

    End Sub

    Private Sub Cihaz_ID_Degistir_Buton_Click(sender As Object, e As EventArgs) Handles Cihaz_ID_Degistir_Buton.Click

        If CihazAraAktif = False Then
            If Seriport_Ayarlandi() Then
                Dim Komut As String = "$DN"
                Dim EskiID As String = Cihaz_ID_Text.Value.ToString.PadLeft(3, "0")
                Dim YeniID As String = Yeni_Cihaz_ID_Text.Value.ToString.PadLeft(3, "0")
                Dim GonderilecekKomut As String = Komut & EskiID & YeniID & "**" & Chr(13)
                SerialPortx.Write(GonderilecekKomut)


            End If
        End If



    End Sub

    Private Sub Mesafe_Olc_Buton_Click(sender As Object, e As EventArgs) Handles Mesafe_Olc_Buton.Click
        If CihazAraAktif = False Then
            If Seriport_Ayarlandi() Then
                Dim Komut As String = "$SM"
                Dim CihazID As String = Cihaz_ID_Text.Value.ToString.PadLeft(3, "0")
                Dim GonderilecekKomut As String = Komut & CihazID & "**" & Chr(13)
                SerialPortx.Write(GonderilecekKomut)
            End If
        End If
    End Sub

    Private Sub Sensor_Algilama_Mesafe_Ayarla_Buton_Click(sender As Object, e As EventArgs) Handles Sensor_Algilama_Mesafe_Ayarla_Buton.Click
        If CihazAraAktif = False Then
            If Seriport_Ayarlandi() Then
                Dim Komut As String = "$SD"
                Dim CihazID As String = Cihaz_ID_Text.Value.ToString.PadLeft(3, "0")
                Dim MinAlgilama As String = Min_Algilama_Mesafe_Text.Value.ToString.PadLeft(3, "0")
                Dim MaxAlgilama As String = Max_Algilama_Mesafe_Text.Value.ToString.PadLeft(3, "0")
                Dim GonderilecekKomut As String = Komut & CihazID & MinAlgilama & MaxAlgilama & "**" & Chr(13)
                SerialPortx.Write(GonderilecekKomut)


            End If
        End If
    End Sub

    Private Sub Led_Durum_Degistirme_Sureleri_Buton_Click(sender As Object, e As EventArgs) Handles Led_Durum_Degistirme_Sureleri_Buton.Click
        If CihazAraAktif = False Then
            If Seriport_Ayarlandi() Then
                Dim Komut As String = "$SL"
                Dim CihazID As String = Cihaz_ID_Text.Value.ToString.PadLeft(3, "0")
                Dim KirmiziYakmaSuresi As String = Kirmizi_Yakma_Text.Value.ToString.PadLeft(2, "0")
                Dim YesileDonmeSuresi As String = Yesile_Donme_Text.Value.ToString.PadLeft(2, "0")
                Dim GonderilecekKomut As String = Komut & CihazID & KirmiziYakmaSuresi & YesileDonmeSuresi & "**" & Chr(13)
                SerialPortx.Write(GonderilecekKomut)


            End If
        End If
    End Sub

    Private Sub Led_Durum_Ogren_Buton_Click(sender As Object, e As EventArgs) Handles Led_Durum_Ogren_Buton.Click
        If CihazAraAktif = False Then
            If Seriport_Ayarlandi() Then
                Dim Komut As String = "$SS"
                Dim CihazID As String = Cihaz_ID_Text.Value.ToString.PadLeft(3, "0")
                Dim GonderilecekKomut As String = Komut & CihazID & "**" & Chr(13)
                SerialPortx.Write(GonderilecekKomut)


            End If
        End If
    End Sub

    Private Sub Portu_Ac_Buton_Click(sender As Object, e As EventArgs) Handles Portu_Ac_Buton.Click

        If Portu_Ac_Buton.Text = "Kapat" Then
            Portu_Ac_Buton.Text = "Aç"
            SerialPortx.Close()
        Else
            Seriport_Ayarlandi()
        End If

    End Sub
End Class