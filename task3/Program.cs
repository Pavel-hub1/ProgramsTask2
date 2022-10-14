Console.Clear();
void FillArray(double[] collection) 
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] =Convert.ToDouble(new Random().Next(100, 1000)) / 100;
        index++;
    }
}

void PrintArray(double[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

double[] array = new double[10];  //я взял эл-тов в масссиве = 10
FillArray(array);           
PrintArray(array);         
Console.WriteLine();

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int x = 0; x < array.Length; x++)
{
    if (array[x] > max)
        {
            max = array[x];
        }
    if (array[x] < min)
        {
            min = array[x];
        }
}

Console.WriteLine($"{max - min}");