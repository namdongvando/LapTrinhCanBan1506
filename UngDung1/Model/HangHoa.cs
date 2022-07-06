using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDung1.Model
{
    class HangHoa
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public decimal Gia { get; set; }
        public int SL { get; set; }
        public static HangHoa EditHangHoa { get; internal set; }

        //CRUD
        /// <summary>
        /// Lấy danh sach hang hóa tư file json
        /// </summary>
        /// <returns>Danh Sach HAng Hoa</returns>
        public List<HangHoa> HangHoas()
        {
            // đường dan file lưu data
            string path = "Data/HangHoa.json";
            // doc noi dung dung
            string Content = File.ReadAllText(path);
            //chuyen string  -> List<HangHoa>
            return JsonConvert
                .DeserializeObject<List<HangHoa>>(Content);
        }
        /// <summary>
        /// Thêm Hang Hoa
        /// </summary>
        /// <param name="hh"></param>
        public void Insert(HangHoa hh) {
            string path = "Data/HangHoa.json";
            List<HangHoa> dsHH = HangHoas();
            // thêm hang hoa vào danh sách
            dsHH.Add(hh);
            // lưu file
            File.WriteAllText(path, JsonConvert.SerializeObject(dsHH));

        }
        /// <summary>
        /// Xóa Hàng Hóa Theo Ma
        /// </summary>
        /// <param name="maHH">Mã hàng hóa</param>
        public void Delete(string maHH)
        {
            // lấy danh sach hang hoa có trong database
            List<HangHoa> dsHH = HangHoas();
            dsHH.RemoveAll(hh => hh.Ma == maHH);
            // luu xuống file
            string path = "Data/HangHoa.json";
            File.WriteAllText(path,
               JsonConvert.SerializeObject(dsHH));
        }

        public void Update(HangHoa hh)
        {
            Delete(hh.Ma);
            Insert(hh);
        }

    }
}
