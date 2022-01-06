using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicTechMVC.Models
{
    public class GroupedCategoryItemsByCategoryModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IGrouping<int, CategoryItemDetailModel> Items { get; set; }
    }
}
