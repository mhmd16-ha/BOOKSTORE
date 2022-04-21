using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessageResourceType =typeof(Resource.ResourceData),ErrorMessageResourceName = "CategoryName")]
        [MaxLength(20, ErrorMessageResourceType = typeof(Resource.ResourceData), ErrorMessageResourceName = "MaxLenght")]
        [MinLength(3, ErrorMessageResourceType = typeof(Resource.ResourceData), ErrorMessageResourceName = "MinLenght")]

        public string Name { get; set; }
        public string Description { get; set; }
        public int CurrentStaut { get; set; }
    }
}
