namespace s16con;

class Program
{
    static void print_citizen(Citizen[] cs)
    {
        foreach(var c in cs)
            Console.WriteLine(c.ToString());
    }
    static void Main(string[] args)
    {
        Citizen k = new Citizen("Kane", "Dave", 1, true);
        Student s = new Student(
            "Zari", "Hedayati", 2, "Math", 403521, false);
        GradStudent gs = new GradStudent(
            "Pari", "Hedayati", 2, "Math", 403521, false,
            "Calculus", "Integral");
        Citizen[] citizens = new Citizen[]{k, s, gs};
        // print_citizen(citizens);
        // System.Console.WriteLine(k);
        // System.Console.WriteLine(s);
        // System.Console.WriteLine(gs);
        s.Register("Numericals");
        gs.Register("Numericals 2");
        Teacher t = new Teacher("aryam","Fallah",37,false,3550.25,9,40458);
        System.Console.WriteLine(t);
        Teacher e= new Teacher("Akbar", "Karbasi",17,true,3283.89,3,403290);
        Teacher g = new Teacher("Zahra","Barzegar",89,false,87799.09,5,402568);
        Teacher[] teachers = new Teacher[]{
            e,g
        };
        System.Console.WriteLine(e);
        System.Console.WriteLine(g);
    }
}
