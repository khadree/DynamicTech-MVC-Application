﻿using DynamicTechMVC.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicTechMVC.Entities
{
    public class Category: IPrimaryProperties
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200,MinimumLength = 2)]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        [Display(Name ="Thumbnail Image Path ")]
        public string ThumbnailImagePath { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ICollection<CategoryItem> CategoryItems { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ICollection<UserCategory> UserCategory { get; set; }
    }
}
