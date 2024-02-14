using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.Models
{
    internal class Gender
    {
        [Key]
        public int Id { get; set; }
        public string GenderName { get; set; }
    }
}
