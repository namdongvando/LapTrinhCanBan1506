using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppKetNoiDatabase
{
    public partial class FormDanhMuc : Form
    {
        private BanHangDataContext _db = new BanHangDataContext();
        public FormDanhMuc()
        {
            InitializeComponent();
        }

        private void FormDanhMuc_Load(object sender, EventArgs e)
        {

            dgvDanhMuc.DataSource = _db.Categories.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Category cat = GetInputForm();
                _db.Categories.InsertOnSubmit(cat);
                _db.SubmitChanges();
                dgvDanhMuc.DataSource = _db.Categories.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private Category GetInputForm()
        {
            if (txtTen.Text == "") {
                txtTen.Focus();
                txtTen.SelectAll();
                throw new Exception("Tên Không đúng dịnh dạng");

            }

            if (txtMoTa.Text == "")
            {
                txtMoTa.Focus();
                txtMoTa.SelectAll();
                throw new Exception("Mô tả Không đúng dịnh dạng");

            }
            return new Category()
            {
                CategoryName = txtTen.Text,
                Description = txtMoTa.Text
            };
        }

        private void dgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = dgvDanhMuc.Rows[e.RowIndex].Cells["CategoryID"].Value.ToString();
            
            string ten = dgvDanhMuc.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();
           
            string mota = dgvDanhMuc.Rows[e.RowIndex].Cells["Description"].Value.ToString();
           
            txtMa.Text = ma;
            txtTen.Text = ten;
            txtMoTa.Text = mota;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Category cat = GetInputForm();
                if(txtMa.Text == "")
                {
                    txtMa.Focus();
                    txtMa.SelectAll();
                    throw new Exception("Mã không hợp lệ");
                }
                cat.CategoryID = 
                    int.Parse(txtMa.Text);
              //lấy danh muc trong DB
                Category catDb = _db.Categories.FirstOrDefault(
                    item => item.CategoryID 
                    == cat.CategoryID);
                // cập nhât các properti 
                catDb.CategoryName = cat.CategoryName;
                catDb.Description = cat.Description;
                // lưu database
                _db.SubmitChanges();
                dgvDanhMuc.DataSource = _db.Categories.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                int ma = int.Parse(txtMa.Text);
                // 
                Category catDb = _db.Categories.FirstOrDefault(i=>i.CategoryID==ma);
                if (catDb == null)
                {
                    throw new Exception("không có danh muc bạn muốn xóa");
                }
                // dang ky đối tượng muốn xóa
                _db.Categories.DeleteOnSubmit(catDb);
                _db.SubmitChanges();
                dgvDanhMuc.DataSource = _db.Categories.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
