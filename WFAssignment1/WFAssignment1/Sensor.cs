using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAssignment1
{
    /// <summary>
    /// Sensor class for generating random sensor data.
    /// </summary>
    class Sensor
    {
        private double sensValue; //Sensor value
        private uint sensRaw; //Raw sensor value in 8 unsigned bits
        private int sensId; //Sensor Id
        private Random sensRng; //Random number generator

        /// <summary>
        /// Creates a sensor object with the id provided. Should be a unique id, the class does not check if the id is unique. 
        /// </summary>
        /// <param name="id">Sensor Id</param>
        public Sensor(int id)
        {
            sensRng = new Random(id);
            sensId = id;
        }

        /// <summary>
        /// Returns a random sensor value in volt between -1 and 1 with a resolution of 8 bits. 
        /// </summary>
        /// <returns>Double sensor value</returns>
        public double GetValue()
        {
            sensRaw = (uint)sensRng.Next(1 << 8);
            sensValue = (Convert.ToDouble(sensRaw) - 128) / 128;
            sensValue = Math.Round(sensValue, 5);
            return sensValue;
        }
    }
}
