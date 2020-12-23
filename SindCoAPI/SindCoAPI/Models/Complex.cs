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
        [Required(ErrorMessage = "Please enter Created Date")]
        [Display(Name = "Created at")]
        [DataType(DataType.Time)]
        public DateTime CreatedAt { get; set; }
        [Required(ErrorMessage = "Please enter user")]
        [Display(Name = "Created by")]
        public string CreatedById { get; set; }
        [Display(Name = "Status")]
        [Required(ErrorMessage = "Please enter status")]
        public int Status { get; set; }
        [Required(ErrorMessage = "Please enter user")]
        [Display(Name = "Status changed by")]
        public string StatusById { get; set; }
        [Required(ErrorMessage = "Please enter date")]
        [Display(Name = "Status changed at")]
        public DateTime StatusDate { get; set; }
        [Required(ErrorMessage = "Please enter valid address")]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }
        [Required(ErrorMessage = "Please enter city")]
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "County")]
        public string County { get; set; }
        [Required(ErrorMessage = "Please enter country")]
        [Display(Name = "Country")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Please enter the postcode")]
        [Display(Name = "PostCode")]
        public string PostCode { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter valid telephone number.")]
        [Display(Name = "Phone")]
        public string Telephone { get; set; }
        [Required(ErrorMessage = "Please enter a valid email")]
        [Display(Name = "Email")]
        [EmailAddress]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        public ICollection<Block> Blocks { get; set; }


    }
}