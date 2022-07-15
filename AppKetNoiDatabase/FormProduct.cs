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
    public partial class FormProduct : Form
    {
        BanHangDataContext _db = new BanHangDataContext();
        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            SetForm();
        }

        private void SetForm()
        {
            dataGridView1.DataSource = _db.Products.ToList();
            List<Category> DanhSachDanhMuc = _db.Categories.ToList();
            DanhSachDanhMuc.Insert(0, new Category()
            {
                CategoryID = 0,
                CategoryName = "Chọn Tất Cả"
            });
            comboBox1.DataSource = DanhSachDanhMuc;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
            List<Supplier> sups = _db.Suppliers.ToList();
            sups.Insert(0, new Supplier()
            {
                SupplierID = 0,
                CompanyName = "Chọn tất cả"
            });
            comboBox2.DataSource = sups;
            comboBox2.DisplayMember = "CompanyName";
            comboBox2.ValueMember = "SupplierID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;
            Category cat = (Category)comboBox1.SelectedItem;
            Supplier sup = (Supplier)comboBox2.SelectedItem;
            // tìm theo từ khóa
            var DanhSachTimKiem = _db.Products.Where(
                sp=>sp.ProductID.ToString().Contains(keyword)
                || sp.ProductName.Contains(keyword)
                );

            var DanhSachTimKiemList = DanhSachTimKiem;
            // tim theo danh muc
            if (cat.CategoryID > 0)
            {
                DanhSachTimKiemList = DanhSachTimKiem.Where(
                    sp => sp.CategoryID.Equals(cat.CategoryID)
                    );
            }
            // tìm theo nhà  cung cấp
            if (sup.SupplierID > 0)
            {
                DanhSachTimKiemList = DanhSachTimKiem.Where(
                    sp => sp.SupplierID.Equals(sup.SupplierID));
            }

            dataGridView1.DataSource = DanhSachTimKiemList.ToList();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormAddProduct();
            var result = f.ShowDialog();
            if (result == DialogResult.OK)
            {
                dataGridView1.DataSource = _db.Products.ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = dataGridView1
                .Rows[e.RowIndex]
                .Cells["ProductID"].Value.ToString();
            // tìm sản phẩm theo mã
            BgData.ProductEdit = _db.Products
                .FirstOrDefault(
                sp=>sp.ProductID.ToString() == ma);
            
            Form f = new FormProductEdit();
            var result = f.ShowDialog(); 
            if(result == DialogResult.OK)
            {
                dataGridView1.DataSource = _db.Products.ToList();
            }

        }
    }
}
