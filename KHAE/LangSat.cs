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
        String lang = "";
        public LangSat()
        {
            InitializeComponent();
        }

        private void EST_Click(object sender, EventArgs e)
        {
            lang = "EST";
            if (lang !="")
            {

                this.DialogResult = DialogResult.OK;

            }

        }

        private void ENG_Click(object sender, EventArgs e)
        {
            lang = "";
            if (lang != "")
            {

                this.DialogResult = DialogResult.OK;

            }
            else
                MessageBox.Show("Keel ei ole lisatud", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RUS_Click(object sender, EventArgs e)
        {
            lang = "";
            if (lang != "")
            {

                this.DialogResult = DialogResult.OK;

            }
            else
                MessageBox.Show("Keel ei ole lisatud", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public string langSat()
        {
            return lang;
        }
    }
}
