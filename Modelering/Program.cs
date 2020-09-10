using System;
using System.Collections.Generic;

namespace Modelering
{
    class Program
    {
        static void Main(string[] args)
        {

            //Rocket League spel? Bilar och Fotbollar...

            footbal theBall = new footbal();
            footbal theOtherBall = new footbal();

            car c1 = new car();
            car c2 = new car();
            car c3 = new car();
            
            c1.name = "Toyota Corolla";
            c2.name = "Toyota Prius";
            c3.name = "Volvo v60";

            c1.speed = 42;
            c2.speed = 12;
            c3.speed = 20;

            c1.fuel = 100;
            c2.fuel = 100;
            c3.fuel = 100;

            System.Console.WriteLine("Bränsle:" + c1.name + " " + c1.fuel + " %" );
            System.Console.WriteLine("Bränsle:" + c2.name + " " + c2.fuel + " %" );
            System.Console.WriteLine("Bränsle:" + c3.name + " " + c3.fuel + " %" );

           // List<car> Toyota = new List<car>();
           // List<car> Volvo = new List<car>();

           // theBall.x = 40;
            
            //theOtherBall.x = 60;

            //System.Console.WriteLine(theBall.x);

            Console.ReadLine();
        }
    }
}
