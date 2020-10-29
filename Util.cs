using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Util
    {
        /// <summary>
        /// Function to convert the given bytes to either Kilobyte, Megabyte, or Gigabyte
        /// </summary>
        /// <param name="bytes">Double -> Total bytes to be converted</param>
        /// <param name="type">String -> Type of conversion to perform</param>
        /// <returns>Int32 -> Converted bytes</returns>
        /// <remarks></remarks>
       
        public static double CalculateSquare(Int32 number)
        {
            return Math.Pow(number, 2);
        }


        /// <summary>
        /// Function to calculate the cube of the provided number
        /// </summary>
        /// <param name="number">Int32 -> Number to be cubed</param>
        /// <returns>Double -> THe provided number cubed</returns>
        /// <remarks></remarks>
        public static double CalculateCube(Int32 number)
        {
            return Math.Pow(number, 3);
        }

    }
}
