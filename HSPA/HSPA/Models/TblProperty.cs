using HSPA.Models.EFCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HSPA.Models
{
    public partial class TblProperty : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Property Type is required")]
        public string PropertyType { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }
        public string Facing { get; set; }
        public string FurnishedStatus { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public string Price { get; set; }
    }
}
