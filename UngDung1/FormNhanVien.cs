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
    }
}
