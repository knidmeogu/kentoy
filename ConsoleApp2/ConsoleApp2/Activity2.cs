using System;
using System.Linq.Expressions;

namespace HelloWorld2;
public class Stututu
{ 
    public string Brand { get; set; }
    public string Color { get; set; }
    public int Price { get; set; }

    public void Beepbeep(string stringVariable)
    { 
        Console.WriteLine($"{stringVariable}: Beeeeep!!!");
    }
}

class Activity2
{
    static void Main(string[] args)
    {
        List<Stututu> list = new List<Stututu>();

        while (true)
        {
            Console.WriteLine("Enter new data? [Y/N] ");

            if (Console.ReadLine() == "N")
            {
                break;
            }

            Stututu car1 = new Stututu();
            Console.WriteLine("What Brand? ");
            car1.Brand = Console.ReadLine();
            Console.WriteLine("What Color? ");
            car1.Color = Console.ReadLine();
            Console.WriteLine("How Much? ");
            car1.Price = int.Parse(Console.ReadLine());

            list.Add(car1);

        }

        list.ForEach
        (x =>
            {
                Console.WriteLine(x.Brand);
                Console.WriteLine(x.Color);
                Console.WriteLine(x.Price);
                Console.WriteLine("+++++++++++++");
            }
        );
    }
}