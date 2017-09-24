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
    }
}
