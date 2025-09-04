using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLab2._4.Model
{
    internal class Student
    {
        public required int StudentId { get; set; }
        public required string Name { get; set; }
        public string StudentInfo { get; set; } = string.Empty;
        public double PhysicsGrades { get; set; }
        public double ChemistryGrades { get; set; }
        public double ComputerApplicationGrades { get; set; }
        public double TotalGrades => PhysicsGrades + ChemistryGrades + ComputerApplicationGrades;
        public double Percentage => (TotalGrades / 300) * 100;
        public double GPA
        {
            get
            {
                switch (Percentage)
                {
                    case >= 90:
                        return 4.0;
                    case >= 80:
                        return 3.0;
                    case >= 70:
                        return 2.0;
                    case >= 60:
                        return 1.0;
                    default:
                        return 0;
                }
            }
        }
        public string Division
        {
            get
            {
                switch (Percentage)
                {
                    case >= 90:
                        return "First";
                    case >= 80:
                        return "Second";
                    case >= 70:
                        return "Third";
                    case >= 60:
                        return "Fourth";
                    case >= 50:
                        return "Fifth";
                    default:
                        return "Fail";
                }
            }
        }
    }
}
