﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.Models
{
    internal class StudentBook
    {
        public int Id { get; set; }
        [ForeignKey("student")]
        public int studentId { get; set; }
        public Student student { get; set; }
        [ForeignKey("book")]
        public int bookId { get; set; }
        public Book book { get; set; }

    }
}
