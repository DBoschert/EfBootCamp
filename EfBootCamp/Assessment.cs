using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfBootCamp
{
    public class Assessment
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Topic { get; set; } = "N/A";
    }
}
