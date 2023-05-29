using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AreaCalculator
{
    internal class Program
    {
        //this project is written for the open closed principle
        static void Main(string[] args)
        {
            // 
            Areas.Rectangle rectangle = new Areas.Rectangle(20, 50);
            Console.Write(rectangle.Area());
            
        }
    }
}
