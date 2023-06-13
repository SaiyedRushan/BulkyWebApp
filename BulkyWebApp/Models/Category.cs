﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWebApp.Models
{
    public class Category
    {
        // data annotation []
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100)]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;


    }
}
