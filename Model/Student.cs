using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLab2._4.Model
{
    internal class Student
    {
        public required int RollNumber { get; set; }
        public required string Name { get; set; }
        public double PhysicsMarks { get; set; }
        public double ChemistryMarks { get; set; }
        public double ComputerApplicationMarks { get; set; }
        public double TotalMarks => PhysicsMarks + ChemistryMarks + ComputerApplicationMarks;
        public double Percentage => (TotalMarks / 300) * 100;
        public string Division
        {
            get
            {
                switch (Percentage)
                {
                    case >= 80:
                        return "First";
                    case >= 60:
                        return "Second";
                    case >= 50:
                        return "Third";
                    default:
                        return "Fail";
                }
            }
        }
    }
}
