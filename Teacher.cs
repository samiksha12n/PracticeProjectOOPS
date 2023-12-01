using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    public class Teacher
    {
        public string TName { get; set; }
        public int TClass { get; set; }
        public string TSection { get; set; }
        List<dynamic> teachers = new List<dynamic>();
        public void AddTeacher()
        {
            Console.WriteLine("Enter Teacher Name");
            TName = Console.ReadLine();
            teachers.Add(TName);
            Console.WriteLine("Enter Teacher Class");
            TClass = int.Parse(Console.ReadLine());
            teachers.Add(TClass);
            Console.WriteLine("Enter Teacher Section");
            TSection = Console.ReadLine();
            teachers.Add(TSection);
        }
        public void Display()
        {
            if (teachers.Count < 0)
            {
                Console.WriteLine("No data found Add Details");
            }

            else
            {
                foreach (dynamic teacher in teachers)
                {
                    Console.WriteLine("***** Teacher Details are as follows *****");
                    Console.WriteLine("Teacher Name:\t"+TName);
                    Console.WriteLine("Teacher Class:\t"+TClass);
                    Console.WriteLine("Teacher Section:\t"+TSection);
                }
            }
        }
    }
}
