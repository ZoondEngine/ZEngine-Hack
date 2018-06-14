namespace ZEngine_RED
{
    partial class InitializeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitializeWindow));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CloseButton = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InitializeText = new System.Windows.Forms.Label();
            this.InitializeProgressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(722, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(14, 13);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.AutoSize = true;
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimizeButton.Location = new System.Drawing.Point(704, 7);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(13, 13);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InitializeProgressBar);
            this.panel1.Controls.Add(this.InitializeText);
            this.panel1.Location = new System.Drawing.Point(-1, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 22);
            this.panel1.TabIndex = 3;
            // 
            // InitializeText
            // 
            this.InitializeText.AutoSize = true;
            this.InitializeText.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InitializeText.ForeColor = System.Drawing.Color.DarkOrange;
            this.InitializeText.Location = new System.Drawing.Point(5, 0);
            this.InitializeText.Name = "InitializeText";
            this.InitializeText.Size = new System.Drawing.Size(0, 19);
            this.InitializeText.TabIndex = 0;
            // 
            // InitializeProgressBar
            // 
            this.InitializeProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.InitializeProgressBar.BorderRadius = 5;
            this.InitializeProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.InitializeProgressBar.Location = new System.Drawing.Point(452, 6);
            this.InitializeProgressBar.MaximumValue = 100;
            this.InitializeProgressBar.Name = "InitializeProgressBar";
            this.InitializeProgressBar.ProgressColor = System.Drawing.Color.DarkOrange;
            this.InitializeProgressBar.Size = new System.Drawing.Size(285, 10);
            this.InitializeProgressBar.TabIndex = 2;
            this.InitializeProgressBar.Value = 25;
            // 
            // InitializeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(748, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InitializeWindow";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.InitializeWindow_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label MinimizeButton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label InitializeText;
        private Bunifu.Framework.UI.BunifuProgressBar InitializeProgressBar;
    }
}

