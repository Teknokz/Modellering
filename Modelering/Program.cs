using System;
using System.Collections.Generic;

namespace Modelering
{
    class Program
    {
        static void Main(string[] args)
        {
            footbal theBall = new footbal();
            footbal theOtherBall = new footbal();

            car c1 = new car();
            car c2 = new car();
            
            c1.name = "Toyota Corolla";
            c2.name = "Toyota Prius";


            List<car> Toyota = new List<car>();

            theBall.x = 40;
            theOtherBall.x = 60;

            System.Console.WriteLine(theBall.x);

            Console.ReadLine();
        }
    }
}
