using System;
using System.Collections.Generic;
using System.Text;

namespace HinhHoc.Model
{
    class HinhChuNhat
    {
        public double canhA { get; set; }
        public double canhB { get; set; }

        internal double DienTich()
        {
            return canhA * canhB;
        }

        internal double ChuVi()
        {
            return (canhB + canhA) * 2;
        }
    }
}
