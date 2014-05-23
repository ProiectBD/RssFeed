namespace RssFeed
{
    partial class Form1
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
            this.RefreshB = new System.Windows.Forms.Button();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.ChannelTB = new System.Windows.Forms.TextBox();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.titlesCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RefreshB
            // 
            this.RefreshB.Location = new System.Drawing.Point(378, 5);
            this.RefreshB.Name = "RefreshB";
            this.RefreshB.Size = new System.Drawing.Size(75, 23);
            this.RefreshB.TabIndex = 0;
            this.RefreshB.Text = "Refresh";
            this.RefreshB.UseVisualStyleBackColor = true;
            this.RefreshB.Click += new System.EventHandler(this.RefreshB_Click);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(0, 299);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(34, 13);
            this.linkLabel.TabIndex = 2;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "go to:";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // ChannelTB
            // 
            this.ChannelTB.Location = new System.Drawing.Point(3, 5);
            this.ChannelTB.Name = "ChannelTB";
            this.ChannelTB.Size = new System.Drawing.Size(369, 20);
            this.ChannelTB.TabIndex = 3;
            this.ChannelTB.Text = "Alege Site";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Location = new System.Drawing.Point(3, 60);
            this.DescriptionTB.Multiline = true;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(450, 226);
            this.DescriptionTB.TabIndex = 4;
            // 
            // titlesCB
            // 
            this.titlesCB.FormattingEnabled = true;
            this.titlesCB.Location = new System.Drawing.Point(3, 33);
            this.titlesCB.Name = "titlesCB";
            this.titlesCB.Size = new System.Drawing.Size(450, 21);
            this.titlesCB.TabIndex = 5;
            this.titlesCB.SelectedIndexChanged += new System.EventHandler(this.titlesCB_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 319);
            this.Controls.Add(this.titlesCB);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.ChannelTB);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.RefreshB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshB;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.TextBox ChannelTB;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.ComboBox titlesCB;
    }
}

