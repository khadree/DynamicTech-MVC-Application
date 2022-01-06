﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicTechMVC.Entities
{
    public class UserCategory
    {
        [Key]
        public int Id { get; set; }      
        public string UserId { get; set; }
        public int  CategoryId { get; set; }
    }
}