Console.Clear();

int valeus(string a)
{
    Console.Write(a);
    int numbers = Convert.ToInt32(Console.ReadLine());
    return numbers;
}


int x = valeus("x: ");
int y = valeus("y: ");
int z = valeus("z: ");

int[,,] array = new int[x,y,z];
PrintArray(array);
FillArray(array);


void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
    for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"x({i}), y({j})");
                for (int k = 0; k < array.GetLength(2); k++)
                    Console.Write($", z({k}) = {array[i,j,k]} ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
}

void PrintArray(int[,,] array)
{
    int[] a = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int values;
    for (int i = 0; i<a.GetLength(0); i++)
    {
        a[i] = new Random().Next(10, 100);
        values = a[i];
        if (i >= 1)
        {
            for (int k = 0; k < i; k++)
            {
                while (a[i] == a[k])
                {
                    a[i] = new Random().Next(10, 100);
                    k=0;
                    values = a[i];
                }
                values = a[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y< array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x,y,z] = a[count];
                count++;
            }
        }
    }
}

