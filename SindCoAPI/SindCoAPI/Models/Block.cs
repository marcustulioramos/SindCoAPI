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
        [Required(ErrorMessage = "Please enter name")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter date")]
        [Display(Name = "Created at")]
        [DataType(DataType.Time)]
        public DateTime CreatedAt { get; set; }
        [Required(ErrorMessage = "Please enter a user")]
        [Display(Name = "Created by")]
        public string CreatedById { get; set; }
        [Required(ErrorMessage = "Please enter status")]
        [Display(Name = "Status")]
        public int Status { get; set; }
        [Required(ErrorMessage = "Please enter a user")]
        [Display(Name = "Status updated by")]
        public string StatusById { get; set; }
        [Required(ErrorMessage = "Please enter date")]
        [Display(Name = "status updated at")]
        public DateTime StatusDate { get; set; }
        [Required(ErrorMessage = "Please assign a complex")]
        [Display(Name = "Complex")]
        public int ComplexId { get; set; }
        public Complex Complex { get; set; }
        public ICollection<Building> Buildings { get; set; }
    }
}