using System;
using System.ComponentModel.DataAnnotations;

namespace HL_NET.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Họ tên là bắt buộc")]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email là bắt buộc")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mật khẩu là bắt buộc")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Mật khẩu ít nhất 6 ký tự")]
        public string Password { get; set; }

        [Range(0, 150, ErrorMessage = "Tuổi phải từ 0 đến 150")]
        public int Age { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}