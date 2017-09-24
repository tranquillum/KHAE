namespace KHAE
{
    partial class LangSat
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
            this.EST = new System.Windows.Forms.Button();
            this.ENG = new System.Windows.Forms.Button();
            this.RUS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EST
            // 
            this.EST.Location = new System.Drawing.Point(42, 75);
            this.EST.Name = "EST";
            this.EST.Size = new System.Drawing.Size(231, 137);
            this.EST.TabIndex = 0;
            this.EST.Text = "EST";
            this.EST.UseVisualStyleBackColor = true;
            this.EST.Click += new System.EventHandler(this.EST_Click);
            // 
            // ENG
            // 
            this.ENG.Location = new System.Drawing.Point(314, 79);
            this.ENG.Name = "ENG";
            this.ENG.Size = new System.Drawing.Size(220, 132);
            this.ENG.TabIndex = 1;
            this.ENG.Text = "ENG";
            this.ENG.UseVisualStyleBackColor = true;
            this.ENG.Click += new System.EventHandler(this.ENG_Click);
            // 
            // RUS
            // 
            this.RUS.Location = new System.Drawing.Point(580, 80);
            this.RUS.Name = "RUS";
            this.RUS.Size = new System.Drawing.Size(220, 132);
            this.RUS.TabIndex = 2;
            this.RUS.Text = "RUS";
            this.RUS.UseVisualStyleBackColor = true;
            this.RUS.Click += new System.EventHandler(this.RUS_Click);
            // 
            // LangSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 393);
            this.ControlBox = false;
            this.Controls.Add(this.RUS);
            this.Controls.Add(this.ENG);
            this.Controls.Add(this.EST);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LangSat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EST;
        private System.Windows.Forms.Button ENG;
        private System.Windows.Forms.Button RUS;
    }
}