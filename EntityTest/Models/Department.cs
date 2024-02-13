using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.Models
{
     internal class Department
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter department name")]
        public string Name { get; set; }
        [MaxLength(10,ErrorMessage="Describtion must be not more than 10 characters")]
        public string? Describtion { get; set; }
        public ICollection<Student> students { get; set; }
    }
}
