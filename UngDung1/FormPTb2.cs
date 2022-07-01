using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDung1.Model;

namespace UngDung1
{
    public partial class FormPTb2 : Form
    {
        public FormPTb2()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {

            try
            {
                PTB2 ptb2 = InputForm();
                ptb2.Tinh();
                // có x1 x2
                txtKetQua.Text = String.Format("x1={0},x2={1}", ptb2.x1, ptb2.x2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private PTB2 InputForm()
        { 
            double a, b, c;
            // nhap so a
            if (double.TryParse(txtSoa.Text, out a) == false)
            {
                txtSoa.Focus();
                txtSoa.SelectAll();
                throw new Exception("Số a không hợp lệ");
            }
            if (double.TryParse(txtSob.Text, out b) == false)
            {
                txtSob.Focus();
                txtSob.SelectAll();
                throw new Exception("Số b không hợp lệ");
            }
            if (double.TryParse(txtSoC.Text, out c) == false)
            {
                txtSoC.Focus();
                txtSoC.SelectAll();
                throw new Exception("Số c không hợp lệ");
            }
            return new PTB2()
            {
                soa = a,
                sob = b,
                soc = c
            };

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
