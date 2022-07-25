import HttpClient from "./HttpClient.js";
//https://nguyenvando.net/api/getlocation
var httpClient = new HttpClient();

httpClient.Get("https://nguyenvando.net/api/getlocation", function (result) {
  console.log(result);
  // string -> json
  var dataJson = JSON.parse(result);
  console.log(dataJson);
  // danh sách tỉnh
  var tinhThanh = document.getElementById("TinhThanh");
  var quanHuyen = document.getElementById("QuanHuyen");
  // tìm tỉnh thành
  var danhSachTinh = dataJson.filter(function (item, index) {
    if (item.Parent == "0") {
      return item;
    }
  });
  var htmlOptions = "";
  for (let index = 0; index < danhSachTinh.length; index++) {
    const element = danhSachTinh[index];
    htmlOptions += `<option value="${element.Id}" >${element.Name}</option>`;
    // htmlOptions = htmlOptions+ "";
  }
  tinhThanh.innerHTML = htmlOptions;
  // danh sách tỉnh
  console.log(danhSachTinh);
  var htmlHuyen = "";
});

setInterval(function () {
  console.log(new Date());
  var time = document.getElementById("time");
  var giay = new Date().getUTCSeconds();
  var nam = new Date().getFullYear();
  var thang = new Date().getMonth();
  var ngay = new Date().getDate();
  var gio = new Date().getHours();
  var phut = new Date().getMinutes();
  time.innerHTML = `${nam}-${thang + 1}-${ngay} ${gio}:${phut}:${giay}`;
}, 1000);
function xinchao() {
  // alert("xin chào");
  console.log("xin chao");
}
function layDanhSachHuyen(maTinh) {
  console.log(maTinh);
  htmlHuyen += `<option value="1" >1</option>`;
  quanHuyen.innerHTML = htmlHuyen;
}
