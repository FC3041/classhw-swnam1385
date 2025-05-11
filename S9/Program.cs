using System.Diagnostics;
using System.Text;

namespace S9con;

class Program
{
    
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter name :");
            string Studentname = Console.ReadLine();
            Console.WriteLine("Enter stid :");
            int Studentid = Console.ReadLine();
            Console.WriteLine("Enter natid :");
            int Nationalid = Console.ReadLine();
            Console.WriteLine("Enter Credits :");
            int Studentcredits = Console.ReadLine();
            Console.WriteLine("Enter Activity :");
            bool Activity = Console.ReadLine();

            Student s = new Student( Studentname,Studentid,Nationalid,Studentcredits,Activity);
            File.AppendAllText("student.csv" , s.Tosrting() + Environment.NewLine);
            Console.WriteLine("Student added successfully");
        }
        
    }
} 
