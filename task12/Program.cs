Console.Clear();
Console.WriteLine("кол-во строк  ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("кол-во столбцов  ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] col = new int[line, column];
FillArray(col);
Console.WriteLine("исходный массив");
PrintArray(col);


for (int i=0; i <col.GetLength(0); i++)
{
    for (int j = 0; j < col.GetLength(1)-1; j++)
    {
        for (int k = 0; k < col.GetLength(1)-1; k++)
        {
            if (col[i, k] < col[i, k+1])
            {
                int a = 0;
                a = col[i, k];
                col[i, k] = col[i, k+1];
                col[i, k+1] = a;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Итоговый массив ");



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


PrintArray(col); 
Console.WriteLine();