using System;
using VisitorPattern.src;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IProduct car = new Car();
            IVisitor addTax = new AddTax();
            car.accept(addTax);
            Console.WriteLine(car.getPrice());
        }
    }
}
