using Microsoft.AspNetCore.Mvc;

namespace WebsiteQuanLyNhaSach.Areas.Admin.Controllers
{
    [Area("Admin")] // ⚠️ Bắt buộc: Xác định đây là Controller thuộc Area "Admin"
    public class HomeAdminController : Controller
    {
        public IActionResult Index()
        {
            return View(); // View sẽ tìm trong Areas/Admin/Views/HomeAdmin/Index.cshtml
        }
    }
}
