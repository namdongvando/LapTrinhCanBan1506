using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDung1.Model
{
    class PTB2
    {
        public double soa { get; set; }
        public double sob { get; set; }
        public double soc { get; set; }
        public double x1 { get; set; }
        public double x2 { get; set; }
        public void Tinh() {
            if (soa == 0)
            {
                throw new Exception("So a không được bằng 0");
            }
            double d = Math.Pow(sob, 2) - 4 * soa * soc;
            if(d<0)
            {
                throw new Exception("PT vo nghiem");
            }
            x1 = (-sob + Math.Sqrt(d)) / (2 * soa);
            x2 = (-sob - Math.Sqrt(d)) / (2 * soa);
            
        }
       
    }
}
