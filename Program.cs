using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Student st = new Student();
                Subject sub = new Subject();
                Teacher obj = new Teacher();
                Console.WriteLine("Choose the operation");
                Console.WriteLine("1.Add and Display Student Details\n 2.Add and Display Subject Details\n 3.Add and Display Teacher Details ");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            st.AddStudent();
                            st.Display();
                            break;
                        }
                    case 2:
                        {
                            sub.AddSubject();
                            sub.Display();
                            break;
                        }
                    case 3:
                        {
                            obj.AddTeacher();
                            obj.Display();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Choice");
                            break;
                        }
                }
                Console.WriteLine("If you want to continue press .....y");
                choice = Console.ReadLine();
            } while (choice == "y");
            Console.ReadKey();
        }
    }
}
