using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL
{
    class Elevator
    {


        private double maxWeight;
        private int maxOccupants;
        private Passenger[] Occupants;
        public Elevator (double maxweight, int maxoccupants)
        {
            maxWeight = maxweight;
            maxOccupants = maxoccupants;
            Occupants = new Passenger[maxOccupants];
        }


        public void AddOccupant(int index, Passenger passenger)
        {
            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            double totalWeight = 0;

            foreach (Passenger passenger in Occupants)
            {
                totalWeight += passenger.getWeight();
            }

            return totalWeight;
            }

        public bool IsOverMaxCapacity()
        {
            if (GetCurrentWeight() <= maxWeight)
            {
                return false;
            }

            else
            {
                return true;
            }






            //2 private member variables MaxWeight (double) and Occupants which is an aray of passengers
            //1 public constructor: takes 2 parameters maxOccupants (int) maxweight double
            //----creates new memory for the occupants array to be the size of maxoccupants
            //--- assigns maxweight the value of maxweight
            //3 public methods: add occupant= takes 2 parameteres passenger which is a passenger and index (int)
            //---- assigns occupants at position index the value of passenger
            // no return value (void)
            //getcurrentweight which returns the sum of the weights of all occupants in this elevator
            //isovermaxcapacity which returns whether or not getcurrentweight is greater than maxweight




        }
}
