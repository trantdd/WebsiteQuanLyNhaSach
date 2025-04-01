using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebsiteQuanLyNhaSach.Models
{
    public class SanPham
    {
        [Key]
        public int Ma { get; set; }
        [Required, StringLength(500)]
        public string? Ten { get; set; }
        [Required, StringLength(500)]
        public string? MoTa { get; set; }
        [Required, StringLength(500)]
        public string? Anh { get; set; }
        [Required, StringLength(500)]
        public string? ChiTiet { get; set; }
        public int? TieuBieu { get; set; }
        public decimal? Gia { get; set; }
        [Required, StringLength(500)]
        public string? TacGia { get; set; }
        [Required, StringLength(500)]
        public string? NhaXuatBan { get; set; }
        public DateTime? NamXB { get; set; }
        [Required, StringLength(50)]
        public string? GiamGia { get; set; }
        [ForeignKey("LoaiSP")]
        public int MaLoai { get; set; }
        public LoaiSP? LoaiSP { get; set; }
        public List<ChiTietDonHang>? ChiTietDonHangs { get; set; }
    }
}
