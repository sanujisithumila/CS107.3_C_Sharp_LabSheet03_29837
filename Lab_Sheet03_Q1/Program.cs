using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Sheet03_Q1
{
    public class Course
    {
        // Private fields
        private string courseName;
        private string instructorName;
        private double grade;

        // Public properties
        public string CourseName
        {
            get { return courseName; }
        }

        public double Grade
        {
            get { return grade; }
        }

        // Constructor
        public Course(string courseName, string instructorName, double grade)
        {
            this.courseName = courseName;
            SetInstructorName(instructorName);
            SetGrade(grade);
        }

        // Public method to set instructor name
        public void SetInstructorName(string instructorName)
        {
            if (string.IsNullOrWhiteSpace(instructorName))
            {
                throw new ArgumentException("Instructor name cannot be empty or null.");
            }

            this.instructorName = instructorName;
        }

        // Private method to validate and set the grade
        private void SetGrade(double grade)
        {
            if (grade < 0 || grade > 100)
            {
                throw new ArgumentOutOfRangeException("Grade must be between 0 and 100.");
            }

            this.grade = grade;
        }

        // Private method to calculate letter grade
        private string CalculateLetterGrade()
        {
            if (grade >= 90)
                return "A";
            else if (grade >= 80)
                return "B";
            else if (grade >= 70)
                return "C";
            else if (grade >= 60)
                return "D";
            else
                return "F";
        }

        // Public method to print course info
        public void PrintCourseInfo()
        {
            string letterGrade = CalculateLetterGrade();
            Console.WriteLine($"Course: {courseName}");
            Console.WriteLine($"Instructor: {instructorName}");
            Console.WriteLine($"Grade: {letterGrade}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            Course course = new Course("Computer Science", "Dr. Smith", 85.5);
            course.PrintCourseInfo();
            Console.ReadLine();
        }
    }
}
