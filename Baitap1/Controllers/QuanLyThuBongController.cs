using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baitap1.Controllers
{
    public class QuanLyThuBongController : Controller
    {
        // GET: QuanLyThuBong
        public ActionResult ThemThuBong()
        {
            return View();
        }
        public ActionResult DanhSachThuBong()
        {
            return View();
        }
        public ActionResult SuaThongTinThuBong()
        {
            return View();
        }
    }
}