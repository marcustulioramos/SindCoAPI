using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SindCoAPI.Models
{
    public class Apartment
    {
        public int Id { get; set; }
        [Required]
        public string Number { get; set; }
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
        public string Floor { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int BuildingId { get; set; }
        public Building Building { get; set; }
    }
}