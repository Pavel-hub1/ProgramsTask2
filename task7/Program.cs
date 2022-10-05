/*
int numberA = new Random().Next(1, 10);
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
*/



/*
// программа для проверки , является ли первое число кквадратом второго
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 == n2*n2)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
*/



/*
//проверить, является ли год високосным
Console.Write("Введите год: ");
int n = Convert.ToInt32(Console.ReadLine());
if ( n % 4 == 0 && n % 100 != 0 || n % 400 == 0 )
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
*/


/*
//задача с проверкой числа и зацикливанием на правильный результат от пользователя
Console.WriteLine("Введите число от 1-7: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n<1 || n>7)
{
    Console.Write("попробуй еще раз: ");
    n = Convert.ToInt32(Console.ReadLine());
}
*/



/*
//выдавать название дня недели по заданному номеру с помощью if else || switch case
Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
// if (n==1)
//     Console.WriteLine("понедельник");
// else if (n==2)
//     Console.WriteLine("вторник");
// else if (n==3)
//     Console.WriteLine("Среда");
// else if (n==4)
//     Console.WriteLine("Четверг");
// else if (n==5)
//     Console.WriteLine("пятница");
// else if (n==6)
//     Console.WriteLine("суббота");
// else if (n==7)
//     Console.WriteLine("воскресенье");
switch(n)
{
    case 1:
    Console.WriteLine("Понедельник");
    break;
    case 2:
    Console.WriteLine("Вторник");
    break;
    case 3:
    Console.WriteLine("Среда");
    break;
    case 4:
    Console.WriteLine("Четверг");
    break;
    case 5:
    Console.WriteLine("Пятница");
    break;
    case 6:
    Console.WriteLine("Суббота");
    break;
    case 7:
    Console.WriteLine("Воскресенье");
    break;
}
*/



/*
// Найдите минимальный делитель числа
int n = Convert.ToInt32(Console.ReadLine());
for (int i=2; i<=n; i++)
{
    if (n%i == 0)
    {
        Console.WriteLine(i);
        break;
    }
}
*/


/*
// метод флага. Задача та же
int n = Convert.ToInt32(Console.ReadLine());
bool flag = true;
int i = 2;
while (flag)
{
    if (n%1 == 0)
    {
        Console.WriteLine(i);
        flag = false;
    }
    i++;
}
*/



/*
//на вход принимает одно значение N, а на выходе показывает все целые числа от N до -N
Console.Write("введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = (-1)*N; i <=N; i++)
Console.Write(i + " ");
*/
