using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDung1.Model
{
    class NhanVien
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }

        public string GetContentFileNhanVien()
        {
            return File.ReadAllText("Data/NhanVien.json");
        }

        public List<NhanVien> GetNhanVien()
        {
           List<NhanVien> dsNhanVien = JsonConvert.DeserializeObject<List<NhanVien>>(GetContentFileNhanVien());

            return dsNhanVien;
        }
    }
}
