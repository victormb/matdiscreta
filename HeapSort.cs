using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conjunto
{
    public class HeapSort
    {
        public static void Heapsort(ArrayList input)
        {
            //Build-Max-Heap
            int heapSize = input.Count;
            for (int p = (heapSize - 1) / 2; p >= 0; p--)
                MaxHeapify(input, heapSize, p);

            for (int i = input.Count - 1; i > 0; i--)
            {
                //Swap
                int temp = Convert.ToInt32(input[i]);
                input[i] = input[0];
                input[0] = temp;

                heapSize--;
                MaxHeapify(input, heapSize, 0);
            }
        }

        private static void MaxHeapify(ArrayList input, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if ((left < heapSize) && (Convert.ToInt32(input[left]) > Convert.ToInt32(input[index])))
                largest = left;
            else
                largest = index;

            if ((right < heapSize) && (Convert.ToInt32(input[right]) > Convert.ToInt32(input[largest])))
                largest = right;

            if (largest != index)
            {
                int temp = Convert.ToInt32(input[index]);
                input[index] = input[largest];
                input[largest] = temp;

                MaxHeapify(input, heapSize, largest);
            }

        }
    }
}
