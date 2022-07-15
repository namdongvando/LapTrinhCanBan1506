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
    public partial class FormAddProduct : Form
    {
        BanHangDataContext _db = new BanHangDataContext();

        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            SetForm();
        }

        private void SetForm()
        {
            comboBox1.DataSource = _db.Categories.ToList();
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";

            comboBox2.DataSource = _db.Suppliers.ToList();
            comboBox2.DisplayMember = "CompanyName";
            comboBox2.ValueMember = "SupplierID";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = GetInputForm();
                _db.Products.InsertOnSubmit(p);
                _db.SubmitChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private Product GetInputForm()
        {
            if (txtTenSanPham.Text == "")
            {
                txtTenSanPham.Focus();
                txtTenSanPham.SelectAll();
                throw new Exception("Bạn chưa nhập tên sản phẩm");
            }
            if (txtQuyCachDongGoi.Text == "")
            {
                txtQuyCachDongGoi.Focus();
                txtQuyCachDongGoi.SelectAll();
                throw new Exception("Bạn chưa nhập Quy cách đóng gói");
            }
            decimal gia =0;
            if (decimal.TryParse(txtDonGia.Text,out gia)==false)
            {
                txtDonGia.Focus();
                txtDonGia.SelectAll();
                throw new Exception("Đơn giá không đúng định dạng");
            }
            int sl = 0;
            if (int.TryParse(txtDaDat.Text, out sl)==false)
            {
                txtDonGia.Focus();
                txtDonGia.SelectAll();
                throw new Exception("Số Lượng không đúng định dạng");
            }
            if (int.TryParse(txtTonKho.Text, out sl) == false)
            {
                txtDonGia.Focus();
                txtDonGia.SelectAll();
                throw new Exception("Tồn kho không đúng định dạng");
            }

            Category cat = (Category) comboBox1.SelectedItem;
            Supplier supplier = (Supplier) comboBox2.SelectedItem;

            return new Product() {
                CategoryID = cat.CategoryID,
                SupplierID = supplier.SupplierID,
                ProductName = txtTenSanPham.Text,
                UnitPrice = decimal.Parse(txtDonGia.Text),
                QuantityPerUnit = txtQuyCachDongGoi.Text,
                Discontinued = checkBox1.Checked,
                UnitsInStock = short.Parse(txtTonKho.Text),
                UnitsOnOrder = short.Parse(txtDaDat.Text),
                ReorderLevel = short.Parse(txtSapXep.Text)
                 
            };
        }
    }
}
