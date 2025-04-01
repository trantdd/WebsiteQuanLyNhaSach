using WebsiteQuanLyNhaSach.Models;

namespace WebsiteQuanLyNhaSach.Repositories
{
    public interface ILoaiSPRepository
    {
        Task<IEnumerable<LoaiSP>> GetAllAsync();
        Task<LoaiSP> GetByMaAsync(int ma);
        Task AddAsync(LoaiSP loaiSP);
        Task UpdateAsync(LoaiSP loaiSP);
        Task DeleteAsync(int ma);

    }
}
