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
        public static NhanVien SuaNhanVien { get; internal set; }
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

        internal object TimNhanVienTheoTaiKhoanMatKhau(
            string matKhau, 
            string taiKhoan)
        {
            List<NhanVien> nhanViens = GetNhanVien();
            NhanVien nvTim = nhanViens.FirstOrDefault(nv => nv.Username == taiKhoan && nv.Password == matKhau);
            return nvTim;
        }

        public void ThemNhanVien(NhanVien nv)
        {
            // Thêm cái gì 
            // Thêm vào đâu
            // lấy  danh sach nhan viên
            List<NhanVien> dsNhanVien = GetNhanVien();
            // thêm nv vào danh sách
            dsNhanVien.Add(nv);
            // lưu vào file
            string path = "Data/NhanVien.json";
            string content = JsonConvert.SerializeObject(dsNhanVien);
            File.WriteAllText(path, content);
            // lưu vào  file

        }

        internal void PutNhanVien(NhanVien nv)
        {
            // sửa  cái gì 
            // ở đâu
            // sửa nv trong danh sách nhân vien
            List<NhanVien> nhanViens = GetNhanVien();
            // xóa nhân vien có tài khoản là Username
            nhanViens.RemoveAll(
                item =>  item.Username == nv.Username
                );
            // thêm thông tin nhân viên da cap nhật
            nhanViens.Add(nv);
            // lưu vào file
            string path = "Data/NhanVien.json";
            string content = JsonConvert.SerializeObject(nhanViens);
            File.WriteAllText(path, content);
            // lưu vào  file

        }

        internal void XoaNhanVien(string text)
        {
            List<NhanVien> nhanViens = GetNhanVien();
            nhanViens.RemoveAll(item => item.Username == text);
            // lưu vào file
            string path = "Data/NhanVien.json";
            string content = JsonConvert.SerializeObject(nhanViens);
            File.WriteAllText(path, content);
            // lưu vào  file
        }
    }
}
