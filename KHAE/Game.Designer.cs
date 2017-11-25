﻿namespace KHAE
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
            this.kapppic = new System.Windows.Forms.PictureBox();
            this.mainroompic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mianpic = new System.Windows.Forms.PictureBox();
            this.alusta = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.Story = new System.Windows.Forms.TextBox();
            this.v2 = new System.Windows.Forms.Button();
            this.v1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kapppic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainroompic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mianpic)).BeginInit();
            this.SuspendLayout();
            // 
            // kapppic
            // 
            this.kapppic.BackgroundImage = global::KHAE.Properties.Resources.kapp;
            this.kapppic.Image = global::KHAE.Properties.Resources.kapp;
            this.kapppic.Location = new System.Drawing.Point(1709, 267);
            this.kapppic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kapppic.Name = "kapppic";
            this.kapppic.Size = new System.Drawing.Size(132, 113);
            this.kapppic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kapppic.TabIndex = 7;
            this.kapppic.TabStop = false;
            this.kapppic.Visible = false;
            // 
            // mainroompic
            // 
            this.mainroompic.Image = global::KHAE.Properties.Resources.main;
            this.mainroompic.Location = new System.Drawing.Point(1693, 137);
            this.mainroompic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainroompic.Name = "mainroompic";
            this.mainroompic.Size = new System.Drawing.Size(132, 122);
            this.mainroompic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainroompic.TabIndex = 6;
            this.mainroompic.TabStop = false;
            this.mainroompic.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mianpic
            // 
            this.mianpic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mianpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mianpic.Image = global::KHAE.Properties.Resources.main;
            this.mianpic.Location = new System.Drawing.Point(13, 65);
            this.mianpic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mianpic.Name = "mianpic";
            this.mianpic.Size = new System.Drawing.Size(475, 634);
            this.mianpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mianpic.TabIndex = 3;
            this.mianpic.TabStop = false;
            // 
            // alusta
            // 
            this.alusta.BackColor = System.Drawing.Color.Silver;
            this.alusta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.alusta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alusta.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alusta.ForeColor = System.Drawing.Color.Black;
            this.alusta.Location = new System.Drawing.Point(13, 706);
            this.alusta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.alusta.Name = "alusta";
            this.alusta.Size = new System.Drawing.Size(475, 54);
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
            this.exit.Location = new System.Drawing.Point(1461, 14);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(40, 39);
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
            this.Story.Location = new System.Drawing.Point(495, 65);
            this.Story.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Story.MaxLength = 999999999;
            this.Story.Multiline = true;
            this.Story.Name = "Story";
            this.Story.ReadOnly = true;
            this.Story.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Story.Size = new System.Drawing.Size(912, 630);
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
            this.v2.Location = new System.Drawing.Point(495, 777);
            this.v2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(889, 57);
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
            this.v1.Location = new System.Drawing.Point(495, 705);
            this.v1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(889, 57);
            this.v1.TabIndex = 1;
            this.v1.UseVisualStyleBackColor = false;
            this.v1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(1385, 65);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(21, 630);
            this.panel4.TabIndex = 12;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(1523, 846);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.v1);
            this.Controls.Add(this.alusta);
            this.Controls.Add(this.v2);
            this.Controls.Add(this.mianpic);
            this.Controls.Add(this.Story);
            this.Controls.Add(this.mainroompic);
            this.Controls.Add(this.kapppic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Game_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.kapppic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainroompic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mianpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox mainroompic;
        private System.Windows.Forms.PictureBox kapppic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox mianpic;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button alusta;
        private System.Windows.Forms.TextBox Story;
        private System.Windows.Forms.Button v2;
        private System.Windows.Forms.Button v1;
        private System.Windows.Forms.Panel panel4;
    }
}

