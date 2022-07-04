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
    public partial class FormSuaNhanVien : Form
    {
        public FormSuaNhanVien()
        {
            InitializeComponent();
        }

        private void FormSuaNhanVien_Load(object sender, EventArgs e)
        {
            NhanVien nv = NhanVien.SuaNhanVien;
            txtHoTen.Text = nv.FullName;
            txtTaiKhoan.Text = nv.Username;
            txtMatKhau.Text = nv.Password;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = InputFormNhanVien();
                nv.PutNhanVien(nv);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private NhanVien InputFormNhanVien()
        {
            if (txtHoTen.Text == "")
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

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn có muốn xóa nhân viên này không?", 
                "Thông báo",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                NhanVien nv = new NhanVien();
                nv.XoaNhanVien(txtTaiKhoan.Text);
                DialogResult = DialogResult.OK;
            }

        }
    }
}
