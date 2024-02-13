using System;
using System.Linq.Expressions;

namespace Weight;
public class Person
{
    public string Name { get; set; }
    public int Weight { get; set; }
}

class Assignment1OrQuiz1
{
    static void Main(string[] args)
    {
        int weighttotal = 0;
        List<Person> list = new List<Person>();

        while (true)
        {
            Console.WriteLine("Enter a new person? [Y/N] ");

            if (Console.ReadLine() == "N")
            {
                break;
            }

            Person timbang = new Person();
            Console.WriteLine("Name: ");
            timbang.Name = Console.ReadLine();
            Console.WriteLine("Weight: ");
            timbang.Weight = int.Parse(Console.ReadLine());

            list.Add(timbang);

        }

        list.ForEach
        (x =>
        {
            Console.WriteLine("+++++++++++++");
            Console.WriteLine(x.Name);
            Console.WriteLine(x.Weight);
            weighttotal = weighttotal + (x.Weight);
        }
        );
        Console.WriteLine("+++++++++++++");
        Console.WriteLine("Everyone's total weight is: " + weighttotal);
    }
}