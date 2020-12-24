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
        [Required(ErrorMessage = "Please enter name")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a date")]
        [Display(Name = "Created at")]
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
        [Required(ErrorMessage = "Please enter valid address")]
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }
        [Required(ErrorMessage = "Please enter a city")]
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "County")]
        public string County { get; set; }
        [Required(ErrorMessage = "Please enter country")]
        [Display(Name = "Country")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Please enter postcode")]
        [Display(Name = "Postcode")]
        public string PostCode { get; set; }
        [Required(ErrorMessage = "Please assign a block")]
        [Display(Name = "Block")]
        public int BlockId { get; set; }
        public Block Block { get; set; }
        public ICollection<Apartment> Apartments { get; set; }
    }
}