namespace FNAE2
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
            this.StartButton = new System.Windows.Forms.Button();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.SettingTitle = new System.Windows.Forms.Label();
            this.FullscreenLabel = new System.Windows.Forms.Label();
            this.BackLabel = new System.Windows.Forms.Label();
            this.MapImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MapImage)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(361, 182);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // OptionsButton
            // 
            this.OptionsButton.Location = new System.Drawing.Point(361, 210);
            this.OptionsButton.Margin = new System.Windows.Forms.Padding(2);
            this.OptionsButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(75, 23);
            this.OptionsButton.TabIndex = 2;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.UseVisualStyleBackColor = true;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // SettingTitle
            // 
            this.SettingTitle.AutoSize = true;
            this.SettingTitle.BackColor = System.Drawing.Color.Transparent;
            this.SettingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingTitle.Location = new System.Drawing.Point(10, 9);
            this.SettingTitle.Name = "SettingTitle";
            this.SettingTitle.Size = new System.Drawing.Size(265, 73);
            this.SettingTitle.TabIndex = 3;
            this.SettingTitle.Text = "Settings";
            this.SettingTitle.Visible = false;
            // 
            // FullscreenLabel
            // 
            this.FullscreenLabel.AutoSize = true;
            this.FullscreenLabel.BackColor = System.Drawing.Color.Transparent;
            this.FullscreenLabel.Location = new System.Drawing.Point(15, 135);
            this.FullscreenLabel.Name = "FullscreenLabel";
            this.FullscreenLabel.Size = new System.Drawing.Size(97, 13);
            this.FullscreenLabel.TabIndex = 5;
            this.FullscreenLabel.Text = "Fullscreen   |   True";
            this.FullscreenLabel.Visible = false;
            this.FullscreenLabel.Click += new System.EventHandler(this.FullscreenLabel_Click);
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Location = new System.Drawing.Point(713, 394);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(32, 13);
            this.BackLabel.TabIndex = 6;
            this.BackLabel.Text = "Back";
            this.BackLabel.Visible = false;
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click);
            // 
            // MapImage
            // 
            this.MapImage.BackColor = System.Drawing.Color.Transparent;
            this.MapImage.Location = new System.Drawing.Point(0, 370);
            this.MapImage.Name = "MapImage";
            this.MapImage.Size = new System.Drawing.Size(151, 74);
            this.MapImage.TabIndex = 7;
            this.MapImage.TabStop = false;
            this.MapImage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FNAE2.Properties.Resources.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MapImage);
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.FullscreenLabel);
            this.Controls.Add(this.SettingTitle);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.StartButton);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.MapImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.Label SettingTitle;
        private System.Windows.Forms.Label FullscreenLabel;
        private System.Windows.Forms.Label BackLabel;
        private System.Windows.Forms.PictureBox MapImage;
    }
}

