using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLab2._4.Model
{
    internal class Grade
    {
        public int GradeId { get; set; }
        public int StudentId { get; set; }
        public required string Grades { get; set; }

    }
}
