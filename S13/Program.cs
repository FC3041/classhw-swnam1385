namespace s13con;

class Program
{
    // public static void PrintPerson(Student s)
    // {
    //     Console.WriteLine(s.FullName);
    // }

    // public static void PrintPerson(Teacher s)
    // {
    //     Console.WriteLine(s.FullName);
    // }    
    public static void PrintPersons(IPerson<int>[] ps)
    {
        foreach(var p in ps)
            Console.WriteLine(p);
    }    
    public static void Main(string[] args)
    {
        Student [] students = new Student[] { 
            new Student() {
                FirstName="Nima",
                LastName="Hamedi",
                GPA = 17.23,
                Id = 21
            },
            new Student() {
                FirstName="Maryam",
                LastName="Kashani",
                GPA = 19.5,
                Id = 23
            },
            new Student() {
                FirstName="Zhaleh",
                LastName="Aras",
                GPA = 18.11,
                Id = 19
            },
            new Student() {
                FirstName="Seda",
                LastName="Rahamni",
                GPA = 19,
                Id = 13
            },
        };

        PrintPersons(students);

        MySort(students, PersonComparers.PersonFirstNameComparer);
        System.Console.WriteLine("----------------");
        PrintPersons(students);

        

        MySort(students, new PersonLastNameComparer());
        System.Console.WriteLine("----------------");
        PrintPersons(students);

        // Teacher t = new Teacher() {
        //     FirstName = "Zari",
        //     LastName="Mohasebi"
        // };
        // PrintPerson(s);
        // PrintPerson(t);

    }

    private static void MySort(IPerson<int>[] persons, IComparer<IPerson<int>> cmp)
    {
        for(int i=0; i<persons.Length; i++)
            for(int j=i+1; j<persons.Length;j++)
                if (cmp.Compare(persons[i], persons[j]) > 0)
                    swap<IPerson<int>>(persons, i, j);
    }

    private static void swap<T>(T[] items, int i, int j)
    {
        T tmp = items[i];
        items[i] = items[j];
        items[j] = tmp;
    }

    #region Hide
    static void Main2(string[] args)
    {
        try
        {
            int x = 0;
            int w = 5 / x;

            // code after potential error
        }
        catch(FormatException e)
        {
            // code error handling
            Console.WriteLine(e.Message);
            throw;
        }
        catch(NullReferenceException nfe)
        {

        }
        finally
        {

        }
    }
    #endregion
}
