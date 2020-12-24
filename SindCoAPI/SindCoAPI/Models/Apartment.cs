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
        [Required(ErrorMessage = "Please enter number")]
        [Display(Name = "Number")]
        public string Number { get; set; }
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
        [Required(ErrorMessage = "Please enter floor")]
        [Display(Name = "floor")]
        public string Floor { get; set; }
        [Required(ErrorMessage = "Please enter type")]
        [Display(Name = "Type")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Please assign a building")]
        [Display(Name = "Building")]
        public int BuildingId { get; set; }
        public Building Building { get; set; }
    }
}