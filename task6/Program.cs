Console.Clear();
int x = number("длина массива  ");
int[] random = new int[x];
for (int i=0; i<random.Length; i++)
{
    random[i] = new Random().Next(1,9);
    Console.Write(random[i] + "");
}

int number(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}