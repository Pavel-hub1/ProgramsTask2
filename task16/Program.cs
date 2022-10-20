Console.Clear();
Console.WriteLine("введите числа: ");
int[] array = numbers(Console.ReadLine());
PrintArray(array);
int sum = 0;
for (int i = 0; i< array.Length; i++)
{
    if (array[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine(sum);

int[] numbers(string a)
{
    int count = 1;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] == ',')
        {
            count++;
        }
    }

    int[] col = new int [count];
    int index = 0;

    for (int i = 0; i < a.Length; i++)
    {
        string temp = "";

        while (a[i] != ',')
        {
        if(i != a.Length - 1)
        {
            temp += a[i].ToString();
            i++;
        }
        else
        {
            temp += a[i].ToString();
            break;
        }
        }
        col[index] = Convert.ToInt32(temp);
        index++;
    }
    return col;
}



void PrintArray(int[] collection)
{
    Console.Write("");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("");
}