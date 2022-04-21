using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resource.ResourceData), ErrorMessageResourceName = "BookName")]
        [MaxLength(20, ErrorMessageResourceType = typeof(Resource.ResourceData), ErrorMessageResourceName = "MaxLenght")]
        [MinLength(3, ErrorMessageResourceType = typeof(Resource.ResourceData), ErrorMessageResourceName = "MinLenght")]
        public string Name { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resource.ResourceData), ErrorMessageResourceName = "AuthorName")]
        [MaxLength(20, ErrorMessageResourceType = typeof(Resource.ResourceData), ErrorMessageResourceName = "MaxLenght")]
        [MinLength(3, ErrorMessageResourceType = typeof(Resource.ResourceData), ErrorMessageResourceName = "MinLenght")]
        public string Author { get; set; }
        public string ImageName { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public bool Publish { get; set; }
        public int CurrentStaut { get; set; }

        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category category { get; set; }
        public int? SubCategoryId { get; set; }
        [ForeignKey("SubCategoryId")]
        public SubCategory subcategory { get; set; }

    }
}
