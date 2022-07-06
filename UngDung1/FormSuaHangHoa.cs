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
    public partial class FormSuaHangHoa : Form
    {
        public FormSuaHangHoa()
        {
            InitializeComponent();
        }

        private void FormSuaHangHoa_Load(object sender, EventArgs e)
        {
            txtMa.Text = HangHoa.EditHangHoa.Ma;
            txtTen.Text = HangHoa.EditHangHoa.Ten;
            txtGia.Text = HangHoa.EditHangHoa.Gia.ToString();
            txtSL.Text = HangHoa.EditHangHoa.SL.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                HangHoa hh = GetInputForm();
                hh.Update(hh);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private HangHoa GetInputForm()
        {

            if (txtMa.Text == "")
            {
                txtMa.Focus();
                throw new Exception(
                    "Bạn chưa nhập mã Hàng Hóa");
            }
            if (txtTen.Text == "")
            {
                txtTen.Focus();
                throw new Exception(
                    "Bạn chưa nhập Tên Hàng Hóa");
            }
            decimal gia;
            int sL;
            if (decimal.TryParse(txtGia.Text, out gia) == false)
            {
                txtGia.Focus();
                txtGia.SelectAll();
                throw new Exception(
                    "Giá Không đúng định dạng");
            }
            if (int.TryParse(txtSL.Text, out sL) == false)
            {
                txtGia.Focus();
                txtGia.SelectAll();
                throw new Exception(
                    "Số Lượng Không đúng định dạng");
            }

            return new HangHoa()
            {
                Ma = txtMa.Text,
                Ten = txtTen.Text,
                Gia = gia,
                SL = sL,
            };


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn có Muốn Xóa Hàng Hóa này không?",
                "Thông Báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                HangHoa hh = new HangHoa();
                hh.Delete(txtMa.Text);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
