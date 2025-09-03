using ChallengeLab2._4.Model;

namespace ChallengeLab2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = ReadStudentDetails();
            DisplayStudentDetails(student);
        }

        public static Student ReadStudentDetails()
        {
            Console.Write("Input the Roll Number of the student: ");
            int rollNumber = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Input the Name of the Student: ");
            string name = Console.ReadLine() ?? string.Empty;
            Console.Write("Input the marks of Physics, Chemistry and Computer Application: ");
            string[] marks = (Console.ReadLine() ?? "0 0 0").Split(' ');
            double physicsMarks = 0, chemistryMarks = 0, computerApplicationMarks = 0;
            if (marks.Length == 3)
            {
                physicsMarks = double.Parse(marks[0]);
                chemistryMarks = double.Parse(marks[1]);
                computerApplicationMarks = double.Parse(marks[2]);
            }
            else
            {
                Console.WriteLine("Invalid input for marks. Please enter three values.");
            }

            return new Student
            {
                RollNumber = rollNumber,
                Name = name,
                PhysicsMarks = physicsMarks,
                ChemistryMarks = chemistryMarks,
                ComputerApplicationMarks = computerApplicationMarks
            };
        }
        public static void DisplayStudentDetails(Model.Student student)
        {
            Console.WriteLine($"Roll No : {student.RollNumber}\nName of Student : {student.Name}");
            Console.WriteLine($"Marks in Physics : {student.PhysicsMarks}\nMarks in Chemistry : {student.ChemistryMarks}\nMarks in Computer Application : {student.ComputerApplicationMarks}");
            Console.WriteLine($"Total Marks = {student.TotalMarks}\nPercentage = {student.Percentage:F2}\nDivision = {student.Division}");
        }
    }
}
