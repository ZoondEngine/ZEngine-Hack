namespace ZEngine_RED.UI.Messages
{
    partial class License
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.OKButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 26);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "License Message Box";
            // 
            // OKButton
            // 
            this.OKButton.Activecolor = System.Drawing.Color.Firebrick;
            this.OKButton.BackColor = System.Drawing.Color.Firebrick;
            this.OKButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OKButton.BorderRadius = 0;
            this.OKButton.ButtonText = "OK";
            this.OKButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OKButton.DisabledColor = System.Drawing.Color.Gray;
            this.OKButton.Iconcolor = System.Drawing.Color.Transparent;
            this.OKButton.Iconimage = null;
            this.OKButton.Iconimage_right = null;
            this.OKButton.Iconimage_right_Selected = null;
            this.OKButton.Iconimage_Selected = null;
            this.OKButton.IconMarginLeft = 0;
            this.OKButton.IconMarginRight = 0;
            this.OKButton.IconRightVisible = true;
            this.OKButton.IconRightZoom = 0D;
            this.OKButton.IconVisible = true;
            this.OKButton.IconZoom = 90D;
            this.OKButton.IsTab = false;
            this.OKButton.Location = new System.Drawing.Point(83, 196);
            this.OKButton.Name = "OKButton";
            this.OKButton.Normalcolor = System.Drawing.Color.Firebrick;
            this.OKButton.OnHovercolor = System.Drawing.Color.DarkRed;
            this.OKButton.OnHoverTextColor = System.Drawing.Color.White;
            this.OKButton.selected = false;
            this.OKButton.Size = new System.Drawing.Size(181, 31);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OKButton.Textcolor = System.Drawing.Color.White;
            this.OKButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionBox.Font = new System.Drawing.Font("Sitka Banner", 11.75F);
            this.DescriptionBox.Location = new System.Drawing.Point(11, 68);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.DescriptionBox.Size = new System.Drawing.Size(309, 103);
            this.DescriptionBox.TabIndex = 2;
            this.DescriptionBox.Text = "";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Sitka Banner", 10.75F);
            this.DescriptionLabel.Location = new System.Drawing.Point(7, 39);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(40, 21);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "label1";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.DimGray;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 177);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(331, 16);
            this.bunifuSeparator1.TabIndex = 4;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(332, 239);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "License";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "License";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private Bunifu.Framework.UI.BunifuFlatButton OKButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}