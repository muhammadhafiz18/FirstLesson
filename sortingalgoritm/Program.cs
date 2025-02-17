public class Program
{
    public static void Main()
    {

    int[] arr = [5, 8, 9, 1, 10];

    int temp = 0;



    for(int i = 0; i < arr.Length; i++)
    {
        for(int p = 0 ; p < arr.Length; p++)
        {
            if(arr[i] < arr[p])
            {
                temp = arr[i];
                arr[i] = arr[p];
                arr[p] = temp;

            }
        }
    }

    for(int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i] + " ");
    }
    }
}