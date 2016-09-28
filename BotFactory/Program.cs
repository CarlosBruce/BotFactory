using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory
{
    class Program
    {
        static void Main( string[ ] args )
        {
            Factories.UnitFactory u = new Factories.UnitFactory(4,10);

            //while( !u.AddWorkableUnitToQueue( typeof( R2D2 ), "R2D2 le 1 ", new Common.Tools.Coordinates() { X = 1, Y = 1 }, new Common.Tools.Coordinates() { X = 80, Y = 80 } ) )
            //    Console.WriteLine( "." );

            //while( !u.AddWorkableUnitToQueue( typeof( R2D2 ), "R2D2 le 2 ", new Common.Tools.Coordinates() { X = 1, Y = 1 }, new Common.Tools.Coordinates() { X = 8, Y = 8 } ))
            //    Console.WriteLine( ".." );

            //while( !u.AddWorkableUnitToQueue( typeof( R2D2 ), "R2D2 le 3  ", new Common.Tools.Coordinates() { X = 1, Y = 1 }, new Common.Tools.Coordinates() { X = 10, Y = 10 } ) )
            //    Console.WriteLine( "..." );

            //while( !u.AddWorkableUnitToQueue( typeof( R2D2 ), "R2D2 le 4  ", new Common.Tools.Coordinates() { X = 1, Y = 1 }, new Common.Tools.Coordinates() { X = 15, Y = 15 } ) )
            //    Console.WriteLine( "...." );

            //while( !u.AddWorkableUnitToQueue( typeof( R2D2 ), "R2D2 le 5  ", new Common.Tools.Coordinates() { X = 1, Y = 1 }, new Common.Tools.Coordinates() { X = 100, Y = 100 } ) )
            //    Console.WriteLine( "....." );

            //while( !u.AddWorkableUnitToQueue( typeof( R2D2 ), "R2D2 le 6  ", new Common.Tools.Coordinates() { X = 1, Y = 1 }, new Common.Tools.Coordinates() { X = 12, Y = 12 } ) )
            //    Console.WriteLine( "......" );


            Console.ReadLine();
        }
    }
}
