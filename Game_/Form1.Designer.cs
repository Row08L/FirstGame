
namespace Game_
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.startButton1 = new System.Windows.Forms.Button();
            this.countDown1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton1
            // 
            this.startButton1.BackColor = System.Drawing.SystemColors.Desktop;
            this.startButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton1.ForeColor = System.Drawing.Color.OrangeRed;
            this.startButton1.Location = new System.Drawing.Point(275, 80);
            this.startButton1.Name = "startButton1";
            this.startButton1.Size = new System.Drawing.Size(256, 61);
            this.startButton1.TabIndex = 0;
            this.startButton1.Text = "Play Game";
            this.startButton1.UseVisualStyleBackColor = false;
            this.startButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // countDown1
            // 
            this.countDown1.AutoSize = true;
            this.countDown1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDown1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.countDown1.Location = new System.Drawing.Point(388, 196);
            this.countDown1.Name = "countDown1";
            this.countDown1.Size = new System.Drawing.Size(0, 47);
            this.countDown1.TabIndex = 1;
            this.countDown1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.countDown1);
            this.Controls.Add(this.startButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Game?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label countDown1;
        private System.Windows.Forms.Button startButton1;
    }
}

