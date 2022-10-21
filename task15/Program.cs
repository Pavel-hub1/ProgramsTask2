Console.Clear();

int valeus(string a)
{
    Console.Write(a);
    int numbers = Convert.ToInt32(Console.ReadLine());
    return numbers;
}


int n1 = valeus("кол-во строк в 1-ой матрице: ");
int k = valeus("кол-во столбцов в 1-ой матрице ( = кол-ву строк во второй): ");
int m2 = valeus("кол-во столбцов в 2-ой матрице: ");

int[,] MatrixA = new int[n1, k];
FillArray(MatrixA);
PrintArray(MatrixA);
Console.WriteLine("");

int[,] MatrixB = new int[k, m2];
FillArray(MatrixB);
PrintArray(MatrixB);
Console.WriteLine("");

int[,] MatrixC = new int[n1, m2];
MultMatrix(MatrixA, MatrixB, MatrixC);
PrintArray(MatrixC);


void MultMatrix(int[,] MatrixA, int[,] MatrixB, int[,] MatrixC)
{
    for (int i = 0; i<MatrixC.GetLength(0); i++)
    {
        for (int k = 0; k< MatrixC.GetLength(1); k++)
        {
            int result = 0;
            for (int j = 0; j<MatrixA.GetLength(1); j++)
                result = result + MatrixA[i,j] * MatrixB[j,k];
            MatrixC[i,k] = result;
        }
    }
}

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