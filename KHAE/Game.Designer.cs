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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.alusta = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.Story = new System.Windows.Forms.TextBox();
            this.v2 = new System.Windows.Forms.Button();
            this.v1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // alusta
            // 
            this.alusta.BackColor = System.Drawing.Color.Silver;
            this.alusta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.alusta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alusta.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alusta.ForeColor = System.Drawing.Color.Black;
            this.alusta.Location = new System.Drawing.Point(156, 675);
            this.alusta.Name = "alusta";
            this.alusta.Size = new System.Drawing.Size(356, 44);
            this.alusta.TabIndex = 10;
            this.alusta.Text = "Alusta";
            this.alusta.UseVisualStyleBackColor = false;
            this.alusta.Click += new System.EventHandler(this.alusta_Click_1);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Black;
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(1065, 8);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 32);
            this.exit.TabIndex = 10;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Story
            // 
            this.Story.BackColor = System.Drawing.Color.DarkGray;
            this.Story.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Story.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Story.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Story.ForeColor = System.Drawing.Color.Black;
            this.Story.Location = new System.Drawing.Point(12, 12);
            this.Story.MaxLength = 999999999;
            this.Story.Multiline = true;
            this.Story.Name = "Story";
            this.Story.ReadOnly = true;
            this.Story.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Story.Size = new System.Drawing.Size(684, 553);
            this.Story.TabIndex = 5;
            this.Story.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Story.UseWaitCursor = true;
            // 
            // v2
            // 
            this.v2.BackColor = System.Drawing.Color.Silver;
            this.v2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.v2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v2.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v2.ForeColor = System.Drawing.Color.Black;
            this.v2.Location = new System.Drawing.Point(12, 623);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(667, 46);
            this.v2.TabIndex = 2;
            this.v2.UseVisualStyleBackColor = false;
            this.v2.Click += new System.EventHandler(this.button2_Click);
            // 
            // v1
            // 
            this.v1.AutoSize = true;
            this.v1.BackColor = System.Drawing.Color.Silver;
            this.v1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.v1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.v1.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v1.ForeColor = System.Drawing.Color.Black;
            this.v1.Location = new System.Drawing.Point(12, 571);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(667, 46);
            this.v1.TabIndex = 1;
            this.v1.UseVisualStyleBackColor = false;
            this.v1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(677, 11);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(19, 555);
            this.panel4.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KHAE.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(475, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(656, 221);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(1106, 733);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.v1);
            this.Controls.Add(this.alusta);
            this.Controls.Add(this.v2);
            this.Controls.Add(this.Story);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Game_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button alusta;
        private System.Windows.Forms.TextBox Story;
        private System.Windows.Forms.Button v2;
        private System.Windows.Forms.Button v1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

