int valeus(string a)
{
    Console.Write(a);
    int numbers = Convert.ToInt32(Console.ReadLine());
    return numbers;
}


int M = valeus("M: ");
int N = valeus("N: ");

void sum (int M, int N, int count)
{
    if (M>N)
    {
        Console.WriteLine($"{count}");
        return;
    }
    count = count + (M++);
    sum(M, N, count);

}

sum(M,N, 0);