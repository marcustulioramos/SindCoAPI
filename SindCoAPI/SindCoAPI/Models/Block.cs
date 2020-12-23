using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SindCoAPI.Models
{
    public class Block
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime CreatedAt { get; set; }
        [Required]
        public int CreatedById { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        public int StatusById { get; set; }
        [Required]
        public DateTime StatusDate { get; set; }
        [Required]
        public int ComplexId { get; set; }
        public Complex Complex { get; set; }
        public ICollection<Building> Buildings { get; set; }
    }
}