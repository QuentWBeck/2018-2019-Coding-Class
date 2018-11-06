using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watergun
{
    class Watergun2
    {

        float capacity = 1;
        Random rand = new Random();
        public bool Shoot(float amount)
        {

            if (capacity > 0)
            {
                capacity -= amount;
                float percentChance = (amount * .2f) + 2f;
                if (rand.NextDouble() < percentChance)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        public void Refill()
        {
            capacity += .25f;
            if (capacity >= 1)
                capacity = 1;
            Console.WriteLine("You now have " + capacity + " left in your tank");
        }
    }
}
