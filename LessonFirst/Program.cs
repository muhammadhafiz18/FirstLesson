int[] Array1 = [3, 5, 1, 8, 2];
int b = 0;
for(int a = 0; a < Array1.Length; a++)
{
    for(int i = 0; i < Array1.Length; i++)
    {
        if(Array1[a] < Array1[i])
        {
            b = Array1[a];
            Array1[a] = Array1[i];
            Array1[i] = b;
        }
    }
}


    Console.Write(string.Join(" ", Array1));
