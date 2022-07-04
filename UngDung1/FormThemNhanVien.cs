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
    public partial class FormThemNhanVien : Form
    {
        public FormThemNhanVien()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try { 
                
                NhanVien nv = InputFormNhanVien();
                nv.ThemNhanVien(nv);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private NhanVien InputFormNhanVien()
        {
            if(txtHoTen.Text == "")
            {
                txtHoTen.Focus();
                txtHoTen.SelectAll();
                throw new Exception("Bạn chưa nhận tên nhân viên");
            }
            if (txtTaiKhoan.Text == "")
            {
                txtTaiKhoan.Focus();
                txtTaiKhoan.SelectAll();
                throw new Exception("Bạn chưa nhận Tài Khoản");
            }
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Focus();
                txtMatKhau.SelectAll();
                throw new Exception("Bạn chưa nhận tên Mật khẩu");
            }
            return new NhanVien()
            {
                FullName = txtHoTen.Text,
                Username = txtTaiKhoan.Text,
                Password = txtMatKhau.Text
            };
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
