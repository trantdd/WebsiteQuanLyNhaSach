using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebsiteQuanLyNhaSach.Models
{
    public class DonHang
    {
        [Key]
        public int Ma { get; set; }
        public DateTime NgayDatHang { get; set; }
        public decimal? PhiGiao { get; set; }
        [Required, StringLength(500)]
        public string? TenNguoiNhan { get; set; }
        [Required, StringLength(500)]
        public string? DiaChi { get; set; }
        [Required, StringLength(500)]
        public string? Email { get; set; }
        [Required, StringLength(16)]
        public string? DienThoai { get; set; }
        [ForeignKey("KhachHang")]
        public int MaKhachHang { get; set; }
        public KhachHang? KhachHang { get; set; }
        public List<ChiTietDonHang>? ChiTietDonHangs { get; set; }
    }
}
