using System;
using Classes.Math;

namespace Classes
{
  
    class Program
    {
        static void Main(string[] args)
        {
                var jim = new Person();
                jim.FirstName = "Jim";
                jim.LastName = "Doyle";
                jim.Introduce();

            
        var     a = 1000;
        var     b = 10;
        var     c = 5;
        var     calculator = new Calculator();
        
        var     multiply = calculator.Multiply(a, b);
        var   divide = calculator.Divide(a, b, c);

    
            Console.WriteLine(multiply+"   "+divide);
        }
    }
}
