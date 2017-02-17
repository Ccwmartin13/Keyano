namespace Keyano
{
    partial class Keyano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keyano));
            this.KeyboardDisplay = new System.Windows.Forms.PictureBox();
            this.PianoKey = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.KeyboardDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PianoKey)).BeginInit();
            this.SuspendLayout();
            // 
            // KeyboardDisplay
            // 
            this.KeyboardDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyboardDisplay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("KeyboardDisplay.BackgroundImage")));
            this.KeyboardDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.KeyboardDisplay.Location = new System.Drawing.Point(62, 273);
            this.KeyboardDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.KeyboardDisplay.Name = "KeyboardDisplay";
            this.KeyboardDisplay.Size = new System.Drawing.Size(704, 175);
            this.KeyboardDisplay.TabIndex = 0;
            this.KeyboardDisplay.TabStop = false;
            // 
            // PianoKey
            // 
            this.PianoKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PianoKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PianoKey.BackgroundImage")));
            this.PianoKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PianoKey.Location = new System.Drawing.Point(62, 41);
            this.PianoKey.Margin = new System.Windows.Forms.Padding(2);
            this.PianoKey.Name = "PianoKey";
            this.PianoKey.Size = new System.Drawing.Size(704, 203);
            this.PianoKey.TabIndex = 1;
            this.PianoKey.TabStop = false;
            // 
            // Keyano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(815, 517);
            this.Controls.Add(this.PianoKey);
            this.Controls.Add(this.KeyboardDisplay);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Keyano";
            this.Text = "Keyano";
            this.Load += new System.EventHandler(this.Keyano_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KeyboardDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PianoKey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox KeyboardDisplay;
        private System.Windows.Forms.PictureBox PianoKey;
    }
}

