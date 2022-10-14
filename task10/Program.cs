Console.Clear();
Console.WriteLine("строка  ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("столбец  ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] col = new int[8, 8];
FillArray(col); 

if (line > col.GetLength(0) || column > col.GetLength(1)) 
    Console.WriteLine("такого эл-та нет");
else
    Console.WriteLine($"{col[line-1,column-1]}");

void FillArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
        {
    for (int j = 0; j < col.GetLength(1); j++)
            {
 col[i, j] = new Random().Next(-100, 100) / 10;
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