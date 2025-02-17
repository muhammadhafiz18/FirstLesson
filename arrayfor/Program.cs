using System;

class Program
{
    static void Main()
    {
        int[] arr = { 6, 5, 1, 7, 8, 3, 4 };

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {

                if (arr[j] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        for(int i = 0; i < arr.Length; i++)
        {
            Console.writeLine(arr[i]);
        }
    }
}
