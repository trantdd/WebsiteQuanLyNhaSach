using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebsiteQuanLyNhaSach.Models;
using WebsiteQuanLyNhaSach.Repositories;

namespace WebsiteQuanLyNhaSach.Areas.Admin.Controllers
{
    public class LoaiSPsController : Controller
    {
        private readonly ILoaiSPRepository _loaiSPRepository;
        public LoaiSPsController(ILoaiSPRepository loaiSPRepository)
        {
            _loaiSPRepository = loaiSPRepository;
        }
        public async Task<IActionResult> Index()
        {
            var loaiSPRepository = await _loaiSPRepository.GetAllAsync();
            return View(loaiSPRepository);
        }
        public async Task<IActionResult> Details(int id)
        {
            var loaiSPRepository = await _loaiSPRepository.GetByMaAsync(id);
            if (loaiSPRepository == null)
            {
                return NotFound();
            }
            return View(loaiSPRepository);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(LoaiSP loaiSP)
        {
            if (ModelState.IsValid)
            {
                await _loaiSPRepository.AddAsync(loaiSP);
                return RedirectToAction(nameof(Index));
            }
            return View(loaiSP);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var loaiSPRepository = await _loaiSPRepository.GetByMaAsync(id);
            if (loaiSPRepository == null)
            {
                return NotFound();
            }
            return View(loaiSPRepository);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, LoaiSP loaiSP)
        {
            if (id != loaiSP.Ma)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                await _loaiSPRepository.UpdateAsync(loaiSP);
                return RedirectToAction(nameof(Index));
            }
            return View(loaiSP);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var loaiSPRepository = await _loaiSPRepository.GetByMaAsync(id);
            if (loaiSPRepository == null)
            {
                return NotFound();
            }
            return View(loaiSPRepository);

        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _loaiSPRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
