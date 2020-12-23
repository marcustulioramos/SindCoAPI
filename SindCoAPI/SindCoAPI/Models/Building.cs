using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SindCoAPI.Models
{
    public class Building
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public int CreatedById { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        public int StatusById { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime StatusDate { get; set; }
        [Required]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        [Required]
        public string City { get; set; }
        public string County { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string PostCode { get; set; }
        [Required]
        public int BlockId { get; set; }
        public Block Block { get; set; }
        public ICollection<Apartment> Apartments { get; set; }
    }
}