using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baitap1.Controllers
{
    public class LienHeController : Controller
    {
        // GET: LienHe
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int QuanTam, string TieuDe, string NoiDung, string HoTen, string Email, string SDT)
        {
            return Content($"Qúy khách đang quan tâm về: {QuanTam} <br> Tiêu đề: {TieuDe} <br> Nội dung: {NoiDung} <br> Họ và tên: {HoTen} <br> Địa chỉ Email: {Email} <br> Số diện thoại: {SDT}");
        }
    }
}