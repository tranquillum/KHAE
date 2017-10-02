using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KHAE
{
    public partial class LangSat : Form
    {
        

        


        int lang;
        public LangSat()
        {
            InitializeComponent();
        }

        private void EST_Click(object sender, EventArgs e)
        {
            lang = 0;
            if (lang ==0)
            {

                this.DialogResult = DialogResult.OK;

            }

        }

        private void ENG_Click(object sender, EventArgs e)
        {
            lang = 1;
            if (lang ==1)
            {

                this.DialogResult = DialogResult.OK;

            }
            else
                MessageBox.Show("Keel ei ole lisatud", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RUS_Click(object sender, EventArgs e)
        {
            lang = 2;
            if (lang ==2 )
            {

                this.DialogResult = DialogResult.OK;

            }
            else
                MessageBox.Show("Keel ei ole lisatud", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public int langSat()
        {
            return lang;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LangSat_Load(object sender, EventArgs e)
        {

        }



        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void LangSat_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }
    }
}
