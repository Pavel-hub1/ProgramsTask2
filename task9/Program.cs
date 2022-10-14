Console.Clear();
Console.WriteLine("кол-во строк - ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("кол-во столбцов - ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] col = new double[line, column];


void FillArray(double[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
        {
    for (int j = 0; j < col.GetLength(1); j++)
            {
 col[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            }
        }
}
void PrintArray(double[,] collection)
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


FillArray(col);           
PrintArray(col);         
Console.WriteLine();