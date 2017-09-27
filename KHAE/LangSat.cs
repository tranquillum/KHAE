using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHAE
{
    public partial class LangSat : Form
    {

        //Координаты мышки
        private int x = 0; private int y = 0;

        // Нажатие кнопки мышки
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }
        // Движение мышки
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));

            }
        }









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
    }
}
