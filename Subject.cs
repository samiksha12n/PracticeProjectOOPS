using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    public class Subject
    {
        public string SubjectName { get; set; }
        public int SubjectId { get; set; }
        public string Teacher { get; set; }
        List<dynamic> subjects { get; set; }   

        public void  AddSubject()
        {
            Console.WriteLine("Enter the Subject Name");
            subjects = new List<dynamic>();
            SubjectName=Console.ReadLine();
            subjects.Add(SubjectName);
            Console.WriteLine("Enter the Subject Code");
            SubjectId=int.Parse(Console.ReadLine());
            subjects.Add(SubjectId);
            Console.WriteLine("Enter the Teacher for the Subject");
            Teacher = Console.ReadLine();
            subjects.Add(Teacher);
        }
        public void Display()
        {
            if (subjects.Count < 0)
            {
                Console.WriteLine("No Data Found Add Details!!!");
            }
            else
            {
                Console.WriteLine("******* The Subject Details as follows ******");
                foreach (dynamic subject in subjects)
                {
                    Console.WriteLine("Subject Name:\t"+SubjectName);
                    Console.WriteLine("Subject code:\t"+SubjectId);
                    Console.WriteLine("Subject Teacher:\t"+Teacher);

                }
            }
        }


    }
}
