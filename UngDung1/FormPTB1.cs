using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDung1
{
    public partial class FormPTB1 : Form
    {
        public FormPTB1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (double.TryParse(txtSoa.Text, out a)
                    == false)
                {
                    txtSoa.Focus();
                    txtSoa.SelectAll();

                    throw new
                        Exception(
                        "Số a không đúng định dạng");
                }
                if (double.TryParse(txtSob.Text, out b)
                    == false)
                {
                    txtSob.Focus();
                    txtSob.SelectAll();
                    throw new
                        Exception(
                        "Số b không đúng định dạng");
                }
                // a,b là só
                if(a==0)
                {
                    if (b==0)
                    {
                        throw new Exception("VSN");
                    }
                    else
                    {
                        throw new Exception("VN");
                    }
                }

                txtKetQua.Text = (-b/a).ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
