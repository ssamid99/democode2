using System;

namespace ConsoleApp2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 student1 = new Class2();
            student1.Name = "Ali";
            student1.Catagory = "Ehmedov";
            student1.Area = 23;
            student1.Price = 12;
            Class2 student2 = new Class2();
            student2.Name = "Al";
            student2.Catagory = "Ehmedov";
            student2.Area = 23;
            student2.Price = 23;
            Class2 student3 = new Class2();
            student3.Name = "li";
            student3.Catagory = "Ehmedov";
            student3.Area = 23;
            student3.Price = 34;
            Class2 student4 = new Class2();
            student4.Name = "Ai";
            student4.Catagory = "Ehmedov";
            student4.Area = 23;
            student4.Price = 45;

            Class2[] students = new Class2[4];
            students[0] = student1;
            students[1] = student2;
            students[2] = student3;
            students[3] = student4;

            foreach (var x in students)
            {
                x.GetTwo();
                Console.WriteLine("-------------");
            }
        }
    }
}
