using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SindCoAPI.Models
{
    public class Complex
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter name")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime CreatedAt { get; set; }
        [Required]
        public string CreatedById { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        public string StatusById { get; set; }
        [Required]
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
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter valid telephone number.")]
        public string Telephone { get; set; }
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        public ICollection<Block> Blocks { get; set; }


    }
}