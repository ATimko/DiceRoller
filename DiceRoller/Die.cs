using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Die
    {
        /// <summary>
        /// Creates the Die with an initial
        /// random value 1 - 6
        /// </summary>
        private static Random rand;

        static Die()
        {
            rand = new Random();
        }

        public Die()
        {
            Roll();
        }
        //Functionality Roll
        //Data: Result/Face Value

        /// <summary>
        /// Get/Set the face value of the die
        /// </summary>

        public byte Value { get; private set; }

        /// <summary>
        /// Rolls the die, and sets the value
        /// </summary>

        public void Roll()
        {
            //Random rand = new Random();
            int result = rand.Next(1, 7);
            this.Value = (byte)result;
        }
    }
}
