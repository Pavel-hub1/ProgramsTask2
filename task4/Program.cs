Console.Clear();
int constA = number("");
int constB = number("");
stepen(constA, constB);
void stepen(int a, int b)
{
    int x= 1;
    for (int i = 1
    ; i<=b; i++)
    {
        x = x * a;
    }
    Console.WriteLine(x);
}


int number(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}