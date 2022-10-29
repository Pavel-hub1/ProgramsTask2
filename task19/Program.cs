Console.Clear();

int n = 4;
int[,] x = new int[n, n];
int a = 1, i = 0, j = 0;

while (a <= x.GetLength(0) * x.GetLength(1))
{
  x[i, j] = a;
  a++;
  if (i <= j + 1 && i + j < x.GetLength(1) - 1)
  {
      j++;
  }
  else 
  {
    if (i < j && i + j >= x.GetLength(0) - 1)
    {
      i++;
    }
  else 
  {
    if (i >= j && i + j > x.GetLength(1) - 1)
    {
      j--;
    }
    else
    {
      i--;
    }
  }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      {
        Console.Write($" {array[i,j]} ");
      }
      else 
      {
        Console.Write($"{array[i,j]} ");
      }
    }
    Console.WriteLine();
  }
}

WriteArray(x);