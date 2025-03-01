﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Range(0, 100, ErrorMessage ="Display order deve ter um número entre 1 e 100")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
