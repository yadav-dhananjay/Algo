using System;
using System.Collections.Generic;
using System.Text;

namespace Algo
{
   public class Sorting
    {
        public void mergeSort(int[] arr)
        {
           int bigAlength = arr.Length;
            if (bigAlength < 2) return;


            int mid = bigAlength / 2;

            int[] lArr = new int[mid];

            int[] Rarr = new int[bigAlength - mid];

            for (int i = 0; i < mid; i++)
            {
                lArr[i] = arr[i];

                Console.WriteLine(String.Format("arr1={0}", lArr[i]));
            }
            for (int j = mid,k=0; j < bigAlength; j++,k++)
            {
                Rarr[k] = arr[j];
                Console.WriteLine(String.Format("arr1={0}", Rarr[k]));
            }

            mergeSort(lArr);
            mergeSort(Rarr);

        int[] a=    MergeArr(arr, lArr, Rarr);
            Console.WriteLine(String.Format("arr1={0}", string.Join(",",a)));
        }

      private int[] MergeArr(int[] arr, int[] larr,int[] rarr)
        {
            int l = 0;
            int r = 0;

            int m = 0;

            while(l<larr.Length && r < rarr.Length)
            {
                if (larr[l] <= rarr[r])
                {
                    arr[m] = larr[l];
                    l++;
                   
                }
               else 
                {
                    arr[m] = rarr[r];
                    r++;
                 //   m++;
                }
                m++;
            }

            while (l < larr.Length)
            {
                arr[m] = larr[l];
                l++;m++;
            }
            while (r < rarr.Length)
            {
                arr[m] = rarr[r];
                r++; m++;
            }

            return arr;
        }
    }
}
