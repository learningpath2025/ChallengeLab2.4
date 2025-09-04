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
            Console.Write("Input the student Id: ");
            int studentId = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Input the Name of the Student: ");
            string name = Console.ReadLine() ?? string.Empty;
            Console.Write("Input student information: ");
            string studentInfo = Console.ReadLine() ?? string.Empty;
            Console.Write("Input the grades of Physics, Chemistry and Computer Application: ");
            string[] grades = (Console.ReadLine() ?? "0 0 0").Split(' ');
            double physicsGrades = 0, chemistryGrades = 0, computerApplicationGrades = 0;
            if (grades.Length == 3)
            {
                physicsGrades = double.Parse(grades[0]);
                chemistryGrades = double.Parse(grades[1]);
                computerApplicationGrades = double.Parse(grades[2]);
            }
            else
            {
                Console.WriteLine("Invalid input for grades. Please enter three values.");
            }

            return new Student
            {
                StudentId = studentId,
                Name = name,
                PhysicsGrades = physicsGrades,
                ChemistryGrades = chemistryGrades,
                ComputerApplicationGrades = computerApplicationGrades
            };
        }
        public static void DisplayStudentDetails(Model.Student student)
        {
            Console.WriteLine($"Student Id : {student.StudentId}\nName of the Student : {student.Name}\nStudent Information: {student.StudentInfo}");
            Console.WriteLine($"Grade in Physics : {student.PhysicsGrades}\nGrade in Chemistry : {student.ChemistryGrades}\nGrade in Computer Application : {student.ComputerApplicationGrades}");
            Console.WriteLine($"Total Grade = {student.TotalGrades}\nPercentage = {student.Percentage:F2}\nGPA = {student.GPA}\nDivision = {student.Division}");
        }
    }
}
