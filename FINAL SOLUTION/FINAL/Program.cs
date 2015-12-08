using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL
{
    class Program
    {
        static void Main(string[] args)
        {

            bool elevator1IsOverMaxCapacity;

            Elevator elevator1 = new Elevator(2, 400);
            Passenger A1 = new Passenger("A1", 180);
            elevator1.AddOccupant(0, A1);
            Passenger A2 = new Passenger("A2", 220);
            elevator1.AddOccupant(2, A2);

            bool elevator2IsOverMaxCapacity;
            Elevator elevator2 = new Elevator(3, 600);
            A1 = new Passenger("A1", 200);
            elevator2.AddOccupant(0, A1);
            A2 = new Passenger("A2", 200);
            elevator2.AddOccupant(1, A2);
            Passenger A3 = new Passenger("A3", 201);
            elevator2.AddOccupant(2, A3);



            elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();
            elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();




        }
    }
}
