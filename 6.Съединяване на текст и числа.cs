using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

public class Program
{

    public static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        string age = Console.ReadLine();
        string town = Console.ReadLine();

        Console.WriteLine("You are" + ' ' + firstName + ' ' + lastName + ',' + ' ' + "a" + ' ' + age  + '-' + "years old person from" + ' '
          + town + '.') ;
    }
}