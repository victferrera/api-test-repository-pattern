using System;
using System.ComponentModel.DataAnnotations;
using Api.Application.Models.Base;

namespace Api.Application.Models
{
    public class Person : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string Country { get; set; }
    }
}