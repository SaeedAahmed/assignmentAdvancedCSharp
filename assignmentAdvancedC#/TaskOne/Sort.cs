using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentAdvancedC_.TaskOne
{
    internal class Sort
    {
        public static void BubbleSort(int[] arr)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for(int j = 0; j < arr.Length-i-1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                    Console.WriteLine($"\nPass : {i + 1}");
                    foreach(int Num in arr)
                    {
                        Console.Write(Num + " ");
                    }
                }
            }
        }
    }
}
