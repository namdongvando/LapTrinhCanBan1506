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
    }
}
