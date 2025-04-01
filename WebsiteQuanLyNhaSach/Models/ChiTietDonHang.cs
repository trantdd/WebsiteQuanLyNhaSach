using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebsiteQuanLyNhaSach.Models
{
    public class ChiTietDonHang
    {
        [Key]
        public int MaDH { get; set; }
        [ForeignKey("SanPham")]
        public int MaSP { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public SanPham? SanPham { get; set; }

    }
}
