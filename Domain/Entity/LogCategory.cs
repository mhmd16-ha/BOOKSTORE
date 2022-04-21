using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class LogCategory
    {
        [Key]
        public int Id { get; set; }
        public string Action { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category category { get; set; }
    }
}
