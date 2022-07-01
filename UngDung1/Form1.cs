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
    public partial class Form1 : Form
    {
        private static bool isLogin = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLogin == false)
                return;

            // thông báo có đóng form khong ?
            var result = MessageBox.Show(
                "Bạn có muốn Thoát Không?",
                "Thông Báo", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            Form ftinhTong = new FormTinhTong();
            ftinhTong.ShowDialog();
            //ftinhTong.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form ftinhTong = new FormPTB1();
            ftinhTong.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ftinhTong = new FormPTb2();
            ftinhTong.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form fLogin = new FormDangNhap();
           var result = fLogin.ShowDialog();
            if(result != DialogResult.OK)
            {
                Close();
            }
            isLogin = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ftinhTong = new FormNhanVien();
            ftinhTong.ShowDialog();
        }
    }
}
