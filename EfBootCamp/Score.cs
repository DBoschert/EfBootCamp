using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfBootCamp
{
    public class Score
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public virtual Student? Student { get; set; }
        public int AssessmentId { get; set; }
        public virtual Assessment? Assessment { get; set; }
        public int Points { get; set; }
    }
}
