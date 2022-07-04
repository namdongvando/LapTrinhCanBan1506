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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            textBox1.Text = nv.GetContentFileNhanVien();

            dataGridView1.DataSource = nv.GetNhanVien().ToList();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form fNhanVien = new FormThemNhanVien();
            var result = fNhanVien.ShowDialog();
            if(result == DialogResult.OK)
            {
                // thêm nhan vien thành công
                // tài lại danh sách 
                NhanVien nv = new NhanVien();
                dataGridView1.DataSource = 
                    nv.GetNhanVien().ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string TaiKhoan =
                dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            string MatKhau =
                dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string HoTen =
                dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            NhanVien.SuaNhanVien = new NhanVien()
            {
                Username = TaiKhoan,
                Password = MatKhau,
                FullName = HoTen
            };
            Form fSuaNhanVien = new FormSuaNhanVien();

            var result = fSuaNhanVien.ShowDialog();
            if (result == DialogResult.OK)
            {
                // cập nhật danh sách nhan vien
                NhanVien nv = new NhanVien();
                dataGridView1.DataSource = nv.GetNhanVien().ToList();
            }
        }
    }
}
