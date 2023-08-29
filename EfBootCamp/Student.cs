using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfBootCamp
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; } = String.Empty;
        [StringLength(30)]
        public string Email { get; set; } = String.Empty;
        [StringLength(30)]
        public string Phone { get; set; } = String.Empty;
    }
}
