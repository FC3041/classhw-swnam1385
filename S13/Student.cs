
interface IPerson<_Type>: IComparable<IPerson<_Type>>
{
    _Type Id {get; set;}
    string FirstName {get; set;}
    string LastName {get; set;}

    string FullName {get;}
}




class PersonComparers
{
    // TODO3 include all comparers in this singleton class.(full name tarif shodeh)
    
    public static PersonFirstNameComparer PersonFirstNameComparer = new ();
    public static PersonIdComparer PersonIdComparer = new();
    public static PersonFullNameComparer PersonFullNameComparer = new();
    public static PersonLastNameComparer PersonLastNameComparer = new();
}



// TODO1 implementPersonIdComparer
class PersonIdComparer : IComparer<IPerson<int>>
{
    public int Compare(IPerson<int> x, IPerson<int> y)
    {
        return x.Id.CompareTo(y.Id);
    }
}





// TODO2 implementPersonFullNameComparer
class PersonFullNameComparer : IComparer<IPerson<int>>
{
    public int Compare(IPerson<int> x, IPerson<int> y)
    {
        return x.FullName.CompareTo(y.FullName);
    }
}




class PersonFirstNameComparer : IComparer<IPerson<int>>
{
    public int Compare(IPerson<int> x, IPerson<int> y)
    {
        return x.FirstName.CompareTo(y.FirstName);
    }
}



class PersonLastNameComparer : IComparer<IPerson<int>>
{
    public int Compare(IPerson<int> x, IPerson<int> y)
    {
        return x.LastName.CompareTo(y.LastName);
    }
}



class Student: IPerson<int>
{
    public string FirstName {get; set;}
    public string LastName { get; set;}
    public string FullName => FirstName + " " + LastName;

    public double GPA {get; set;}
    public int Id { get; set; }

    // public int CompareTo(Student other)

    public int CompareTo(IPerson<int> other)  => FirstName.CompareTo(other.FirstName);

    public override string ToString() => $"{FullName}\t{GPA}\t{Id}";
}
class Teacher: IPerson<string>
{
    public string FirstName {get; set;}
    public string LastName { get; set;}
    public string FullName => FirstName + LastName;
    public double Rating {get; set;}
    public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public int CompareTo(IPerson<string> other)
    {
        throw new NotImplementedException();
    }
}

