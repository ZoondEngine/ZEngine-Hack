namespace ZEngine_Admin
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeadMinimizePictureButton = new System.Windows.Forms.PictureBox();
            this.HeadClosePictureButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.AuthButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LoginTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PasswordTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeadMinimizePictureButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadClosePictureButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.HeadMinimizePictureButton);
            this.panel1.Controls.Add(this.HeadClosePictureButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 63);
            this.panel1.TabIndex = 2;
            // 
            // HeadMinimizePictureButton
            // 
            this.HeadMinimizePictureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HeadMinimizePictureButton.Image = ((System.Drawing.Image)(resources.GetObject("HeadMinimizePictureButton.Image")));
            this.HeadMinimizePictureButton.Location = new System.Drawing.Point(285, 15);
            this.HeadMinimizePictureButton.Name = "HeadMinimizePictureButton";
            this.HeadMinimizePictureButton.Size = new System.Drawing.Size(38, 33);
            this.HeadMinimizePictureButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HeadMinimizePictureButton.TabIndex = 3;
            this.HeadMinimizePictureButton.TabStop = false;
            this.HeadMinimizePictureButton.Click += new System.EventHandler(this.HeadMinimizePictureButton_Click);
            // 
            // HeadClosePictureButton
            // 
            this.HeadClosePictureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HeadClosePictureButton.Image = ((System.Drawing.Image)(resources.GetObject("HeadClosePictureButton.Image")));
            this.HeadClosePictureButton.Location = new System.Drawing.Point(329, 15);
            this.HeadClosePictureButton.Name = "HeadClosePictureButton";
            this.HeadClosePictureButton.Size = new System.Drawing.Size(38, 33);
            this.HeadClosePictureButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HeadClosePictureButton.TabIndex = 2;
            this.HeadClosePictureButton.TabStop = false;
            this.HeadClosePictureButton.Click += new System.EventHandler(this.HeadClosePictureButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(81, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // LoginDragControl
            // 
            this.LoginDragControl.Fixed = true;
            this.LoginDragControl.Horizontal = true;
            this.LoginDragControl.TargetControl = this;
            this.LoginDragControl.Vertical = true;
            // 
            // AuthButton
            // 
            this.AuthButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.AuthButton.BackColor = System.Drawing.Color.Gray;
            this.AuthButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AuthButton.BorderRadius = 0;
            this.AuthButton.ButtonText = "Авторизоваться";
            this.AuthButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthButton.DisabledColor = System.Drawing.Color.Gray;
            this.AuthButton.Iconcolor = System.Drawing.Color.Transparent;
            this.AuthButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("AuthButton.Iconimage")));
            this.AuthButton.Iconimage_right = null;
            this.AuthButton.Iconimage_right_Selected = null;
            this.AuthButton.Iconimage_Selected = null;
            this.AuthButton.IconMarginLeft = 0;
            this.AuthButton.IconMarginRight = 0;
            this.AuthButton.IconRightVisible = true;
            this.AuthButton.IconRightZoom = 0D;
            this.AuthButton.IconVisible = true;
            this.AuthButton.IconZoom = 80D;
            this.AuthButton.IsTab = false;
            this.AuthButton.Location = new System.Drawing.Point(101, 250);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Normalcolor = System.Drawing.Color.Gray;
            this.AuthButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.AuthButton.OnHoverTextColor = System.Drawing.Color.White;
            this.AuthButton.selected = false;
            this.AuthButton.Size = new System.Drawing.Size(184, 45);
            this.AuthButton.TabIndex = 3;
            this.AuthButton.Text = "Авторизоваться";
            this.AuthButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AuthButton.Textcolor = System.Drawing.Color.White;
            this.AuthButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.LoginTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.LoginTextBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.LoginTextBox.HintText = "";
            this.LoginTextBox.isPassword = false;
            this.LoginTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.LoginTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.LoginTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.LoginTextBox.LineThickness = 4;
            this.LoginTextBox.Location = new System.Drawing.Point(96, 107);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(242, 36);
            this.LoginTextBox.TabIndex = 4;
            this.LoginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.PasswordTextBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.PasswordTextBox.HintText = "";
            this.PasswordTextBox.isPassword = true;
            this.PasswordTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.PasswordTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.PasswordTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.PasswordTextBox.LineThickness = 4;
            this.PasswordTextBox.Location = new System.Drawing.Point(96, 172);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(242, 38);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(23, 116);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(64, 20);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Логин:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(12, 182);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(77, 20);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "Пароль:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(376, 307);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "ZEngine AT | Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeadMinimizePictureButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadClosePictureButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox HeadMinimizePictureButton;
        private System.Windows.Forms.PictureBox HeadClosePictureButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl LoginDragControl;
        private Bunifu.Framework.UI.BunifuFlatButton AuthButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PasswordTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LoginTextBox;
    }
}