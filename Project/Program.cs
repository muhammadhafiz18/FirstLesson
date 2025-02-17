int[] array = [3,5,1,8,2];
int temp = 0;

for(int i = 0; i < array.Length; i++)
{
    for(int a = 0; a < array.Length; a++)
    {
        if(array[i] < array[a])
        {
            temp = array[i];
            array[i] = array[a];
            array[a] = temp;
        }
    }
}

Console.WriteLine(string.Join(" ", array));
