namespace KHAE
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
            this.v1 = new System.Windows.Forms.Button();
            this.v2 = new System.Windows.Forms.Button();
            this.alusta = new System.Windows.Forms.Button();
            this.Story = new System.Windows.Forms.TextBox();
            this.kapppic = new System.Windows.Forms.PictureBox();
            this.mainroompic = new System.Windows.Forms.PictureBox();
            this.mianpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kapppic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainroompic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mianpic)).BeginInit();
            this.SuspendLayout();
            // 
            // v1
            // 
            this.v1.Location = new System.Drawing.Point(398, 573);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(209, 40);
            this.v1.TabIndex = 1;
            this.v1.Text = "*****";
            this.v1.UseVisualStyleBackColor = true;
            this.v1.Click += new System.EventHandler(this.button1_Click);
            // 
            // v2
            // 
            this.v2.Location = new System.Drawing.Point(613, 573);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(216, 40);
            this.v2.TabIndex = 2;
            this.v2.Text = "*****";
            this.v2.UseVisualStyleBackColor = true;
            this.v2.Click += new System.EventHandler(this.button2_Click);
            // 
            // alusta
            // 
            this.alusta.Location = new System.Drawing.Point(24, 573);
            this.alusta.Name = "alusta";
            this.alusta.Size = new System.Drawing.Size(206, 36);
            this.alusta.TabIndex = 4;
            this.alusta.Text = "alusta";
            this.alusta.UseVisualStyleBackColor = true;
            this.alusta.Click += new System.EventHandler(this.alusta_Click);
            // 
            // Story
            // 
            this.Story.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Story.Location = new System.Drawing.Point(398, 12);
            this.Story.MaxLength = 999999999;
            this.Story.Multiline = true;
            this.Story.Name = "Story";
            this.Story.ReadOnly = true;
            this.Story.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Story.Size = new System.Drawing.Size(431, 538);
            this.Story.TabIndex = 5;
            // 
            // kapppic
            // 
            this.kapppic.BackgroundImage = global::KHAE.Properties.Resources.kapp;
            this.kapppic.Image = global::KHAE.Properties.Resources.kapp;
            this.kapppic.Location = new System.Drawing.Point(892, 170);
            this.kapppic.Name = "kapppic";
            this.kapppic.Size = new System.Drawing.Size(99, 92);
            this.kapppic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kapppic.TabIndex = 7;
            this.kapppic.TabStop = false;
            this.kapppic.Visible = false;
            // 
            // mainroompic
            // 
            this.mainroompic.Image = global::KHAE.Properties.Resources.main;
            this.mainroompic.Location = new System.Drawing.Point(892, 53);
            this.mainroompic.Name = "mainroompic";
            this.mainroompic.Size = new System.Drawing.Size(99, 92);
            this.mainroompic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainroompic.TabIndex = 6;
            this.mainroompic.TabStop = false;
            this.mainroompic.Visible = false;
            // 
            // mianpic
            // 
            this.mianpic.Image = global::KHAE.Properties.Resources.main;
            this.mianpic.Location = new System.Drawing.Point(12, 12);
            this.mianpic.Name = "mianpic";
            this.mianpic.Size = new System.Drawing.Size(355, 538);
            this.mianpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mianpic.TabIndex = 3;
            this.mianpic.TabStop = false;
            this.mianpic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 639);
            this.Controls.Add(this.kapppic);
            this.Controls.Add(this.mainroompic);
            this.Controls.Add(this.Story);
            this.Controls.Add(this.alusta);
            this.Controls.Add(this.mianpic);
            this.Controls.Add(this.v2);
            this.Controls.Add(this.v1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kapppic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainroompic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mianpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button v1;
        private System.Windows.Forms.Button v2;
        private System.Windows.Forms.PictureBox mianpic;
        private System.Windows.Forms.Button alusta;
        private System.Windows.Forms.TextBox Story;
        private System.Windows.Forms.PictureBox mainroompic;
        private System.Windows.Forms.PictureBox kapppic;
    }
}

