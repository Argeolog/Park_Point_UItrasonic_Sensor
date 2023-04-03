namespace Park_Point_Ultrasonic_Sensor
{
    partial class Anasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GroupBox8 = new System.Windows.Forms.GroupBox();
            this.Donanim_Versiyon_Label = new System.Windows.Forms.Label();
            this.GroupBox7 = new System.Windows.Forms.GroupBox();
            this.Sensor_Rengi_Picturebox = new System.Windows.Forms.PictureBox();
            this.Led_Durum_Ogren_Buton = new System.Windows.Forms.Button();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.Olculen_Mesafe_Text = new System.Windows.Forms.Label();
            this.Mesafe_Olc_Buton = new System.Windows.Forms.Button();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.Max_Algilama_Mesafe_Text = new System.Windows.Forms.NumericUpDown();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Min_Algilama_Mesafe_Text = new System.Windows.Forms.NumericUpDown();
            this.Sensor_Algilama_Mesafe_Ayarla_Buton = new System.Windows.Forms.Button();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Yesile_Donme_Text = new System.Windows.Forms.NumericUpDown();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Kirmizi_Yakma_Text = new System.Windows.Forms.NumericUpDown();
            this.Led_Durum_Degistirme_Sureleri_Buton = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Yeni_Cihaz_ID_Text = new System.Windows.Forms.NumericUpDown();
            this.Cihaz_ID_Degistir_Buton = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Taranan_ID_Text = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Cihaz_ID_Text = new System.Windows.Forms.NumericUpDown();
            this.Cihaz_Ara_Buton = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Yenile_Buton = new System.Windows.Forms.Button();
            this.Comport_Combo = new System.Windows.Forms.ComboBox();
            this.SerialPortx = new System.IO.Ports.SerialPort(this.components);
            this.Cihaz_Ara_Timer = new System.Windows.Forms.Timer(this.components);
            this.Portu_Ac_Buton = new System.Windows.Forms.Button();
            this.GroupBox8.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sensor_Rengi_Picturebox)).BeginInit();
            this.GroupBox6.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Max_Algilama_Mesafe_Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min_Algilama_Mesafe_Text)).BeginInit();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Yesile_Donme_Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kirmizi_Yakma_Text)).BeginInit();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Yeni_Cihaz_ID_Text)).BeginInit();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cihaz_ID_Text)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox8
            // 
            this.GroupBox8.Controls.Add(this.Donanim_Versiyon_Label);
            this.GroupBox8.Location = new System.Drawing.Point(312, 12);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new System.Drawing.Size(288, 65);
            this.GroupBox8.TabIndex = 18;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "Donanım Versiyon";
            // 
            // Donanim_Versiyon_Label
            // 
            this.Donanim_Versiyon_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Donanim_Versiyon_Label.Location = new System.Drawing.Point(12, 17);
            this.Donanim_Versiyon_Label.Name = "Donanim_Versiyon_Label";
            this.Donanim_Versiyon_Label.Size = new System.Drawing.Size(253, 36);
            this.Donanim_Versiyon_Label.TabIndex = 7;
            this.Donanim_Versiyon_Label.Text = "0.0";
            this.Donanim_Versiyon_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox7
            // 
            this.GroupBox7.Controls.Add(this.Sensor_Rengi_Picturebox);
            this.GroupBox7.Controls.Add(this.Led_Durum_Ogren_Buton);
            this.GroupBox7.Location = new System.Drawing.Point(306, 83);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new System.Drawing.Size(288, 117);
            this.GroupBox7.TabIndex = 19;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "Led Durumu Oku";
            // 
            // Sensor_Rengi_Picturebox
            // 
            this.Sensor_Rengi_Picturebox.BackColor = System.Drawing.Color.White;
            this.Sensor_Rengi_Picturebox.Location = new System.Drawing.Point(12, 19);
            this.Sensor_Rengi_Picturebox.Name = "Sensor_Rengi_Picturebox";
            this.Sensor_Rengi_Picturebox.Size = new System.Drawing.Size(259, 34);
            this.Sensor_Rengi_Picturebox.TabIndex = 2;
            this.Sensor_Rengi_Picturebox.TabStop = false;
            // 
            // Led_Durum_Ogren_Buton
            // 
            this.Led_Durum_Ogren_Buton.Location = new System.Drawing.Point(12, 59);
            this.Led_Durum_Ogren_Buton.Name = "Led_Durum_Ogren_Buton";
            this.Led_Durum_Ogren_Buton.Size = new System.Drawing.Size(259, 41);
            this.Led_Durum_Ogren_Buton.TabIndex = 1;
            this.Led_Durum_Ogren_Buton.Text = "Sensör Led Durum (Aktif-Pasif) Öğren";
            this.Led_Durum_Ogren_Buton.UseVisualStyleBackColor = true;
            this.Led_Durum_Ogren_Buton.Click += new System.EventHandler(this.Led_Durum_Ogren_Buton_Click);
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.Olculen_Mesafe_Text);
            this.GroupBox6.Controls.Add(this.Mesafe_Olc_Buton);
            this.GroupBox6.Location = new System.Drawing.Point(306, 206);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(288, 117);
            this.GroupBox6.TabIndex = 17;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "Mesafe Ölç";
            // 
            // Olculen_Mesafe_Text
            // 
            this.Olculen_Mesafe_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Olculen_Mesafe_Text.Location = new System.Drawing.Point(12, 16);
            this.Olculen_Mesafe_Text.Name = "Olculen_Mesafe_Text";
            this.Olculen_Mesafe_Text.Size = new System.Drawing.Size(259, 35);
            this.Olculen_Mesafe_Text.TabIndex = 7;
            this.Olculen_Mesafe_Text.Text = "0 cm";
            this.Olculen_Mesafe_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mesafe_Olc_Buton
            // 
            this.Mesafe_Olc_Buton.Location = new System.Drawing.Point(12, 57);
            this.Mesafe_Olc_Buton.Name = "Mesafe_Olc_Buton";
            this.Mesafe_Olc_Buton.Size = new System.Drawing.Size(259, 41);
            this.Mesafe_Olc_Buton.TabIndex = 1;
            this.Mesafe_Olc_Buton.Text = "Mesafe Ölç";
            this.Mesafe_Olc_Buton.UseVisualStyleBackColor = true;
            this.Mesafe_Olc_Buton.Click += new System.EventHandler(this.Mesafe_Olc_Buton_Click);
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.Max_Algilama_Mesafe_Text);
            this.GroupBox5.Controls.Add(this.Label7);
            this.GroupBox5.Controls.Add(this.Label8);
            this.GroupBox5.Controls.Add(this.Min_Algilama_Mesafe_Text);
            this.GroupBox5.Controls.Add(this.Sensor_Algilama_Mesafe_Ayarla_Buton);
            this.GroupBox5.Location = new System.Drawing.Point(12, 329);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(288, 140);
            this.GroupBox5.TabIndex = 16;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Sensör Algılama Aralığı Ayarla";
            // 
            // Max_Algilama_Mesafe_Text
            // 
            this.Max_Algilama_Mesafe_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Max_Algilama_Mesafe_Text.Location = new System.Drawing.Point(107, 55);
            this.Max_Algilama_Mesafe_Text.Maximum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.Max_Algilama_Mesafe_Text.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.Max_Algilama_Mesafe_Text.Name = "Max_Algilama_Mesafe_Text";
            this.Max_Algilama_Mesafe_Text.Size = new System.Drawing.Size(164, 22);
            this.Max_Algilama_Mesafe_Text.TabIndex = 7;
            this.Max_Algilama_Mesafe_Text.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(9, 59);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(88, 13);
            this.Label7.TabIndex = 6;
            this.Label7.Text = "Max Mesafe (cm)";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(9, 31);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(85, 13);
            this.Label8.TabIndex = 4;
            this.Label8.Text = "Min Mesafe (cm)";
            // 
            // Min_Algilama_Mesafe_Text
            // 
            this.Min_Algilama_Mesafe_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Min_Algilama_Mesafe_Text.Location = new System.Drawing.Point(107, 27);
            this.Min_Algilama_Mesafe_Text.Maximum = new decimal(new int[] {
            340,
            0,
            0,
            0});
            this.Min_Algilama_Mesafe_Text.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Min_Algilama_Mesafe_Text.Name = "Min_Algilama_Mesafe_Text";
            this.Min_Algilama_Mesafe_Text.Size = new System.Drawing.Size(164, 22);
            this.Min_Algilama_Mesafe_Text.TabIndex = 3;
            this.Min_Algilama_Mesafe_Text.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Sensor_Algilama_Mesafe_Ayarla_Buton
            // 
            this.Sensor_Algilama_Mesafe_Ayarla_Buton.Location = new System.Drawing.Point(12, 83);
            this.Sensor_Algilama_Mesafe_Ayarla_Buton.Name = "Sensor_Algilama_Mesafe_Ayarla_Buton";
            this.Sensor_Algilama_Mesafe_Ayarla_Buton.Size = new System.Drawing.Size(259, 41);
            this.Sensor_Algilama_Mesafe_Ayarla_Buton.TabIndex = 1;
            this.Sensor_Algilama_Mesafe_Ayarla_Buton.Text = "Sensör Algılama Mesafelerini Ayarla";
            this.Sensor_Algilama_Mesafe_Ayarla_Buton.UseVisualStyleBackColor = true;
            this.Sensor_Algilama_Mesafe_Ayarla_Buton.Click += new System.EventHandler(this.Sensor_Algilama_Mesafe_Ayarla_Buton_Click);
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.Yesile_Donme_Text);
            this.GroupBox4.Controls.Add(this.Label4);
            this.GroupBox4.Controls.Add(this.Label6);
            this.GroupBox4.Controls.Add(this.Kirmizi_Yakma_Text);
            this.GroupBox4.Controls.Add(this.Led_Durum_Degistirme_Sureleri_Buton);
            this.GroupBox4.Location = new System.Drawing.Point(306, 329);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(288, 140);
            this.GroupBox4.TabIndex = 15;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Sensöre Girip-Çıktığında Led Durum Süresini Ayarla";
            // 
            // Yesile_Donme_Text
            // 
            this.Yesile_Donme_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yesile_Donme_Text.Location = new System.Drawing.Point(107, 55);
            this.Yesile_Donme_Text.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Yesile_Donme_Text.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Yesile_Donme_Text.Name = "Yesile_Donme_Text";
            this.Yesile_Donme_Text.Size = new System.Drawing.Size(164, 22);
            this.Yesile_Donme_Text.TabIndex = 7;
            this.Yesile_Donme_Text.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(9, 59);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(92, 13);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Yeşile Dönme (sn)";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(9, 31);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(92, 13);
            this.Label6.TabIndex = 4;
            this.Label6.Text = "Kırmızı Yakma (sn)";
            // 
            // Kirmizi_Yakma_Text
            // 
            this.Kirmizi_Yakma_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kirmizi_Yakma_Text.Location = new System.Drawing.Point(107, 27);
            this.Kirmizi_Yakma_Text.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Kirmizi_Yakma_Text.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Kirmizi_Yakma_Text.Name = "Kirmizi_Yakma_Text";
            this.Kirmizi_Yakma_Text.Size = new System.Drawing.Size(164, 22);
            this.Kirmizi_Yakma_Text.TabIndex = 3;
            this.Kirmizi_Yakma_Text.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Led_Durum_Degistirme_Sureleri_Buton
            // 
            this.Led_Durum_Degistirme_Sureleri_Buton.Location = new System.Drawing.Point(12, 83);
            this.Led_Durum_Degistirme_Sureleri_Buton.Name = "Led_Durum_Degistirme_Sureleri_Buton";
            this.Led_Durum_Degistirme_Sureleri_Buton.Size = new System.Drawing.Size(259, 41);
            this.Led_Durum_Degistirme_Sureleri_Buton.TabIndex = 1;
            this.Led_Durum_Degistirme_Sureleri_Buton.Text = "Led Durum Sürelerini Ayarla";
            this.Led_Durum_Degistirme_Sureleri_Buton.UseVisualStyleBackColor = true;
            this.Led_Durum_Degistirme_Sureleri_Buton.Click += new System.EventHandler(this.Led_Durum_Degistirme_Sureleri_Buton_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Controls.Add(this.Yeni_Cihaz_ID_Text);
            this.GroupBox3.Controls.Add(this.Cihaz_ID_Degistir_Buton);
            this.GroupBox3.Location = new System.Drawing.Point(12, 206);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(288, 117);
            this.GroupBox3.TabIndex = 14;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Cihaz ID Değiştir";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 33);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(42, 13);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Yeni ID";
            // 
            // Yeni_Cihaz_ID_Text
            // 
            this.Yeni_Cihaz_ID_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yeni_Cihaz_ID_Text.Location = new System.Drawing.Point(64, 29);
            this.Yeni_Cihaz_ID_Text.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Yeni_Cihaz_ID_Text.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Yeni_Cihaz_ID_Text.Name = "Yeni_Cihaz_ID_Text";
            this.Yeni_Cihaz_ID_Text.Size = new System.Drawing.Size(207, 22);
            this.Yeni_Cihaz_ID_Text.TabIndex = 5;
            this.Yeni_Cihaz_ID_Text.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Cihaz_ID_Degistir_Buton
            // 
            this.Cihaz_ID_Degistir_Buton.Location = new System.Drawing.Point(12, 57);
            this.Cihaz_ID_Degistir_Buton.Name = "Cihaz_ID_Degistir_Buton";
            this.Cihaz_ID_Degistir_Buton.Size = new System.Drawing.Size(259, 41);
            this.Cihaz_ID_Degistir_Buton.TabIndex = 1;
            this.Cihaz_ID_Degistir_Buton.Text = "Cihaz ID Değiştir";
            this.Cihaz_ID_Degistir_Buton.UseVisualStyleBackColor = true;
            this.Cihaz_ID_Degistir_Buton.Click += new System.EventHandler(this.Cihaz_ID_Degistir_Buton_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.Taranan_ID_Text);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Controls.Add(this.Cihaz_ID_Text);
            this.GroupBox2.Controls.Add(this.Cihaz_Ara_Buton);
            this.GroupBox2.Location = new System.Drawing.Point(12, 83);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(288, 117);
            this.GroupBox2.TabIndex = 13;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Cihaz Ara";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(190, 31);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(47, 13);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Taranan";
            // 
            // Taranan_ID_Text
            // 
            this.Taranan_ID_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Taranan_ID_Text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Taranan_ID_Text.Location = new System.Drawing.Point(231, 27);
            this.Taranan_ID_Text.Name = "Taranan_ID_Text";
            this.Taranan_ID_Text.Size = new System.Drawing.Size(51, 23);
            this.Taranan_ID_Text.TabIndex = 5;
            this.Taranan_ID_Text.Text = "0";
            this.Taranan_ID_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Cihaz ID";
            // 
            // Cihaz_ID_Text
            // 
            this.Cihaz_ID_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cihaz_ID_Text.Location = new System.Drawing.Point(64, 27);
            this.Cihaz_ID_Text.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Cihaz_ID_Text.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Cihaz_ID_Text.Name = "Cihaz_ID_Text";
            this.Cihaz_ID_Text.Size = new System.Drawing.Size(120, 22);
            this.Cihaz_ID_Text.TabIndex = 3;
            this.Cihaz_ID_Text.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // Cihaz_Ara_Buton
            // 
            this.Cihaz_Ara_Buton.Location = new System.Drawing.Point(12, 59);
            this.Cihaz_Ara_Buton.Name = "Cihaz_Ara_Buton";
            this.Cihaz_Ara_Buton.Size = new System.Drawing.Size(259, 41);
            this.Cihaz_Ara_Buton.TabIndex = 1;
            this.Cihaz_Ara_Buton.Text = "Cihaz Ara";
            this.Cihaz_Ara_Buton.UseVisualStyleBackColor = true;
            this.Cihaz_Ara_Buton.Click += new System.EventHandler(this.Cihaz_Ara_Buton_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Portu_Ac_Buton);
            this.GroupBox1.Controls.Add(this.Yenile_Buton);
            this.GroupBox1.Controls.Add(this.Comport_Combo);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(288, 65);
            this.GroupBox1.TabIndex = 12;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Comport Seç";
            // 
            // Yenile_Buton
            // 
            this.Yenile_Buton.Location = new System.Drawing.Point(207, 21);
            this.Yenile_Buton.Name = "Yenile_Buton";
            this.Yenile_Buton.Size = new System.Drawing.Size(75, 32);
            this.Yenile_Buton.TabIndex = 1;
            this.Yenile_Buton.Text = "Yenile";
            this.Yenile_Buton.UseVisualStyleBackColor = true;
            this.Yenile_Buton.Click += new System.EventHandler(this.Yenile_Buton_Click);
            // 
            // Comport_Combo
            // 
            this.Comport_Combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Comport_Combo.FormattingEnabled = true;
            this.Comport_Combo.Location = new System.Drawing.Point(12, 24);
            this.Comport_Combo.Name = "Comport_Combo";
            this.Comport_Combo.Size = new System.Drawing.Size(108, 26);
            this.Comport_Combo.TabIndex = 0;
            // 
            // SerialPortx
            // 
            this.SerialPortx.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPortx_DataReceived);
            // 
            // Cihaz_Ara_Timer
            // 
            this.Cihaz_Ara_Timer.Interval = 150;
            this.Cihaz_Ara_Timer.Tick += new System.EventHandler(this.Cihaz_Ara_Timer_Tick);
            // 
            // Portu_Ac_Buton
            // 
            this.Portu_Ac_Buton.Location = new System.Drawing.Point(126, 21);
            this.Portu_Ac_Buton.Name = "Portu_Ac_Buton";
            this.Portu_Ac_Buton.Size = new System.Drawing.Size(75, 32);
            this.Portu_Ac_Buton.TabIndex = 3;
            this.Portu_Ac_Buton.Text = "Aç";
            this.Portu_Ac_Buton.UseVisualStyleBackColor = true;
            this.Portu_Ac_Buton.Click += new System.EventHandler(this.Portu_Ac_Buton_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 479);
            this.Controls.Add(this.GroupBox8);
            this.Controls.Add(this.GroupBox7);
            this.Controls.Add(this.GroupBox6);
            this.Controls.Add(this.GroupBox5);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Park Point Ultrasonic Sensor";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Sensor_Rengi_Picturebox)).EndInit();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Max_Algilama_Mesafe_Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min_Algilama_Mesafe_Text)).EndInit();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Yesile_Donme_Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kirmizi_Yakma_Text)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Yeni_Cihaz_ID_Text)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cihaz_ID_Text)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox8;
        internal System.Windows.Forms.Label Donanim_Versiyon_Label;
        internal System.Windows.Forms.GroupBox GroupBox7;
        internal System.Windows.Forms.PictureBox Sensor_Rengi_Picturebox;
        internal System.Windows.Forms.Button Led_Durum_Ogren_Buton;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.Label Olculen_Mesafe_Text;
        internal System.Windows.Forms.Button Mesafe_Olc_Buton;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.NumericUpDown Max_Algilama_Mesafe_Text;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.NumericUpDown Min_Algilama_Mesafe_Text;
        internal System.Windows.Forms.Button Sensor_Algilama_Mesafe_Ayarla_Buton;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.NumericUpDown Yesile_Donme_Text;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.NumericUpDown Kirmizi_Yakma_Text;
        internal System.Windows.Forms.Button Led_Durum_Degistirme_Sureleri_Buton;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.NumericUpDown Yeni_Cihaz_ID_Text;
        internal System.Windows.Forms.Button Cihaz_ID_Degistir_Buton;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Taranan_ID_Text;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.NumericUpDown Cihaz_ID_Text;
        internal System.Windows.Forms.Button Cihaz_Ara_Buton;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button Yenile_Buton;
        internal System.Windows.Forms.ComboBox Comport_Combo;
        internal System.IO.Ports.SerialPort SerialPortx;
        internal System.Windows.Forms.Timer Cihaz_Ara_Timer;
        internal System.Windows.Forms.Button Portu_Ac_Buton;
    }
}

