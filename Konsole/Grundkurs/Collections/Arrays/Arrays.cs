using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsole.Grundkurs.Collections.Arrays
{
    public class Arrays
    {
        // Declare a single-dimensional array of 5 integers.
        int[] array1 = new int[5];

        // Declare and set array element values.
        int[] array2 = new int[] { 1, 3, 5, 7, 9 };

        // Alternative syntax.
        int[] array3 = { 1, 2, 3, 4, 5, 6 };

        // Declare a two dimensional array.
        int[,] multiDimensionalArray1 = new int[2, 3];

        // Declare and set array element values.
        int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

        public Arrays()
        {
            array1 = new int[5];
            array2 = new int[] {};
            array3 = new int[5];
            multiDimensionalArray1 = new int[2, 3];
            multiDimensionalArray2 = new int[2, 3];
        }
    }
}
