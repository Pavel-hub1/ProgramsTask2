Console.Clear();
void FillArray(int[] collection) 
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];  //я взял эл-тов в масссиве = 10
FillArray(array);           
PrintArray(array);         
Console.WriteLine();

int sum = 0;
for (int z = 0; z < array.Length; z+=2)
    {
        sum = sum + array[z];
    }
    
Console.WriteLine(sum);