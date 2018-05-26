namespace ZEngine_Account_Manager
{
    partial class Form1
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
            this.ResellerNickNameTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ActivateBTN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DaysCountTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NotifyPanel = new System.Windows.Forms.Panel();
            this.NotifyMsg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HwidTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.ResellerIDTB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.HeaderPanel.SuspendLayout();
            this.NotifyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResellerNickNameTB
            // 
            this.ResellerNickNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ResellerNickNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.ResellerNickNameTB.ForeColor = System.Drawing.Color.OrangeRed;
            this.ResellerNickNameTB.HintForeColor = System.Drawing.Color.Tomato;
            this.ResellerNickNameTB.HintText = "";
            this.ResellerNickNameTB.isPassword = false;
            this.ResellerNickNameTB.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.ResellerNickNameTB.LineIdleColor = System.Drawing.Color.Gray;
            this.ResellerNickNameTB.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.ResellerNickNameTB.LineThickness = 5;
            this.ResellerNickNameTB.Location = new System.Drawing.Point(159, 94);
            this.ResellerNickNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.ResellerNickNameTB.Name = "ResellerNickNameTB";
            this.ResellerNickNameTB.Size = new System.Drawing.Size(104, 43);
            this.ResellerNickNameTB.TabIndex = 0;
            this.ResellerNickNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Tomato;
            this.HeaderPanel.Controls.Add(this.label4);
            this.HeaderPanel.Controls.Add(this.label3);
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(440, 53);
            this.HeaderPanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(369, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "_";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(402, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZEngine Account Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reseller Account:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(11, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Days count:";
            // 
            // ActivateBTN
            // 
            this.ActivateBTN.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ActivateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ActivateBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ActivateBTN.BorderRadius = 0;
            this.ActivateBTN.ButtonText = "Активировать";
            this.ActivateBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ActivateBTN.DisabledColor = System.Drawing.Color.Gray;
            this.ActivateBTN.Iconcolor = System.Drawing.Color.Transparent;
            this.ActivateBTN.Iconimage = null;
            this.ActivateBTN.Iconimage_right = null;
            this.ActivateBTN.Iconimage_right_Selected = null;
            this.ActivateBTN.Iconimage_Selected = null;
            this.ActivateBTN.IconMarginLeft = 0;
            this.ActivateBTN.IconMarginRight = 0;
            this.ActivateBTN.IconRightVisible = true;
            this.ActivateBTN.IconRightZoom = 0D;
            this.ActivateBTN.IconVisible = true;
            this.ActivateBTN.IconZoom = 90D;
            this.ActivateBTN.IsTab = false;
            this.ActivateBTN.Location = new System.Drawing.Point(12, 229);
            this.ActivateBTN.Name = "ActivateBTN";
            this.ActivateBTN.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ActivateBTN.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ActivateBTN.OnHoverTextColor = System.Drawing.Color.White;
            this.ActivateBTN.selected = false;
            this.ActivateBTN.Size = new System.Drawing.Size(412, 41);
            this.ActivateBTN.TabIndex = 5;
            this.ActivateBTN.Text = "Активировать";
            this.ActivateBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ActivateBTN.Textcolor = System.Drawing.Color.White;
            this.ActivateBTN.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivateBTN.Click += new System.EventHandler(this.ActivateBTN_Click);
            // 
            // DaysCountTB
            // 
            this.DaysCountTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DaysCountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.DaysCountTB.ForeColor = System.Drawing.Color.OrangeRed;
            this.DaysCountTB.HintForeColor = System.Drawing.Color.Tomato;
            this.DaysCountTB.HintText = "";
            this.DaysCountTB.isPassword = false;
            this.DaysCountTB.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.DaysCountTB.LineIdleColor = System.Drawing.Color.Gray;
            this.DaysCountTB.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.DaysCountTB.LineThickness = 5;
            this.DaysCountTB.Location = new System.Drawing.Point(17, 176);
            this.DaysCountTB.Margin = new System.Windows.Forms.Padding(4);
            this.DaysCountTB.Name = "DaysCountTB";
            this.DaysCountTB.Size = new System.Drawing.Size(134, 43);
            this.DaysCountTB.TabIndex = 7;
            this.DaysCountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // NotifyPanel
            // 
            this.NotifyPanel.Controls.Add(this.NotifyMsg);
            this.NotifyPanel.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotifyPanel.Location = new System.Drawing.Point(0, 53);
            this.NotifyPanel.Name = "NotifyPanel";
            this.NotifyPanel.Size = new System.Drawing.Size(440, 47);
            this.NotifyPanel.TabIndex = 8;
            // 
            // NotifyMsg
            // 
            this.NotifyMsg.AutoSize = true;
            this.NotifyMsg.Font = new System.Drawing.Font("Corbel", 12.25F);
            this.NotifyMsg.Location = new System.Drawing.Point(13, 14);
            this.NotifyMsg.Name = "NotifyMsg";
            this.NotifyMsg.Size = new System.Drawing.Size(0, 21);
            this.NotifyMsg.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(233, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "User HWID:";
            // 
            // HwidTB
            // 
            this.HwidTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HwidTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.HwidTB.ForeColor = System.Drawing.Color.OrangeRed;
            this.HwidTB.HintForeColor = System.Drawing.Color.Tomato;
            this.HwidTB.HintText = "";
            this.HwidTB.isPassword = false;
            this.HwidTB.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.HwidTB.LineIdleColor = System.Drawing.Color.Gray;
            this.HwidTB.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.HwidTB.LineThickness = 5;
            this.HwidTB.Location = new System.Drawing.Point(187, 176);
            this.HwidTB.Margin = new System.Windows.Forms.Padding(4);
            this.HwidTB.Name = "HwidTB";
            this.HwidTB.Size = new System.Drawing.Size(228, 43);
            this.HwidTB.TabIndex = 10;
            this.HwidTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.HeaderPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(270, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "ID:";
            // 
            // ResellerIDTB
            // 
            this.ResellerIDTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ResellerIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.ResellerIDTB.ForeColor = System.Drawing.Color.OrangeRed;
            this.ResellerIDTB.HintForeColor = System.Drawing.Color.Tomato;
            this.ResellerIDTB.HintText = "";
            this.ResellerIDTB.isPassword = false;
            this.ResellerIDTB.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.ResellerIDTB.LineIdleColor = System.Drawing.Color.Gray;
            this.ResellerIDTB.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.ResellerIDTB.LineThickness = 5;
            this.ResellerIDTB.Location = new System.Drawing.Point(308, 93);
            this.ResellerIDTB.Margin = new System.Windows.Forms.Padding(4);
            this.ResellerIDTB.Name = "ResellerIDTB";
            this.ResellerIDTB.Size = new System.Drawing.Size(104, 45);
            this.ResellerIDTB.TabIndex = 12;
            this.ResellerIDTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(438, 281);
            this.Controls.Add(this.NotifyPanel);
            this.Controls.Add(this.ResellerIDTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HwidTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DaysCountTB);
            this.Controls.Add(this.ActivateBTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.ResellerNickNameTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.NotifyPanel.ResumeLayout(false);
            this.NotifyPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ResellerNickNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton ActivateBTN;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DaysCountTB;
        private System.Windows.Forms.Panel NotifyPanel;
        private System.Windows.Forms.Label NotifyMsg;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox HwidTB;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ResellerIDTB;
    }
}

