namespace ConnectionTester
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OutStatus = new System.Windows.Forms.Label();
            this.ConnectionInfo = new System.Windows.Forms.PictureBox();
            this.DiscordInfo = new System.Windows.Forms.PictureBox();
            this.UpdateInfo = new System.Windows.Forms.PictureBox();
            this.LicenseInfo = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.DaysLabel = new System.Windows.Forms.Label();
            this.StatusProgressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.HeadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscordInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LicenseInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HeadPanel.Controls.Add(this.pictureBox1);
            this.HeadPanel.Controls.Add(this.MinimizeButton);
            this.HeadPanel.Controls.Add(this.CloseButton);
            this.HeadPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(281, 31);
            this.HeadPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.AutoSize = true;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(240, 6);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(14, 13);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(258, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(15, 13);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.OutStatus);
            this.panel2.Controls.Add(this.ConnectionInfo);
            this.panel2.Controls.Add(this.DiscordInfo);
            this.panel2.Controls.Add(this.UpdateInfo);
            this.panel2.Controls.Add(this.LicenseInfo);
            this.panel2.Location = new System.Drawing.Point(0, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 31);
            this.panel2.TabIndex = 1;
            // 
            // OutStatus
            // 
            this.OutStatus.AutoSize = true;
            this.OutStatus.Location = new System.Drawing.Point(44, 8);
            this.OutStatus.Name = "OutStatus";
            this.OutStatus.Size = new System.Drawing.Size(0, 13);
            this.OutStatus.TabIndex = 5;
            // 
            // ConnectionInfo
            // 
            this.ConnectionInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectionInfo.Image = ((System.Drawing.Image)(resources.GetObject("ConnectionInfo.Image")));
            this.ConnectionInfo.Location = new System.Drawing.Point(247, 1);
            this.ConnectionInfo.Name = "ConnectionInfo";
            this.ConnectionInfo.Size = new System.Drawing.Size(34, 28);
            this.ConnectionInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ConnectionInfo.TabIndex = 4;
            this.ConnectionInfo.TabStop = false;
            // 
            // DiscordInfo
            // 
            this.DiscordInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DiscordInfo.Image = ((System.Drawing.Image)(resources.GetObject("DiscordInfo.Image")));
            this.DiscordInfo.Location = new System.Drawing.Point(2, 1);
            this.DiscordInfo.Name = "DiscordInfo";
            this.DiscordInfo.Size = new System.Drawing.Size(34, 28);
            this.DiscordInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DiscordInfo.TabIndex = 3;
            this.DiscordInfo.TabStop = false;
            // 
            // UpdateInfo
            // 
            this.UpdateInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateInfo.Image = ((System.Drawing.Image)(resources.GetObject("UpdateInfo.Image")));
            this.UpdateInfo.Location = new System.Drawing.Point(181, 1);
            this.UpdateInfo.Name = "UpdateInfo";
            this.UpdateInfo.Size = new System.Drawing.Size(34, 28);
            this.UpdateInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UpdateInfo.TabIndex = 2;
            this.UpdateInfo.TabStop = false;
            // 
            // LicenseInfo
            // 
            this.LicenseInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LicenseInfo.Image = ((System.Drawing.Image)(resources.GetObject("LicenseInfo.Image")));
            this.LicenseInfo.Location = new System.Drawing.Point(214, 1);
            this.LicenseInfo.Name = "LicenseInfo";
            this.LicenseInfo.Size = new System.Drawing.Size(34, 28);
            this.LicenseInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LicenseInfo.TabIndex = 1;
            this.LicenseInfo.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.HeadPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(7, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Состояние: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(7, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Остаток дней: ";
            // 
            // StartButton
            // 
            this.StartButton.ActiveBorderThickness = 1;
            this.StartButton.ActiveCornerRadius = 20;
            this.StartButton.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.StartButton.ActiveForecolor = System.Drawing.Color.White;
            this.StartButton.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.StartButton.BackColor = System.Drawing.SystemColors.Control;
            this.StartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartButton.BackgroundImage")));
            this.StartButton.ButtonText = "Запустить";
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.StartButton.IdleBorderThickness = 1;
            this.StartButton.IdleCornerRadius = 20;
            this.StartButton.IdleFillColor = System.Drawing.SystemColors.Control;
            this.StartButton.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.StartButton.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.StartButton.Location = new System.Drawing.Point(50, 155);
            this.StartButton.Margin = new System.Windows.Forms.Padding(5);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(181, 41);
            this.StartButton.TabIndex = 4;
            this.StartButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(78, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "PUBG ESP";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 65);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(270, 10);
            this.bunifuSeparator1.TabIndex = 6;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.StatusLabel.Location = new System.Drawing.Point(151, 82);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 20);
            this.StatusLabel.TabIndex = 7;
            // 
            // DaysLabel
            // 
            this.DaysLabel.AutoSize = true;
            this.DaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.DaysLabel.Location = new System.Drawing.Point(152, 113);
            this.DaysLabel.Name = "DaysLabel";
            this.DaysLabel.Size = new System.Drawing.Size(0, 20);
            this.DaysLabel.TabIndex = 8;
            // 
            // StatusProgressBar
            // 
            this.StatusProgressBar.BackColor = System.Drawing.Color.Silver;
            this.StatusProgressBar.BorderRadius = 5;
            this.StatusProgressBar.Location = new System.Drawing.Point(-2, 202);
            this.StatusProgressBar.MaximumValue = 100;
            this.StatusProgressBar.Name = "StatusProgressBar";
            this.StatusProgressBar.ProgressColor = System.Drawing.Color.Teal;
            this.StatusProgressBar.Size = new System.Drawing.Size(286, 10);
            this.StatusProgressBar.TabIndex = 9;
            this.StatusProgressBar.Value = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 243);
            this.Controls.Add(this.StatusProgressBar);
            this.Controls.Add(this.DaysLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HeadPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscordInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LicenseInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MinimizeButton;
        private System.Windows.Forms.Label CloseButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox ConnectionInfo;
        private System.Windows.Forms.PictureBox DiscordInfo;
        private System.Windows.Forms.PictureBox UpdateInfo;
        private System.Windows.Forms.PictureBox LicenseInfo;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 StartButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DaysLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label OutStatus;
        private Bunifu.Framework.UI.BunifuProgressBar StatusProgressBar;
    }
}