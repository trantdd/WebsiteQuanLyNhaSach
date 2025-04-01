using System.ComponentModel.DataAnnotations;

namespace WebsiteQuanLyNhaSach.Models
{
    public class KhachHang
    {
        [Key]
        public int Ma { get; set; }
        [Required, StringLength(500)]
        public string? Ten { get; set; }
        [Required, StringLength(500)]
        public string? DiaChi { get; set; }
        [Required, StringLength(500)]
        public string? Email { get; set; }
        [Required, StringLength(16)]
        public string? DienThoai { get; set; }  
        [Required, StringLength(16)]
        public string? Password { get; set; }
        public List<DonHang>? DonHangs { get; set; }
    }
}
