using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL
{
    class Passenger
    {


        private string Name;
        private double Weight;

        public Passenger (string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string getName()
        {
            return Name;
        }

        public double getWeight()
        {
            return Weight;
        }



        //One public constructor: Takes 2 parameters name and weight
        //--- assigns name the value of name, assigns weight the value of weight
        //two public methods getname which returns name and getweight which returns weight



    }
}
