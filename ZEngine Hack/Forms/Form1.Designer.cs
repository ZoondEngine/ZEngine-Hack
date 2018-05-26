namespace ZEngine_Hack
{
    partial class GeneralForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VersionLabel_Header = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.DownloadSpeed = new System.Windows.Forms.Label();
            this.DiscordIcon = new System.Windows.Forms.PictureBox();
            this.NotifyButton_Menu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.KeyIcon = new System.Windows.Forms.PictureBox();
            this.UpdateStatusIcon = new System.Windows.Forms.PictureBox();
            this.ConnIcon = new System.Windows.Forms.PictureBox();
            this.DownloadIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.MarikHack_TeamMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.SettingsButton_Menu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ZEngine_TeamMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NotifyMenu_Maximized = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyMenu_CheckUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NotifyMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Header_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateStatusIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Header_Panel
            // 
            this.Header_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.Header_Panel.Controls.Add(this.label2);
            this.Header_Panel.Controls.Add(this.label1);
            this.Header_Panel.Controls.Add(this.pictureBox1);
            this.Header_Panel.Controls.Add(this.VersionLabel_Header);
            this.Header_Panel.Controls.Add(this.bunifuCustomLabel1);
            this.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_Panel.Location = new System.Drawing.Point(0, 0);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(948, 64);
            this.Header_Panel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(887, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(915, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // VersionLabel_Header
            // 
            this.VersionLabel_Header.AutoSize = true;
            this.VersionLabel_Header.Font = new System.Drawing.Font("NSimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.VersionLabel_Header.Location = new System.Drawing.Point(82, 49);
            this.VersionLabel_Header.Name = "VersionLabel_Header";
            this.VersionLabel_Header.Size = new System.Drawing.Size(23, 11);
            this.VersionLabel_Header.TabIndex = 2;
            this.VersionLabel_Header.Text = "ver";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("NSimSun", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(70, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(397, 37);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "ZEngine Hack Service";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header_Panel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.DownloadSpeed);
            this.panel1.Controls.Add(this.DiscordIcon);
            this.panel1.Controls.Add(this.NotifyButton_Menu);
            this.panel1.Controls.Add(this.KeyIcon);
            this.panel1.Controls.Add(this.UpdateStatusIcon);
            this.panel1.Controls.Add(this.ConnIcon);
            this.panel1.Controls.Add(this.DownloadIcon);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.MarikHack_TeamMenu);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.SettingsButton_Menu);
            this.panel1.Controls.Add(this.ZEngine_TeamMenu);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 463);
            this.panel1.TabIndex = 2;
            // 
            // DownloadSpeed
            // 
            this.DownloadSpeed.AutoSize = true;
            this.DownloadSpeed.ForeColor = System.Drawing.Color.White;
            this.DownloadSpeed.Location = new System.Drawing.Point(43, 409);
            this.DownloadSpeed.Name = "DownloadSpeed";
            this.DownloadSpeed.Size = new System.Drawing.Size(0, 13);
            this.DownloadSpeed.TabIndex = 30;
            // 
            // DiscordIcon
            // 
            this.DiscordIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiscordIcon.Image = ((System.Drawing.Image)(resources.GetObject("DiscordIcon.Image")));
            this.DiscordIcon.Location = new System.Drawing.Point(133, 425);
            this.DiscordIcon.Name = "DiscordIcon";
            this.DiscordIcon.Size = new System.Drawing.Size(37, 34);
            this.DiscordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DiscordIcon.TabIndex = 29;
            this.DiscordIcon.TabStop = false;
            this.DiscordIcon.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // NotifyButton_Menu
            // 
            this.NotifyButton_Menu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.NotifyButton_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.NotifyButton_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NotifyButton_Menu.BorderRadius = 0;
            this.NotifyButton_Menu.ButtonText = "Оповещения";
            this.NotifyButton_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotifyButton_Menu.DisabledColor = System.Drawing.Color.Gray;
            this.NotifyButton_Menu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NotifyButton_Menu.Iconcolor = System.Drawing.Color.Transparent;
            this.NotifyButton_Menu.Iconimage = ((System.Drawing.Image)(resources.GetObject("NotifyButton_Menu.Iconimage")));
            this.NotifyButton_Menu.Iconimage_right = null;
            this.NotifyButton_Menu.Iconimage_right_Selected = null;
            this.NotifyButton_Menu.Iconimage_Selected = null;
            this.NotifyButton_Menu.IconMarginLeft = 0;
            this.NotifyButton_Menu.IconMarginRight = 0;
            this.NotifyButton_Menu.IconRightVisible = true;
            this.NotifyButton_Menu.IconRightZoom = 0D;
            this.NotifyButton_Menu.IconVisible = true;
            this.NotifyButton_Menu.IconZoom = 60D;
            this.NotifyButton_Menu.IsTab = true;
            this.NotifyButton_Menu.Location = new System.Drawing.Point(1, 171);
            this.NotifyButton_Menu.Name = "NotifyButton_Menu";
            this.NotifyButton_Menu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.NotifyButton_Menu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.NotifyButton_Menu.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.NotifyButton_Menu.selected = true;
            this.NotifyButton_Menu.Size = new System.Drawing.Size(218, 45);
            this.NotifyButton_Menu.TabIndex = 28;
            this.NotifyButton_Menu.Text = "Оповещения";
            this.NotifyButton_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotifyButton_Menu.Textcolor = System.Drawing.Color.White;
            this.NotifyButton_Menu.TextFont = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotifyButton_Menu.Click += new System.EventHandler(this.NotifyButton_Menu_Click);
            // 
            // KeyIcon
            // 
            this.KeyIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyIcon.Image = ((System.Drawing.Image)(resources.GetObject("KeyIcon.Image")));
            this.KeyIcon.Location = new System.Drawing.Point(176, 425);
            this.KeyIcon.Name = "KeyIcon";
            this.KeyIcon.Size = new System.Drawing.Size(37, 34);
            this.KeyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KeyIcon.TabIndex = 27;
            this.KeyIcon.TabStop = false;
            this.KeyIcon.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // UpdateStatusIcon
            // 
            this.UpdateStatusIcon.Cursor = System.Windows.Forms.Cursors.Help;
            this.UpdateStatusIcon.Location = new System.Drawing.Point(90, 426);
            this.UpdateStatusIcon.Name = "UpdateStatusIcon";
            this.UpdateStatusIcon.Size = new System.Drawing.Size(37, 34);
            this.UpdateStatusIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UpdateStatusIcon.TabIndex = 26;
            this.UpdateStatusIcon.TabStop = false;
            // 
            // ConnIcon
            // 
            this.ConnIcon.Cursor = System.Windows.Forms.Cursors.Help;
            this.ConnIcon.Location = new System.Drawing.Point(4, 426);
            this.ConnIcon.Name = "ConnIcon";
            this.ConnIcon.Size = new System.Drawing.Size(37, 34);
            this.ConnIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ConnIcon.TabIndex = 25;
            this.ConnIcon.TabStop = false;
            // 
            // DownloadIcon
            // 
            this.DownloadIcon.Cursor = System.Windows.Forms.Cursors.Help;
            this.DownloadIcon.Location = new System.Drawing.Point(47, 426);
            this.DownloadIcon.Name = "DownloadIcon";
            this.DownloadIcon.Size = new System.Drawing.Size(37, 34);
            this.DownloadIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DownloadIcon.TabIndex = 23;
            this.DownloadIcon.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 181);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Corbel", 16.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(9, 136);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(70, 27);
            this.bunifuCustomLabel2.TabIndex = 20;
            this.bunifuCustomLabel2.Text = "Меню";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // MarikHack_TeamMenu
            // 
            this.MarikHack_TeamMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.MarikHack_TeamMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.MarikHack_TeamMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MarikHack_TeamMenu.BorderRadius = 0;
            this.MarikHack_TeamMenu.ButtonText = " Mar1k Cheats";
            this.MarikHack_TeamMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MarikHack_TeamMenu.DisabledColor = System.Drawing.Color.Transparent;
            this.MarikHack_TeamMenu.Enabled = false;
            this.MarikHack_TeamMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MarikHack_TeamMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.MarikHack_TeamMenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("MarikHack_TeamMenu.Iconimage")));
            this.MarikHack_TeamMenu.Iconimage_right = null;
            this.MarikHack_TeamMenu.Iconimage_right_Selected = null;
            this.MarikHack_TeamMenu.Iconimage_Selected = null;
            this.MarikHack_TeamMenu.IconMarginLeft = 0;
            this.MarikHack_TeamMenu.IconMarginRight = 0;
            this.MarikHack_TeamMenu.IconRightVisible = true;
            this.MarikHack_TeamMenu.IconRightZoom = 0D;
            this.MarikHack_TeamMenu.IconVisible = true;
            this.MarikHack_TeamMenu.IconZoom = 90D;
            this.MarikHack_TeamMenu.IsTab = true;
            this.MarikHack_TeamMenu.Location = new System.Drawing.Point(2, 83);
            this.MarikHack_TeamMenu.Name = "MarikHack_TeamMenu";
            this.MarikHack_TeamMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.MarikHack_TeamMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.MarikHack_TeamMenu.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.MarikHack_TeamMenu.selected = false;
            this.MarikHack_TeamMenu.Size = new System.Drawing.Size(218, 45);
            this.MarikHack_TeamMenu.TabIndex = 13;
            this.MarikHack_TeamMenu.Text = " Mar1k Cheats";
            this.MarikHack_TeamMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MarikHack_TeamMenu.Textcolor = System.Drawing.Color.Gray;
            this.MarikHack_TeamMenu.TextFont = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarikHack_TeamMenu.Click += new System.EventHandler(this.StatMenu_Button_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(1, 122);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(216, 10);
            this.bunifuSeparator2.TabIndex = 9;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // SettingsButton_Menu
            // 
            this.SettingsButton_Menu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.SettingsButton_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.SettingsButton_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsButton_Menu.BorderRadius = 0;
            this.SettingsButton_Menu.ButtonText = "Настройки";
            this.SettingsButton_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton_Menu.DisabledColor = System.Drawing.Color.Gray;
            this.SettingsButton_Menu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SettingsButton_Menu.Iconcolor = System.Drawing.Color.Transparent;
            this.SettingsButton_Menu.Iconimage = ((System.Drawing.Image)(resources.GetObject("SettingsButton_Menu.Iconimage")));
            this.SettingsButton_Menu.Iconimage_right = null;
            this.SettingsButton_Menu.Iconimage_right_Selected = null;
            this.SettingsButton_Menu.Iconimage_Selected = null;
            this.SettingsButton_Menu.IconMarginLeft = 0;
            this.SettingsButton_Menu.IconMarginRight = 0;
            this.SettingsButton_Menu.IconRightVisible = true;
            this.SettingsButton_Menu.IconRightZoom = 0D;
            this.SettingsButton_Menu.IconVisible = true;
            this.SettingsButton_Menu.IconZoom = 60D;
            this.SettingsButton_Menu.IsTab = true;
            this.SettingsButton_Menu.Location = new System.Drawing.Point(2, 214);
            this.SettingsButton_Menu.Name = "SettingsButton_Menu";
            this.SettingsButton_Menu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.SettingsButton_Menu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.SettingsButton_Menu.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.SettingsButton_Menu.selected = false;
            this.SettingsButton_Menu.Size = new System.Drawing.Size(218, 45);
            this.SettingsButton_Menu.TabIndex = 8;
            this.SettingsButton_Menu.Text = "Настройки";
            this.SettingsButton_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton_Menu.Textcolor = System.Drawing.Color.White;
            this.SettingsButton_Menu.TextFont = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton_Menu.Click += new System.EventHandler(this.SettingsButton_Menu_Click);
            // 
            // ZEngine_TeamMenu
            // 
            this.ZEngine_TeamMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ZEngine_TeamMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ZEngine_TeamMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ZEngine_TeamMenu.BorderRadius = 0;
            this.ZEngine_TeamMenu.ButtonText = " ZEngine";
            this.ZEngine_TeamMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZEngine_TeamMenu.DisabledColor = System.Drawing.Color.Transparent;
            this.ZEngine_TeamMenu.Enabled = false;
            this.ZEngine_TeamMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ZEngine_TeamMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.ZEngine_TeamMenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("ZEngine_TeamMenu.Iconimage")));
            this.ZEngine_TeamMenu.Iconimage_right = null;
            this.ZEngine_TeamMenu.Iconimage_right_Selected = null;
            this.ZEngine_TeamMenu.Iconimage_Selected = null;
            this.ZEngine_TeamMenu.IconMarginLeft = 0;
            this.ZEngine_TeamMenu.IconMarginRight = 0;
            this.ZEngine_TeamMenu.IconRightVisible = true;
            this.ZEngine_TeamMenu.IconRightZoom = 0D;
            this.ZEngine_TeamMenu.IconVisible = true;
            this.ZEngine_TeamMenu.IconZoom = 90D;
            this.ZEngine_TeamMenu.IsTab = true;
            this.ZEngine_TeamMenu.Location = new System.Drawing.Point(0, 37);
            this.ZEngine_TeamMenu.Name = "ZEngine_TeamMenu";
            this.ZEngine_TeamMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ZEngine_TeamMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ZEngine_TeamMenu.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.ZEngine_TeamMenu.selected = false;
            this.ZEngine_TeamMenu.Size = new System.Drawing.Size(220, 45);
            this.ZEngine_TeamMenu.TabIndex = 4;
            this.ZEngine_TeamMenu.Text = " ZEngine";
            this.ZEngine_TeamMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ZEngine_TeamMenu.Textcolor = System.Drawing.Color.Gray;
            this.ZEngine_TeamMenu.TextFont = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZEngine_TeamMenu.Click += new System.EventHandler(this.NewButton_Menu_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(2, 35);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(216, 10);
            this.bunifuSeparator1.TabIndex = 3;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Corbel", 16.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(42, 6);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(103, 27);
            this.bunifuCustomLabel4.TabIndex = 1;
            this.bunifuCustomLabel4.Text = "Команды";
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(219, 64);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(729, 463);
            this.ContentPanel.TabIndex = 3;
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "ZEngine Hack";
            this.NotifyIcon.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NotifyMenu_Maximized,
            this.NotifyMenu_CheckUpdates,
            this.toolStripSeparator1,
            this.NotifyMenu_Exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 76);
            // 
            // NotifyMenu_Maximized
            // 
            this.NotifyMenu_Maximized.Image = ((System.Drawing.Image)(resources.GetObject("NotifyMenu_Maximized.Image")));
            this.NotifyMenu_Maximized.Name = "NotifyMenu_Maximized";
            this.NotifyMenu_Maximized.Size = new System.Drawing.Size(173, 22);
            this.NotifyMenu_Maximized.Text = "Развернуть";
            this.NotifyMenu_Maximized.Click += new System.EventHandler(this.NotifyMenu_Maximized_Click);
            // 
            // NotifyMenu_CheckUpdates
            // 
            this.NotifyMenu_CheckUpdates.Image = ((System.Drawing.Image)(resources.GetObject("NotifyMenu_CheckUpdates.Image")));
            this.NotifyMenu_CheckUpdates.Name = "NotifyMenu_CheckUpdates";
            this.NotifyMenu_CheckUpdates.Size = new System.Drawing.Size(173, 22);
            this.NotifyMenu_CheckUpdates.Text = "Перейти в Discord";
            this.NotifyMenu_CheckUpdates.Click += new System.EventHandler(this.NotifyMenu_CheckUpdates_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // NotifyMenu_Exit
            // 
            this.NotifyMenu_Exit.Image = ((System.Drawing.Image)(resources.GetObject("NotifyMenu_Exit.Image")));
            this.NotifyMenu_Exit.Name = "NotifyMenu_Exit";
            this.NotifyMenu_Exit.Size = new System.Drawing.Size(173, 22);
            this.NotifyMenu_Exit.Text = "Выйти";
            this.NotifyMenu_Exit.Click += new System.EventHandler(this.NotifyMenu_Exit_Click);
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(948, 527);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header_Panel);
            this.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneralForm";
            this.Text = "ZEngine Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Header_Panel.ResumeLayout(false);
            this.Header_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateStatusIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Header_Panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel VersionLabel_Header;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuFlatButton ZEngine_TeamMenu;
        private Bunifu.Framework.UI.BunifuFlatButton SettingsButton_Menu;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuFlatButton MarikHack_TeamMenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NotifyMenu_Maximized;
        private System.Windows.Forms.ToolStripMenuItem NotifyMenu_CheckUpdates;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem NotifyMenu_Exit;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        internal System.Windows.Forms.PictureBox DownloadIcon;
        internal System.Windows.Forms.PictureBox UpdateStatusIcon;
        internal System.Windows.Forms.PictureBox ConnIcon;
        internal System.Windows.Forms.PictureBox KeyIcon;
        private Bunifu.Framework.UI.BunifuFlatButton NotifyButton_Menu;
        public System.Windows.Forms.Label DownloadSpeed;
        public System.Windows.Forms.PictureBox DiscordIcon;
    }
}

