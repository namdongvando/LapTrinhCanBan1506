const HttpClient = function () {
  // get ,post,put , delete
  this.Get = function (linkApi, callback) {
    const xhttp = new XMLHttpRequest();
    xhttp.onload = function () {
      if (typeof callback == "function") {
        callback(this.responseText);
      }
      //   document.getElementById("demo").innerHTML = this.responseText;
    };
    // xhttp.open("GET", "ajax_info.txt", true);
    xhttp.open("GET", linkApi, true);
    xhttp.send();
  };
};
export default HttpClient;
