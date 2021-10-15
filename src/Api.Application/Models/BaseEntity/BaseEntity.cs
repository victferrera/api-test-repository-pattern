using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Application.Models.Base
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdateAt { get; set; }
    }
}