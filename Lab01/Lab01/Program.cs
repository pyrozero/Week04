using System;
namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string na, ln,ids;
            double gpa;
            Console.WriteLine("\t::Input::");
            Console.Write("Please enter Name :");
            na = Console.ReadLine();
            Console.Write("Please enter Lastname :");
            ln = Console.ReadLine();
            Console.Write("Your ID:");
            ids = Console.ReadLine();
            Console.Write("GPA :");
            gpa = Console.ReadLine();

           
            Console.WriteLine("\t::Output:: ");
            Console.WriteLine("Name     :{0}",na);
            Console.WriteLine("Lastname :{0}",ln);
            Console.WriteLine("ID       :{0}",ids);

            Console.WriteLine("GPA      :{0:F2}",gpa);





        }
    }
}
