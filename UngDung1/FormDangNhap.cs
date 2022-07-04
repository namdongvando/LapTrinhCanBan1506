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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // admin
            // 123456
            NhanVien nv = new NhanVien();
            //if (txtTaiKhoan.Text == "admin"
            //    && txtMatKhau.Text == "123456")

                if (nv.TimNhanVienTheoTaiKhoanMatKhau(txtMatKhau.Text,txtTaiKhoan.Text)!=null)
            {
                // đã đúng tài khoản mật khẩu
                DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Tài Khoản hoặc mật khẩu không đúng");
            }


        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
