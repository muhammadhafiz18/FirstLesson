public class Program
{
    public static void Main()
    {
        int[] arr = {10, 2, 5, 1, 5};
        int temp = arr.Length;
        
        // Array.Sort(arr);

        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = 0; j < arr.Length; j++)
            {
                if(arr[i] < arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        for(int i = 0; i < 5; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}