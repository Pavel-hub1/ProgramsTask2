int valeus(string a)
{
    Console.Write(a);
    int numbers = Convert.ToInt32(Console.ReadLine());
    return numbers;
}


int M = valeus("M: ");
int N = valeus("N: ");

int function = func(M,N);

int func(int M, int N)
{
    if (M==0)
        return N+1;
    else if (N==0)
        return func(M-1, 1);
        else return func(M-1, func(M,N-1));
}

Console.Write($"result:  {function}");

