namespace ZEngine_Hack.Elements.InSettingsElements
{
    partial class General
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            this.label1 = new System.Windows.Forms.Label();
            this.Hide_TB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Threads_TB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.Rest_TB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.Conn_TB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.Boost_TB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.BusyDiskSpace = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FreeDiskSpace = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ZEUsageProcess_Label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SystemProcessesCount_Label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ProcessesCount_Label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AllMemoryCount_Label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FreeMemoryCount_Label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.VirtualMemoryCount_Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FreeMemory = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DiskSpaceProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.MemoryBusyProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.CPUProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таймаут хайда:";
            // 
            // Hide_TB
            // 
            this.Hide_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Hide_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.Hide_TB.ForeColor = System.Drawing.Color.White;
            this.Hide_TB.HintForeColor = System.Drawing.Color.Empty;
            this.Hide_TB.HintText = "";
            this.Hide_TB.isPassword = false;
            this.Hide_TB.LineFocusedColor = System.Drawing.Color.White;
            this.Hide_TB.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.Hide_TB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.Hide_TB.LineThickness = 4;
            this.Hide_TB.Location = new System.Drawing.Point(228, 27);
            this.Hide_TB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Hide_TB.Name = "Hide_TB";
            this.Hide_TB.Size = new System.Drawing.Size(49, 48);
            this.Hide_TB.TabIndex = 1;
            this.Hide_TB.Text = "300";
            this.Hide_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Threads_TB
            // 
            this.Threads_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Threads_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.Threads_TB.ForeColor = System.Drawing.Color.White;
            this.Threads_TB.HintForeColor = System.Drawing.Color.Empty;
            this.Threads_TB.HintText = "";
            this.Threads_TB.isPassword = false;
            this.Threads_TB.LineFocusedColor = System.Drawing.Color.White;
            this.Threads_TB.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.Threads_TB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.Threads_TB.LineThickness = 4;
            this.Threads_TB.Location = new System.Drawing.Point(228, 88);
            this.Threads_TB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Threads_TB.Name = "Threads_TB";
            this.Threads_TB.Size = new System.Drawing.Size(49, 48);
            this.Threads_TB.TabIndex = 3;
            this.Threads_TB.Text = "8";
            this.Threads_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество потоков:";
            // 
            // Rest_TB
            // 
            this.Rest_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Rest_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.Rest_TB.ForeColor = System.Drawing.Color.White;
            this.Rest_TB.HintForeColor = System.Drawing.Color.Empty;
            this.Rest_TB.HintText = "";
            this.Rest_TB.isPassword = false;
            this.Rest_TB.LineFocusedColor = System.Drawing.Color.White;
            this.Rest_TB.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.Rest_TB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.Rest_TB.LineThickness = 4;
            this.Rest_TB.Location = new System.Drawing.Point(228, 146);
            this.Rest_TB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Rest_TB.Name = "Rest_TB";
            this.Rest_TB.Size = new System.Drawing.Size(49, 48);
            this.Rest_TB.TabIndex = 5;
            this.Rest_TB.Text = "120";
            this.Rest_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Таймаут рестарта:";
            // 
            // Conn_TB
            // 
            this.Conn_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Conn_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.Conn_TB.ForeColor = System.Drawing.Color.White;
            this.Conn_TB.HintForeColor = System.Drawing.Color.Empty;
            this.Conn_TB.HintText = "";
            this.Conn_TB.isPassword = false;
            this.Conn_TB.LineFocusedColor = System.Drawing.Color.White;
            this.Conn_TB.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.Conn_TB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.Conn_TB.LineThickness = 4;
            this.Conn_TB.Location = new System.Drawing.Point(228, 208);
            this.Conn_TB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Conn_TB.Name = "Conn_TB";
            this.Conn_TB.Size = new System.Drawing.Size(49, 48);
            this.Conn_TB.TabIndex = 7;
            this.Conn_TB.Text = "5";
            this.Conn_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Таймаут соединения:";
            // 
            // Boost_TB
            // 
            this.Boost_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Boost_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.Boost_TB.ForeColor = System.Drawing.Color.White;
            this.Boost_TB.HintForeColor = System.Drawing.Color.Empty;
            this.Boost_TB.HintText = "";
            this.Boost_TB.isPassword = false;
            this.Boost_TB.LineFocusedColor = System.Drawing.Color.White;
            this.Boost_TB.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(244)))));
            this.Boost_TB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.Boost_TB.LineThickness = 4;
            this.Boost_TB.Location = new System.Drawing.Point(228, 268);
            this.Boost_TB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Boost_TB.Name = "Boost_TB";
            this.Boost_TB.Size = new System.Drawing.Size(49, 48);
            this.Boost_TB.TabIndex = 9;
            this.Boost_TB.Text = "25";
            this.Boost_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Значение буста:";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DarkViolet;
            this.bunifuCards1.Controls.Add(this.BusyDiskSpace);
            this.bunifuCards1.Controls.Add(this.FreeDiskSpace);
            this.bunifuCards1.Controls.Add(this.ZEUsageProcess_Label);
            this.bunifuCards1.Controls.Add(this.SystemProcessesCount_Label);
            this.bunifuCards1.Controls.Add(this.ProcessesCount_Label);
            this.bunifuCards1.Controls.Add(this.AllMemoryCount_Label);
            this.bunifuCards1.Controls.Add(this.FreeMemoryCount_Label);
            this.bunifuCards1.Controls.Add(this.VirtualMemoryCount_Label);
            this.bunifuCards1.Controls.Add(this.pictureBox1);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel9);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel10);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel11);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel12);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuCards1.Controls.Add(this.FreeMemory);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel8);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.Controls.Add(this.DiskSpaceProgress);
            this.bunifuCards1.Controls.Add(this.MemoryBusyProgress);
            this.bunifuCards1.Controls.Add(this.CPUProgress);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator2);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(292, 17);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(396, 311);
            this.bunifuCards1.TabIndex = 10;
            // 
            // BusyDiskSpace
            // 
            this.BusyDiskSpace.AutoSize = true;
            this.BusyDiskSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BusyDiskSpace.Location = new System.Drawing.Point(190, 81);
            this.BusyDiskSpace.Name = "BusyDiskSpace";
            this.BusyDiskSpace.Size = new System.Drawing.Size(18, 20);
            this.BusyDiskSpace.TabIndex = 26;
            this.BusyDiskSpace.Text = "1";
            // 
            // FreeDiskSpace
            // 
            this.FreeDiskSpace.AutoSize = true;
            this.FreeDiskSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FreeDiskSpace.Location = new System.Drawing.Point(190, 50);
            this.FreeDiskSpace.Name = "FreeDiskSpace";
            this.FreeDiskSpace.Size = new System.Drawing.Size(18, 20);
            this.FreeDiskSpace.TabIndex = 25;
            this.FreeDiskSpace.Text = "1";
            // 
            // ZEUsageProcess_Label
            // 
            this.ZEUsageProcess_Label.AutoSize = true;
            this.ZEUsageProcess_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ZEUsageProcess_Label.Location = new System.Drawing.Point(353, 248);
            this.ZEUsageProcess_Label.Name = "ZEUsageProcess_Label";
            this.ZEUsageProcess_Label.Size = new System.Drawing.Size(18, 20);
            this.ZEUsageProcess_Label.TabIndex = 24;
            this.ZEUsageProcess_Label.Text = "1";
            // 
            // SystemProcessesCount_Label
            // 
            this.SystemProcessesCount_Label.AutoSize = true;
            this.SystemProcessesCount_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.SystemProcessesCount_Label.Location = new System.Drawing.Point(198, 279);
            this.SystemProcessesCount_Label.Name = "SystemProcessesCount_Label";
            this.SystemProcessesCount_Label.Size = new System.Drawing.Size(18, 20);
            this.SystemProcessesCount_Label.TabIndex = 23;
            this.SystemProcessesCount_Label.Text = "1";
            // 
            // ProcessesCount_Label
            // 
            this.ProcessesCount_Label.AutoSize = true;
            this.ProcessesCount_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ProcessesCount_Label.Location = new System.Drawing.Point(198, 248);
            this.ProcessesCount_Label.Name = "ProcessesCount_Label";
            this.ProcessesCount_Label.Size = new System.Drawing.Size(18, 20);
            this.ProcessesCount_Label.TabIndex = 22;
            this.ProcessesCount_Label.Text = "1";
            // 
            // AllMemoryCount_Label
            // 
            this.AllMemoryCount_Label.AutoSize = true;
            this.AllMemoryCount_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.AllMemoryCount_Label.Location = new System.Drawing.Point(168, 149);
            this.AllMemoryCount_Label.Name = "AllMemoryCount_Label";
            this.AllMemoryCount_Label.Size = new System.Drawing.Size(18, 20);
            this.AllMemoryCount_Label.TabIndex = 21;
            this.AllMemoryCount_Label.Text = "1";
            // 
            // FreeMemoryCount_Label
            // 
            this.FreeMemoryCount_Label.AutoSize = true;
            this.FreeMemoryCount_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FreeMemoryCount_Label.Location = new System.Drawing.Point(196, 180);
            this.FreeMemoryCount_Label.Name = "FreeMemoryCount_Label";
            this.FreeMemoryCount_Label.Size = new System.Drawing.Size(18, 20);
            this.FreeMemoryCount_Label.TabIndex = 20;
            this.FreeMemoryCount_Label.Text = "1";
            // 
            // VirtualMemoryCount_Label
            // 
            this.VirtualMemoryCount_Label.AutoSize = true;
            this.VirtualMemoryCount_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.VirtualMemoryCount_Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.VirtualMemoryCount_Label.Location = new System.Drawing.Point(347, 150);
            this.VirtualMemoryCount_Label.Name = "VirtualMemoryCount_Label";
            this.VirtualMemoryCount_Label.Size = new System.Drawing.Size(18, 20);
            this.VirtualMemoryCount_Label.TabIndex = 19;
            this.VirtualMemoryCount_Label.Text = "1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(357, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(242, 248);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(114, 20);
            this.bunifuCustomLabel9.TabIndex = 17;
            this.bunifuCustomLabel9.Text = "ZEngine LDR:";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(93, 278);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(114, 20);
            this.bunifuCustomLabel10.TabIndex = 16;
            this.bunifuCustomLabel10.Text = "Системные: ";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(105, 248);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(107, 20);
            this.bunifuCustomLabel11.TabIndex = 15;
            this.bunifuCustomLabel11.Text = "Процессы:  ";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(206, 213);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(43, 20);
            this.bunifuCustomLabel12.TabIndex = 14;
            this.bunifuCustomLabel12.Text = "ЦП:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(229, 149);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(124, 20);
            this.bunifuCustomLabel5.TabIndex = 13;
            this.bunifuCustomLabel5.Text = "Виртаульной:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(111, 149);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(68, 20);
            this.bunifuCustomLabel6.TabIndex = 12;
            this.bunifuCustomLabel6.Text = "Всего: ";
            // 
            // FreeMemory
            // 
            this.FreeMemory.AutoSize = true;
            this.FreeMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FreeMemory.Location = new System.Drawing.Point(104, 179);
            this.FreeMemory.Name = "FreeMemory";
            this.FreeMemory.Size = new System.Drawing.Size(103, 20);
            this.FreeMemory.TabIndex = 11;
            this.FreeMemory.Text = "Свободно: ";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(203, 114);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(54, 20);
            this.bunifuCustomLabel8.TabIndex = 10;
            this.bunifuCustomLabel8.Text = "ОЗУ:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(251, 49);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(105, 20);
            this.bunifuCustomLabel4.TabIndex = 9;
            this.bunifuCustomLabel4.Text = "Состояние:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(120, 80);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(81, 20);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "Занято: ";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(98, 49);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(103, 20);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "Свободно: ";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(203, 14);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(57, 20);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "HDD:";
            // 
            // DiskSpaceProgress
            // 
            this.DiskSpaceProgress.animated = false;
            this.DiskSpaceProgress.animationIterval = 5;
            this.DiskSpaceProgress.animationSpeed = 300;
            this.DiskSpaceProgress.BackColor = System.Drawing.Color.White;
            this.DiskSpaceProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DiskSpaceProgress.BackgroundImage")));
            this.DiskSpaceProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.DiskSpaceProgress.ForeColor = System.Drawing.Color.Tomato;
            this.DiskSpaceProgress.LabelVisible = true;
            this.DiskSpaceProgress.LineProgressThickness = 8;
            this.DiskSpaceProgress.LineThickness = 5;
            this.DiskSpaceProgress.Location = new System.Drawing.Point(3, 7);
            this.DiskSpaceProgress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DiskSpaceProgress.MaxValue = 1000;
            this.DiskSpaceProgress.Name = "DiskSpaceProgress";
            this.DiskSpaceProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.DiskSpaceProgress.ProgressColor = System.Drawing.Color.Tomato;
            this.DiskSpaceProgress.Size = new System.Drawing.Size(97, 97);
            this.DiskSpaceProgress.TabIndex = 5;
            this.DiskSpaceProgress.Value = 78;
            // 
            // MemoryBusyProgress
            // 
            this.MemoryBusyProgress.animated = false;
            this.MemoryBusyProgress.animationIterval = 5;
            this.MemoryBusyProgress.animationSpeed = 300;
            this.MemoryBusyProgress.BackColor = System.Drawing.Color.White;
            this.MemoryBusyProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MemoryBusyProgress.BackgroundImage")));
            this.MemoryBusyProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.MemoryBusyProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.MemoryBusyProgress.LabelVisible = true;
            this.MemoryBusyProgress.LineProgressThickness = 8;
            this.MemoryBusyProgress.LineThickness = 5;
            this.MemoryBusyProgress.Location = new System.Drawing.Point(3, 109);
            this.MemoryBusyProgress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MemoryBusyProgress.MaxValue = 100;
            this.MemoryBusyProgress.Name = "MemoryBusyProgress";
            this.MemoryBusyProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.MemoryBusyProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.MemoryBusyProgress.Size = new System.Drawing.Size(97, 97);
            this.MemoryBusyProgress.TabIndex = 4;
            this.MemoryBusyProgress.Value = 43;
            // 
            // CPUProgress
            // 
            this.CPUProgress.animated = false;
            this.CPUProgress.animationIterval = 5;
            this.CPUProgress.animationSpeed = 300;
            this.CPUProgress.BackColor = System.Drawing.Color.White;
            this.CPUProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CPUProgress.BackgroundImage")));
            this.CPUProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.CPUProgress.ForeColor = System.Drawing.Color.DarkViolet;
            this.CPUProgress.LabelVisible = true;
            this.CPUProgress.LineProgressThickness = 8;
            this.CPUProgress.LineThickness = 5;
            this.CPUProgress.Location = new System.Drawing.Point(3, 211);
            this.CPUProgress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CPUProgress.MaxValue = 100;
            this.CPUProgress.Name = "CPUProgress";
            this.CPUProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.CPUProgress.ProgressColor = System.Drawing.Color.DarkViolet;
            this.CPUProgress.Size = new System.Drawing.Size(97, 97);
            this.CPUProgress.TabIndex = 3;
            this.CPUProgress.Value = 11;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(3, 202);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(390, 8);
            this.bunifuSeparator2.TabIndex = 2;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 103);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(390, 8);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.Boost_TB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Conn_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Rest_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Threads_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hide_TB);
            this.Controls.Add(this.label1);
            this.Name = "General";
            this.Size = new System.Drawing.Size(703, 348);
            this.Load += new System.EventHandler(this.General_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Hide_TB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Threads_TB;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Rest_TB;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Conn_TB;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Boost_TB;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar DiskSpaceProgress;
        private Bunifu.Framework.UI.BunifuCircleProgressbar MemoryBusyProgress;
        private Bunifu.Framework.UI.BunifuCircleProgressbar CPUProgress;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel FreeMemory;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label VirtualMemoryCount_Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel AllMemoryCount_Label;
        private Bunifu.Framework.UI.BunifuCustomLabel FreeMemoryCount_Label;
        private Bunifu.Framework.UI.BunifuCustomLabel SystemProcessesCount_Label;
        private Bunifu.Framework.UI.BunifuCustomLabel ProcessesCount_Label;
        private Bunifu.Framework.UI.BunifuCustomLabel ZEUsageProcess_Label;
        private Bunifu.Framework.UI.BunifuCustomLabel BusyDiskSpace;
        private Bunifu.Framework.UI.BunifuCustomLabel FreeDiskSpace;
    }
}
