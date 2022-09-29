Console.Clear();
int x(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int a = x("");
for (int i = 1; i <= a; i++)
{
    Console.Write($"{i*i*i}  ");
}