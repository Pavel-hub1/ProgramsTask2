Console.Clear();
Console.WriteLine("строка  ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("столбец  ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] col = new int[line, column];
FillArray(col); 

for (int i=0; i <col.GetLength(1); i++)
{
    double arifmsum = 0;
    for (int j = 0; j < col.GetLength(0); j++)
        arifmsum = (arifmsum + col[j, i]);
    arifmsum = arifmsum / line;
    Console.Write(arifmsum + " ");
}
Console.WriteLine();


void FillArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
        {
    for (int j = 0; j < col.GetLength(1); j++)
            {
 col[i, j] = new Random().Next(0, 20);
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