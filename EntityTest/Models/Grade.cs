﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.Models
{
    internal class Grade
    {
        [Key]
        public int Id { get; set; }
        public decimal physics { get; set; }
        public decimal chimistry { get; set; }
        public decimal programming { get; set; }
        [ForeignKey("student")]
        public int studentId { get; set; }
        public Student student { get; set; }

    }
}
