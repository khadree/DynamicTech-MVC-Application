using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicTechMVC.Entities
{
    public class CategoryItem
    {
        private DateTime _releasedDate = DateTime.MinValue;
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Please select a valid item'{0}' dropdown list")]
        [Display(Name = "Media Type")]
        public int MediaTypeId { get; set; }
        [NotMapped]
        public virtual ICollection<SelectListItem> MediaType { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Release Date")]
        public DateTime DateReleased 
        {
            get
            {
                return (_releasedDate == DateTime.MinValue) ? DateTime.Now : _releasedDate;
            }
            set 
            {
                _releasedDate = value;
            }
        }
        [NotMapped]
        public int ContentId { get; set; }
    }
}
