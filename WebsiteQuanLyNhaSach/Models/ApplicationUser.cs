using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace WebsiteQuanLyNhaSach.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, StringLength(500)]
        public string? Ten { get; set; }
        [Required, StringLength(50)]
        public string? GioiTinh { get; set; }
        [Required, StringLength(500)]
        public string? DiaChi { get; set; }
        [Required, StringLength(500)]
        public string? Anh { get; set; }
        [Required, StringLength(500)]
        public string? Quyen { get; set; }
    }
}

