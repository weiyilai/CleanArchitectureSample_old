using CleanArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Web.ApiModels
{
    public class CategoriesDTO
    {
        public int CategoryID { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public byte[] Picture { get; set; }

        public static CategoriesDTO FromCategories(Categories item)
        {
            return new CategoriesDTO()
            {
                CategoryID = item.CategoryID,
                CategoryName = item.CategoryName,
                Description = item.Description,
                Picture = item.Picture
            };
        }
    }
}
