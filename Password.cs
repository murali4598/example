using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApi.Entities;

namespace WebApi.Models
{
    public class Password
    {
        [Key]
        public int PId { get; set; }
        public string OTP { get; set; }
        public int Id { get; set; }

        [ForeignKey("Id")]
        public User Users { get; set; }

        public int IsActive { get; set; }
        public DateTime? OTPExpires { get; set; }

    }
}
