using Microsoft.EntityFrameworkCore;
using WebsiteQuanLyNhaSach.Models;

namespace WebsiteQuanLyNhaSach.Repositories
{
    public class EFLoaiSPRepository : ILoaiSPRepository
    {
        private readonly ApplicationDbContext _context;
        public EFLoaiSPRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<LoaiSP>> GetAllAsync()
        {
            return await _context.LoaiSPs.ToListAsync();
        }
        public async Task<LoaiSP> GetByMaAsync(int ma)
        {
            return await _context.LoaiSPs.FindAsync(ma);
        }
        public async Task AddAsync(LoaiSP loaiSP)
        {
            _context.LoaiSPs.Add(loaiSP);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(LoaiSP loaiSP)
        {
            _context.LoaiSPs.Update(loaiSP);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int ma)
        {
            var loaiSP = await _context.LoaiSPs.FindAsync(ma);
            _context.LoaiSPs.Remove(loaiSP);
            await _context.SaveChangesAsync();
        }
    }
}
