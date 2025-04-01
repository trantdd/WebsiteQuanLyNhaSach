using System.ComponentModel.DataAnnotations;

namespace WebsiteQuanLyNhaSach.Models
{
    public class LoaiSP
    {
        [Key]
        public int Ma { get; set; }

        [Required, StringLength(500)]
        public string? Ten { get; set; }
        [Required, StringLength(500)]
        public string? MoTa { get; set; }
        public List<SanPham>? SanPhams { get; set; }
    }
}
