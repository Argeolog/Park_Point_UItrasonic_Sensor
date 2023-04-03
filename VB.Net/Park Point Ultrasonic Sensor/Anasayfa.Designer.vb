<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Anasayfa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Yenile_Buton = New System.Windows.Forms.Button()
        Me.Comport_Combo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Taranan_ID_Text = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cihaz_ID_Text = New System.Windows.Forms.NumericUpDown()
        Me.Cihaz_Ara_Buton = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Yeni_Cihaz_ID_Text = New System.Windows.Forms.NumericUpDown()
        Me.Cihaz_ID_Degistir_Buton = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Yesile_Donme_Text = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Kirmizi_Yakma_Text = New System.Windows.Forms.NumericUpDown()
        Me.Led_Durum_Degistirme_Sureleri_Buton = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Max_Algilama_Mesafe_Text = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Min_Algilama_Mesafe_Text = New System.Windows.Forms.NumericUpDown()
        Me.Sensor_Algilama_Mesafe_Ayarla_Buton = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Olculen_Mesafe_Text = New System.Windows.Forms.Label()
        Me.Mesafe_Olc_Buton = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Sensor_Rengi_Picturebox = New System.Windows.Forms.PictureBox()
        Me.Led_Durum_Ogren_Buton = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Donanim_Versiyon_Label = New System.Windows.Forms.Label()
        Me.SerialPortx = New System.IO.Ports.SerialPort(Me.components)
        Me.Cihaz_Ara_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Cihaz_ID_Text, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Yeni_Cihaz_ID_Text, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Yesile_Donme_Text, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kirmizi_Yakma_Text, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Max_Algilama_Mesafe_Text, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Min_Algilama_Mesafe_Text, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.Sensor_Rengi_Picturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Yenile_Buton)
        Me.GroupBox1.Controls.Add(Me.Comport_Combo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 65)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comport Seç"
        '
        'Yenile_Buton
        '
        Me.Yenile_Buton.Location = New System.Drawing.Point(196, 21)
        Me.Yenile_Buton.Name = "Yenile_Buton"
        Me.Yenile_Buton.Size = New System.Drawing.Size(75, 32)
        Me.Yenile_Buton.TabIndex = 1
        Me.Yenile_Buton.Text = "Yenile"
        Me.Yenile_Buton.UseVisualStyleBackColor = True
        '
        'Comport_Combo
        '
        Me.Comport_Combo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Comport_Combo.FormattingEnabled = True
        Me.Comport_Combo.Location = New System.Drawing.Point(12, 24)
        Me.Comport_Combo.Name = "Comport_Combo"
        Me.Comport_Combo.Size = New System.Drawing.Size(178, 26)
        Me.Comport_Combo.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Taranan_ID_Text)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Cihaz_ID_Text)
        Me.GroupBox2.Controls.Add(Me.Cihaz_Ara_Buton)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 117)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cihaz Ara"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Taranan"
        '
        'Taranan_ID_Text
        '
        Me.Taranan_ID_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Taranan_ID_Text.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Taranan_ID_Text.Location = New System.Drawing.Point(231, 27)
        Me.Taranan_ID_Text.Name = "Taranan_ID_Text"
        Me.Taranan_ID_Text.Size = New System.Drawing.Size(51, 23)
        Me.Taranan_ID_Text.TabIndex = 5
        Me.Taranan_ID_Text.Text = "0"
        Me.Taranan_ID_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cihaz ID"
        '
        'Cihaz_ID_Text
        '
        Me.Cihaz_ID_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Cihaz_ID_Text.Location = New System.Drawing.Point(64, 27)
        Me.Cihaz_ID_Text.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.Cihaz_ID_Text.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Cihaz_ID_Text.Name = "Cihaz_ID_Text"
        Me.Cihaz_ID_Text.Size = New System.Drawing.Size(120, 22)
        Me.Cihaz_ID_Text.TabIndex = 3
        Me.Cihaz_ID_Text.Value = New Decimal(New Integer() {999, 0, 0, 0})
        '
        'Cihaz_Ara_Buton
        '
        Me.Cihaz_Ara_Buton.Location = New System.Drawing.Point(12, 59)
        Me.Cihaz_Ara_Buton.Name = "Cihaz_Ara_Buton"
        Me.Cihaz_Ara_Buton.Size = New System.Drawing.Size(259, 41)
        Me.Cihaz_Ara_Buton.TabIndex = 1
        Me.Cihaz_Ara_Buton.Text = "Cihaz Ara"
        Me.Cihaz_Ara_Buton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Yeni_Cihaz_ID_Text)
        Me.GroupBox3.Controls.Add(Me.Cihaz_ID_Degistir_Buton)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(288, 117)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cihaz ID Değiştir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Yeni ID"
        '
        'Yeni_Cihaz_ID_Text
        '
        Me.Yeni_Cihaz_ID_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Yeni_Cihaz_ID_Text.Location = New System.Drawing.Point(64, 29)
        Me.Yeni_Cihaz_ID_Text.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.Yeni_Cihaz_ID_Text.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Yeni_Cihaz_ID_Text.Name = "Yeni_Cihaz_ID_Text"
        Me.Yeni_Cihaz_ID_Text.Size = New System.Drawing.Size(207, 22)
        Me.Yeni_Cihaz_ID_Text.TabIndex = 5
        Me.Yeni_Cihaz_ID_Text.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Cihaz_ID_Degistir_Buton
        '
        Me.Cihaz_ID_Degistir_Buton.Location = New System.Drawing.Point(12, 57)
        Me.Cihaz_ID_Degistir_Buton.Name = "Cihaz_ID_Degistir_Buton"
        Me.Cihaz_ID_Degistir_Buton.Size = New System.Drawing.Size(259, 41)
        Me.Cihaz_ID_Degistir_Buton.TabIndex = 1
        Me.Cihaz_ID_Degistir_Buton.Text = "Cihaz ID Değiştir"
        Me.Cihaz_ID_Degistir_Buton.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Yesile_Donme_Text)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Kirmizi_Yakma_Text)
        Me.GroupBox4.Controls.Add(Me.Led_Durum_Degistirme_Sureleri_Buton)
        Me.GroupBox4.Location = New System.Drawing.Point(306, 329)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(288, 140)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sensöre Girip-Çıktığında Led Durum Süresini Ayarla"
        '
        'Yesile_Donme_Text
        '
        Me.Yesile_Donme_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Yesile_Donme_Text.Location = New System.Drawing.Point(107, 55)
        Me.Yesile_Donme_Text.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.Yesile_Donme_Text.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Yesile_Donme_Text.Name = "Yesile_Donme_Text"
        Me.Yesile_Donme_Text.Size = New System.Drawing.Size(164, 22)
        Me.Yesile_Donme_Text.TabIndex = 7
        Me.Yesile_Donme_Text.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Yeşile Dönme (sn)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Kırmızı Yakma (sn)"
        '
        'Kirmizi_Yakma_Text
        '
        Me.Kirmizi_Yakma_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Kirmizi_Yakma_Text.Location = New System.Drawing.Point(107, 27)
        Me.Kirmizi_Yakma_Text.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.Kirmizi_Yakma_Text.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Kirmizi_Yakma_Text.Name = "Kirmizi_Yakma_Text"
        Me.Kirmizi_Yakma_Text.Size = New System.Drawing.Size(164, 22)
        Me.Kirmizi_Yakma_Text.TabIndex = 3
        Me.Kirmizi_Yakma_Text.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Led_Durum_Degistirme_Sureleri_Buton
        '
        Me.Led_Durum_Degistirme_Sureleri_Buton.Location = New System.Drawing.Point(12, 83)
        Me.Led_Durum_Degistirme_Sureleri_Buton.Name = "Led_Durum_Degistirme_Sureleri_Buton"
        Me.Led_Durum_Degistirme_Sureleri_Buton.Size = New System.Drawing.Size(259, 41)
        Me.Led_Durum_Degistirme_Sureleri_Buton.TabIndex = 1
        Me.Led_Durum_Degistirme_Sureleri_Buton.Text = "Led Durum Sürelerini Ayarla"
        Me.Led_Durum_Degistirme_Sureleri_Buton.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Max_Algilama_Mesafe_Text)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Min_Algilama_Mesafe_Text)
        Me.GroupBox5.Controls.Add(Me.Sensor_Algilama_Mesafe_Ayarla_Buton)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 329)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(288, 140)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Sensör Algılama Aralığı Ayarla"
        '
        'Max_Algilama_Mesafe_Text
        '
        Me.Max_Algilama_Mesafe_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Max_Algilama_Mesafe_Text.Location = New System.Drawing.Point(107, 55)
        Me.Max_Algilama_Mesafe_Text.Maximum = New Decimal(New Integer() {350, 0, 0, 0})
        Me.Max_Algilama_Mesafe_Text.Minimum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.Max_Algilama_Mesafe_Text.Name = "Max_Algilama_Mesafe_Text"
        Me.Max_Algilama_Mesafe_Text.Size = New System.Drawing.Size(164, 22)
        Me.Max_Algilama_Mesafe_Text.TabIndex = 7
        Me.Max_Algilama_Mesafe_Text.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Max Mesafe (cm)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Min Mesafe (cm)"
        '
        'Min_Algilama_Mesafe_Text
        '
        Me.Min_Algilama_Mesafe_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Min_Algilama_Mesafe_Text.Location = New System.Drawing.Point(107, 27)
        Me.Min_Algilama_Mesafe_Text.Maximum = New Decimal(New Integer() {340, 0, 0, 0})
        Me.Min_Algilama_Mesafe_Text.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Min_Algilama_Mesafe_Text.Name = "Min_Algilama_Mesafe_Text"
        Me.Min_Algilama_Mesafe_Text.Size = New System.Drawing.Size(164, 22)
        Me.Min_Algilama_Mesafe_Text.TabIndex = 3
        Me.Min_Algilama_Mesafe_Text.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Sensor_Algilama_Mesafe_Ayarla_Buton
        '
        Me.Sensor_Algilama_Mesafe_Ayarla_Buton.Location = New System.Drawing.Point(12, 83)
        Me.Sensor_Algilama_Mesafe_Ayarla_Buton.Name = "Sensor_Algilama_Mesafe_Ayarla_Buton"
        Me.Sensor_Algilama_Mesafe_Ayarla_Buton.Size = New System.Drawing.Size(259, 41)
        Me.Sensor_Algilama_Mesafe_Ayarla_Buton.TabIndex = 1
        Me.Sensor_Algilama_Mesafe_Ayarla_Buton.Text = "Sensör Algılama Mesafelerini Ayarla"
        Me.Sensor_Algilama_Mesafe_Ayarla_Buton.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Olculen_Mesafe_Text)
        Me.GroupBox6.Controls.Add(Me.Mesafe_Olc_Buton)
        Me.GroupBox6.Location = New System.Drawing.Point(306, 206)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(288, 117)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Mesafe Ölç"
        '
        'Olculen_Mesafe_Text
        '
        Me.Olculen_Mesafe_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Olculen_Mesafe_Text.Location = New System.Drawing.Point(12, 16)
        Me.Olculen_Mesafe_Text.Name = "Olculen_Mesafe_Text"
        Me.Olculen_Mesafe_Text.Size = New System.Drawing.Size(259, 35)
        Me.Olculen_Mesafe_Text.TabIndex = 7
        Me.Olculen_Mesafe_Text.Text = "0 cm"
        Me.Olculen_Mesafe_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Mesafe_Olc_Buton
        '
        Me.Mesafe_Olc_Buton.Location = New System.Drawing.Point(12, 57)
        Me.Mesafe_Olc_Buton.Name = "Mesafe_Olc_Buton"
        Me.Mesafe_Olc_Buton.Size = New System.Drawing.Size(259, 41)
        Me.Mesafe_Olc_Buton.TabIndex = 1
        Me.Mesafe_Olc_Buton.Text = "Mesafe Ölç"
        Me.Mesafe_Olc_Buton.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Sensor_Rengi_Picturebox)
        Me.GroupBox7.Controls.Add(Me.Led_Durum_Ogren_Buton)
        Me.GroupBox7.Location = New System.Drawing.Point(306, 83)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(288, 117)
        Me.GroupBox7.TabIndex = 11
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Led Durumu Oku"
        '
        'Sensor_Rengi_Picturebox
        '
        Me.Sensor_Rengi_Picturebox.BackColor = System.Drawing.Color.SpringGreen
        Me.Sensor_Rengi_Picturebox.Location = New System.Drawing.Point(12, 19)
        Me.Sensor_Rengi_Picturebox.Name = "Sensor_Rengi_Picturebox"
        Me.Sensor_Rengi_Picturebox.Size = New System.Drawing.Size(259, 34)
        Me.Sensor_Rengi_Picturebox.TabIndex = 2
        Me.Sensor_Rengi_Picturebox.TabStop = False
        '
        'Led_Durum_Ogren_Buton
        '
        Me.Led_Durum_Ogren_Buton.Location = New System.Drawing.Point(12, 59)
        Me.Led_Durum_Ogren_Buton.Name = "Led_Durum_Ogren_Buton"
        Me.Led_Durum_Ogren_Buton.Size = New System.Drawing.Size(259, 41)
        Me.Led_Durum_Ogren_Buton.TabIndex = 1
        Me.Led_Durum_Ogren_Buton.Text = "Sensör Led Durum (Aktif-Pasif) Öğren"
        Me.Led_Durum_Ogren_Buton.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Donanim_Versiyon_Label)
        Me.GroupBox8.Location = New System.Drawing.Point(312, 12)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(288, 65)
        Me.GroupBox8.TabIndex = 11
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Donanım Versiyon"
        '
        'Donanim_Versiyon_Label
        '
        Me.Donanim_Versiyon_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Donanim_Versiyon_Label.Location = New System.Drawing.Point(12, 17)
        Me.Donanim_Versiyon_Label.Name = "Donanim_Versiyon_Label"
        Me.Donanim_Versiyon_Label.Size = New System.Drawing.Size(253, 36)
        Me.Donanim_Versiyon_Label.TabIndex = 7
        Me.Donanim_Versiyon_Label.Text = "0.0"
        Me.Donanim_Versiyon_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SerialPortx
        '
        '
        'Cihaz_Ara_Timer
        '
        Me.Cihaz_Ara_Timer.Interval = 150
        '
        'Anasayfa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 479)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Anasayfa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Park Point Ultrasonic Sensor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Cihaz_ID_Text, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Yeni_Cihaz_ID_Text, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Yesile_Donme_Text, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kirmizi_Yakma_Text, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.Max_Algilama_Mesafe_Text, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Min_Algilama_Mesafe_Text, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.Sensor_Rengi_Picturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Yenile_Buton As Button
    Friend WithEvents Comport_Combo As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Taranan_ID_Text As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Cihaz_ID_Text As NumericUpDown
    Friend WithEvents Cihaz_Ara_Buton As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Yeni_Cihaz_ID_Text As NumericUpDown
    Friend WithEvents Cihaz_ID_Degistir_Buton As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Yesile_Donme_Text As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Kirmizi_Yakma_Text As NumericUpDown
    Friend WithEvents Led_Durum_Degistirme_Sureleri_Buton As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Max_Algilama_Mesafe_Text As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Min_Algilama_Mesafe_Text As NumericUpDown
    Friend WithEvents Sensor_Algilama_Mesafe_Ayarla_Buton As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Olculen_Mesafe_Text As Label
    Friend WithEvents Mesafe_Olc_Buton As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Sensor_Rengi_Picturebox As PictureBox
    Friend WithEvents Led_Durum_Ogren_Buton As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Donanim_Versiyon_Label As Label
    Friend WithEvents SerialPortx As IO.Ports.SerialPort
    Friend WithEvents Cihaz_Ara_Timer As Timer
End Class
