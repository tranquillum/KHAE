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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LangSat));
            this.EST = new System.Windows.Forms.Button();
            this.ENG = new System.Windows.Forms.Button();
            this.RUS = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EST
            // 
            this.EST.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EST.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.EST.ForeColor = System.Drawing.Color.White;
            this.EST.Location = new System.Drawing.Point(36, 117);
            this.EST.Name = "EST";
            this.EST.Size = new System.Drawing.Size(231, 137);
            this.EST.TabIndex = 0;
            this.EST.Text = "EST";
            this.EST.UseVisualStyleBackColor = true;
            this.EST.Click += new System.EventHandler(this.EST_Click);
            // 
            // ENG
            // 
            this.ENG.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ENG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ENG.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ENG.ForeColor = System.Drawing.Color.White;
            this.ENG.Location = new System.Drawing.Point(307, 117);
            this.ENG.Name = "ENG";
            this.ENG.Size = new System.Drawing.Size(220, 132);
            this.ENG.TabIndex = 1;
            this.ENG.Text = "ENG";
            this.ENG.UseVisualStyleBackColor = true;
            this.ENG.Click += new System.EventHandler(this.ENG_Click);
            // 
            // RUS
            // 
            this.RUS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.RUS.ForeColor = System.Drawing.Color.White;
            this.RUS.Location = new System.Drawing.Point(569, 122);
            this.RUS.Name = "RUS";
            this.RUS.Size = new System.Drawing.Size(220, 132);
            this.RUS.TabIndex = 2;
            this.RUS.Text = "RUS";
            this.RUS.UseVisualStyleBackColor = true;
            this.RUS.Click += new System.EventHandler(this.RUS_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Black;
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(813, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(29, 30);
            this.exit.TabIndex = 11;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // LangSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(854, 393);
            this.ControlBox = false;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.RUS);
            this.Controls.Add(this.ENG);
            this.Controls.Add(this.EST);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LangSat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LangSat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EST;
        private System.Windows.Forms.Button ENG;
        private System.Windows.Forms.Button RUS;
        private System.Windows.Forms.Button exit;
    }
}