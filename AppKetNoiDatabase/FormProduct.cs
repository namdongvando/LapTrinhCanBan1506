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
            comboBox1.DataSource = _db.Categories.ToList();
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
            comboBox2.DataSource = _db.Suppliers.ToList();
            comboBox2.DisplayMember = "CompanyName";
            comboBox2.ValueMember = "SupplierID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;
            Category cat = (Category)comboBox1.SelectedItem;
            Supplier sup = (Supplier)comboBox2.SelectedItem;

            dataGridView1.DataSource =
                _db.Products.Where(
                i => i.ProductID.ToString()
            .Contains(keyword) ||
            i.ProductName.Contains(keyword))
            .Where(i =>
            i.CategoryID.Equals(cat.CategoryID)
            && i.SupplierID.Equals(sup.SupplierID)
            ).ToList();


        }
    }
}
