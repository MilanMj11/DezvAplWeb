using Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Controllers
{
    internal class StudentsController
    {
        private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Dragos" },
            new Student { Id = 2, Name = "Marius" },
            new Student { Id = 3, Name = "Andrei" }
        };

        [HttpGet("byId")]
        public Student Get(int id)
        {
            return students.FirstOrDefault(s => s.Id.Equals(id));
        }


    }
}
