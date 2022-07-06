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
    public partial class FormHangHoa : Form
    {
        public FormHangHoa()
        {
            InitializeComponent();
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            dataGridView1.DataSource = hh.HangHoas().ToList();
        }

        private void tạoMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormThemHangHoa();
            var result =  f.ShowDialog();
            if(result == DialogResult.OK)
            {
                GetData();
            }
        }

        private void GetData()
        {
            HangHoa hh = new HangHoa();
            dataGridView1.DataSource 
                = hh.HangHoas().ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Ma = dataGridView1.Rows[e.RowIndex].Cells["Ma"].Value.ToString();
            string Ten = dataGridView1.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
            string Gia = dataGridView1.Rows[e.RowIndex].Cells["Gia"].Value.ToString();
            string SL = dataGridView1.Rows[e.RowIndex].Cells["SL"].Value.ToString();

            HangHoa.EditHangHoa = new HangHoa()
            {
                Ma = Ma,
                Ten = Ten,
                Gia = decimal.Parse(Gia),
                SL = int.Parse(SL)
            };

            Form f = new FormSuaHangHoa();
            var result =  f.ShowDialog();
            if(result == DialogResult.OK)
            {
                GetData();
            }

        }
    }
}
