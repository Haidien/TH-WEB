using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baitap1.Controllers
{
    public class CuaHangSachController : Controller
    {
        // GET: CuaHangSach
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DanhSachSanPham()
        {
            return View();
        }
        public ActionResult ChiTietSach()
        {
            return View();
        }
    }
}