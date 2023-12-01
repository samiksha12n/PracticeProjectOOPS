using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    public class Student
    {
        public string SName { get; set; }
        public int SClass { get; set; }
        public char Section { get; set; }
        List<dynamic> students=new List<dynamic>();

        public void AddStudent()
        {
            Console.WriteLine("Enter the Student Name");
            SName = Console.ReadLine();
            students.Add(SName);
            Console.WriteLine("Enter the Student class");
            SClass=int.Parse(Console.ReadLine());
            students.Add(SClass);
            Console.WriteLine("Enter the Section");
            Section=char.Parse(Console.ReadLine());
            students.Add(Section);
        }
        public void Display()
        {
            if (students.Count < 0)
            {
                Console.WriteLine("No Details Found Add Details!!!");
            }
            else
            {
                foreach (dynamic student in students)
                {
                    Console.WriteLine("******* Student Details are as follows ******");
                    Console.WriteLine("Student Name:\t"+SName);
                    Console.WriteLine("Student Class:\t"+SClass);
                    Console.WriteLine("Student Section:\t"+Section);
                }
            }
        }
    }
}
