using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class binomialD : Form
    {
        public binomialD()
        {
            InitializeComponent();
        }

        private void txtWrite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            } 
        }

        private void txtPro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Double.Parse(txtPro.Text) > 1 || Double.Parse(txtPro.Text) < 0)
                {
                    MessageBox.Show("Vlera e probabilitetit duhet te jete mes 0 dhe 1"
                        ,"Gabim ne vlera",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtPro.Focus();
                }
            }
            catch (FormatException ex) {
                MessageBox.Show("Lejohen vetem numrat reale mes 0 dhe 1"
                    , "Gabim ne vlera", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPro.Focus();
            }

        }

        private void txtPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || '.'.Equals(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            } 
        }

        private void btnLlogarite_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTotal.Text) || String.IsNullOrEmpty(txtSukses.Text)
                || String.IsNullOrEmpty(txtPro.Text))
            {
                MessageBox.Show("Ju lutem plotesoni fushat perkatese!"
                    , "Fusha te zbrazeta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((int.Parse(txtTotal.Text)) < (int.Parse(txtSukses.Text)))
            {
                MessageBox.Show("Numri i provave nuk mund te jete me i vogel se numri i sukseseve", "Error!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                int provat = int.Parse(txtTotal.Text);
                int sukseset = int.Parse(txtSukses.Text);
                double pro = double.Parse(txtPro.Text);
                txtProBinomial.Text = llogaritProbabilitetin(provat, sukseset, pro) + "";
                txtPro1.Text = llogaritProMeIVogel(provat, sukseset, pro) + "";
                txtPro2.Text = llogaritProMeIVogelBarabarte(provat, sukseset, pro) + "";
                txtPro3.Text = llogaritProMeIMadh(provat, sukseset, pro) + "";
                txtPro4.Text = llogaritProMeIMadhBarabarte(provat, sukseset, pro) + "";
            }
        }
        
        public double llogaritFaktorielin(int n) { 
            double faktorieli=1;
            if (n == 0) faktorieli = 1;
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    faktorieli *= i;
                }
            }
            return faktorieli;
        }
        
        public double llogaritKombinimet(int n, int k) {
            
            double totali;
            double vleraSiperme=1;
            int x;
            if((n-k)>k)x=k;
            else x=n-k;
            for (int i = n; i > n-x; i--)
            {
                vleraSiperme *= i;
            }
            totali = vleraSiperme / llogaritFaktorielin(x);
            return totali;
        }
        
        public double llogaritProbabilitetin(int provat, int sukseset, double pro) {
            double proBinomial = llogaritKombinimet(provat, sukseset) * Math.Pow(pro, sukseset) *
                Math.Pow(1.0 - pro, provat-sukseset);
            return proBinomial;
        }
        
        public double llogaritProMeIVogel(int provat, int sukseset, double pro)
        {
            double proBinomial=0;
            for (int i = 0; i < sukseset; i++)
            {
                proBinomial += llogaritKombinimet(provat, i) * Math.Pow(pro, i) *
                Math.Pow(1.0 - pro, provat - i);
            }
            return proBinomial;
        }
        
        public double llogaritProMeIVogelBarabarte(int provat, int sukseset, double pro)
        {
            double proBinomial = 0;
            for (int i = 0; i <= sukseset; i++)
            {
                proBinomial += llogaritKombinimet(provat, i) * Math.Pow(pro, i) *
                Math.Pow(1.0 - pro, provat - i);
            }
            return proBinomial;
        }
        
        public double llogaritProMeIMadh(int provat, int sukseset, double pro)
        {
            double proBinomial = 0;
            for (int i = 0; i <= sukseset; i++)
            {
                proBinomial += llogaritKombinimet(provat, i) * Math.Pow(pro, i) *
                Math.Pow(1.0 - pro, provat - i);
            }
            return 1.0-proBinomial;
        }

        public double llogaritProMeIMadhBarabarte(int provat, int sukseset, double pro)
        {
            double proBinomial = 0;
            for (int i = 0; i < sukseset; i++)
            {
                proBinomial += llogaritKombinimet(provat, i) * Math.Pow(pro, i) *
                Math.Pow(1.0 - pro, provat - i);
            }
            return 1.0 - proBinomial;
        }

        private void labSukses_MouseHover(object sender, EventArgs e)
        {
             ToolTip help = new ToolTip();
            help.ToolTipTitle = "Sqarim";
            help.SetToolTip(labSukses, "Shkruani numrin e realizimeve te suksesshme te provave");

        }
       
    }
}
