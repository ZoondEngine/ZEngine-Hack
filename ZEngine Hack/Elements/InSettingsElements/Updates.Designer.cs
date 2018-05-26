namespace ZEngine_Hack.Elements.InSettingsElements
{
    partial class Updates
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SetDateDatepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.AutoUpdateSwitch = new Bunifu.Framework.UI.BunifuSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HowDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.SpeedSlider = new Bunifu.Framework.UI.BunifuSlider();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.SpeedSlider);
            this.panel1.Controls.Add(this.HowDropdown);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TypeDropdown);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AutoUpdateSwitch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SetDateDatepicker);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 348);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Обновить в определенную дату";
            // 
            // SetDateDatepicker
            // 
            this.SetDateDatepicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.SetDateDatepicker.BorderRadius = 0;
            this.SetDateDatepicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.SetDateDatepicker.ForeColor = System.Drawing.Color.White;
            this.SetDateDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.SetDateDatepicker.FormatCustom = null;
            this.SetDateDatepicker.Location = new System.Drawing.Point(382, 132);
            this.SetDateDatepicker.Name = "SetDateDatepicker";
            this.SetDateDatepicker.Size = new System.Drawing.Size(308, 30);
            this.SetDateDatepicker.TabIndex = 0;
            this.SetDateDatepicker.Value = new System.DateTime(2018, 3, 11, 4, 13, 14, 64);
            // 
            // AutoUpdateSwitch
            // 
            this.AutoUpdateSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AutoUpdateSwitch.BorderRadius = 0;
            this.AutoUpdateSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoUpdateSwitch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AutoUpdateSwitch.Location = new System.Drawing.Point(621, 31);
            this.AutoUpdateSwitch.Name = "AutoUpdateSwitch";
            this.AutoUpdateSwitch.Oncolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.AutoUpdateSwitch.Onoffcolor = System.Drawing.Color.DarkGray;
            this.AutoUpdateSwitch.Size = new System.Drawing.Size(51, 19);
            this.AutoUpdateSwitch.TabIndex = 2;
            this.AutoUpdateSwitch.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AutoUpdateSwitch.Value = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Включить автоматические обновления";
            // 
            // TypeDropdown
            // 
            this.TypeDropdown.BackColor = System.Drawing.Color.Transparent;
            this.TypeDropdown.BorderRadius = 3;
            this.TypeDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.TypeDropdown.ForeColor = System.Drawing.Color.White;
            this.TypeDropdown.Items = new string[] {
        "ВСЕ",
        "МИНОР",
        "ВАЖНЫЕ",
        "КРИТИЧЕСКИЕ"};
            this.TypeDropdown.Location = new System.Drawing.Point(257, 80);
            this.TypeDropdown.Name = "TypeDropdown";
            this.TypeDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.TypeDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(234)))));
            this.TypeDropdown.selectedIndex = -1;
            this.TypeDropdown.Size = new System.Drawing.Size(164, 26);
            this.TypeDropdown.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Устанавливать только ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(427, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Обновлять";
            // 
            // HowDropdown
            // 
            this.HowDropdown.BackColor = System.Drawing.Color.Transparent;
            this.HowDropdown.BorderRadius = 3;
            this.HowDropdown.DisabledColor = System.Drawing.Color.Gray;
            this.HowDropdown.ForeColor = System.Drawing.Color.White;
            this.HowDropdown.Items = new string[] {
        "ВСЕГДА",
        "УТРОМ",
        "ДНЕМ",
        "НОЧЬЮ"};
            this.HowDropdown.Location = new System.Drawing.Point(553, 78);
            this.HowDropdown.Name = "HowDropdown";
            this.HowDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.HowDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(234)))));
            this.HowDropdown.selectedIndex = -1;
            this.HowDropdown.Size = new System.Drawing.Size(137, 26);
            this.HowDropdown.TabIndex = 7;
            // 
            // SpeedSlider
            // 
            this.SpeedSlider.BackColor = System.Drawing.Color.Transparent;
            this.SpeedSlider.BackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpeedSlider.BorderRadius = 0;
            this.SpeedSlider.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(214)))));
            this.SpeedSlider.Location = new System.Drawing.Point(17, 275);
            this.SpeedSlider.MaximumValue = 2000;
            this.SpeedSlider.Name = "SpeedSlider";
            this.SpeedSlider.Size = new System.Drawing.Size(670, 30);
            this.SpeedSlider.TabIndex = 9;
            this.SpeedSlider.Value = 800;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(225, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Скорость загрузки: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "100 кб/с";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(644, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "MAX";
            // 
            // Updates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.panel1);
            this.Name = "Updates";
            this.Size = new System.Drawing.Size(703, 348);
            this.Load += new System.EventHandler(this.Updates_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDatepicker SetDateDatepicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuSlider SpeedSlider;
        private Bunifu.Framework.UI.BunifuDropdown HowDropdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDropdown TypeDropdown;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSwitch AutoUpdateSwitch;
    }
}
