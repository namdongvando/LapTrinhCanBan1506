using System;
using System.Collections.Generic;
using System.Text;

namespace HinhHoc.Model
{
    class HinhVuong
    {
        public double canh { get; set; }

        public double ChuVi() {
            return canh * 4;
        }
        public double DienTich()
        {
            return canh * canh;
        }
    }
}
