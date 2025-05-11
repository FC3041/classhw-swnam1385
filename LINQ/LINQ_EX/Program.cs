using System.Collections.Concurrent;
using System.Diagnostics.Contracts;

namespace LINQ_EX;

class Program
{
    static void Main1(string[] args) 
    {
        File.ReadAllLines("data.csv")
        .Where(l=>l.ToLower().Contains("iran"))
        .Where(l=>l.ToLower().Contains("at birth"))
        .Where(l=>l.ToLower().Contains("both"))
        .Select(l=>
        {
            string[] tokens=l.Split(",");


            string hope=tokens[0];

            string country=tokens[3];
            string gender=tokens[4];
            string nerkhomid=tokens[6];

            return (country:country,hope:hope,gender:gender, nerkhomid:nerkhomid);
        }
        )
        .ToList()
        .ForEach(l=>System.Console.WriteLine(l));
        
    }
    static void Main(string[] args)
    {
        var data=File.ReadAllLines("data.csv")
        .Where(l=>l.ToLower().Contains("iran"))
        .Where(l=>l.ToLower().Contains("at birth"))
        .Where(l=>l.ToLower().Contains("both"))
        .Select(l=>
        {
            string[] tokens=l.Split(",");
            string hope=tokens[0];
            string country=tokens[3];
            string gender=tokens[4];
            string numberString = tokens[6].Replace(".", "/");
            double nerkhomid=double.Parse(numberString);

            return (country:country,hope:hope,gender:gender, nerkhomid:nerkhomid);
        }
        );

        double nerkhomidmin=data.Min(l=>l.nerkhomid);
        double nerkhomidmax=data.Max(l=>l.nerkhomid);
        double difference=nerkhomidmax-nerkhomidmin;

        System.Console.WriteLine(difference);

    }

    static void Main3(string[] args)
    {
        var data=File.ReadAllLines("data.csv")
        .Where(l=>l.ToLower().Contains("both"))
        .Where(l=>l.ToLower().Contains("at birth"))
        .Select(l=>
        {
                string[] tokens=l.Split(",");
                string country=tokens[3];
                double nerkhomid  = double.Parse(tokens[6].Replace(".", ","));
                int year=int.Parse(tokens[1]);
                return (country:country,nerkhomid:nerkhomid);


        });

        data.GroupBy(l=>l.country)
        .Select(g=>
        
        
        {
            var min=g.Min(x=>x.nerkhomid);
            var max=g.Max(x=>x.nerkhomid);
            var minimumHope = g.First(x => x.nerkhomid == min);
            var diff=max-min;
            return (diff:diff, min:min,minimumHope:minimumHope, country:g.Key);
        });
    }
}
