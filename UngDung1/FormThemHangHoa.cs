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
    public partial class FormThemHangHoa : Form
    {
        public FormThemHangHoa()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                HangHoa hh = GetInputForm();
                hh.Insert(hh);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
         }

        private HangHoa GetInputForm()
        {
            
            if(txtMa.Text == "")
            {
                txtMa.Focus();
                throw new Exception(
                    "Bạn chưa nhập mã Hàng Hóa");
            }
            if (txtTen.Text == "")
            {
                txtTen.Focus();
                throw new Exception(
                    "Bạn chưa nhập Tên Hàng Hóa");
            }
            decimal gia;
            int sL;
            if (decimal.TryParse(txtGia.Text, out gia)==false) {
                txtGia.Focus();
                txtGia.SelectAll();
                throw new Exception(
                    "Giá Không đúng định dạng");
            }
            if (int.TryParse(txtSL.Text, out sL)==false)
            {
                txtGia.Focus();
                txtGia.SelectAll();
                throw new Exception(
                    "Số Lượng Không đúng định dạng");
            }

            return new HangHoa()
            {
                Ma = txtMa.Text,
                Ten = txtTen.Text,
                Gia = gia,
                SL = sL,
            };


        }
    }
}
