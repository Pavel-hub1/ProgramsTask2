Console.Clear();
Console.WriteLine("кол-во строк  ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("кол-во столбцов  ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] col = new int[line, column];
FillArray(col);
PrintArray(col);
int firstsum = Int32.MaxValue;
int index = 0;


for (int i=0; i <col.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < col.GetLength(1); j++)
    {
        sum = sum + col[i, j];
    }
    if (sum < firstsum)
    {
        firstsum = sum;
        index++;
    }
}
Console.WriteLine("строка с наименьшей суммой " + (index));


void FillArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
        {
    for (int j = 0; j < col.GetLength(1); j++)
            {
 col[i, j] = new Random().Next(0, 10);
            }
        }
}

void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
        {
            Console.Write(" ");
    for (int j = 0; j < collection.GetLength(1); j++)
                Console.Write(collection[i, j] + "  ");
        Console.Write("");
        Console.WriteLine("");
        }
}

