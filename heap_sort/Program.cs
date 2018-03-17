/*
 * C# Program to Demonstrate Heap Sort
 */

using System;

namespace heap_sort
{
    class Heap
    {
        int[] r = { 2, 5, 1, 10, 6, 9, 3, 7, 4, 8 };
        public void hsort()
        {
            int i, t;
            for (i = 5; i >= 0; i--)
            {
                adjust(i, 9);
            }
            for (i = 8; i >= 0; i--)
            {
                t = r[i + 1];
                r[i + 1] = r[0];
                r[0] = t;
                adjust(0, i);
            }
        }
    }
}
