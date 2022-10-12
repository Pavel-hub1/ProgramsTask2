/*
// Вывести индекс определенного числа из массива
int[] array = {1,12,31,4,15,16,17,18};   //зададим массив
int n = array.Length;                    //зададим переменную n и присвоим ей значение равное длине массива
int find = 18;                           //зададим переменную find , то значение , которое нам надо будет найти (какой имеет индекс эта переменная)
int index=0;                             //начальное значение индекса по умолчанию будет считать 0
while(index<n)
{
    if(array[index]==find)               //пусть если значение массива с определенным индексом равно find (нашему значению)
    {
        Console.WriteLine(index);        //выведи мне тогда индекс этой переменной
    }
    index++;                             //если же нет, то прибавь один к индексу и по новой
}
*/



/*
//нахождение максимального элемента через ф-ции
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 15, b1 = 21, c1 = 39, a2= 41, b2 = 91, c2 = 85, a3 = 68, b3 = 47, c3 = 61;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);
*/


/*
//тоже самое только с использованием массивов (избавляетя от 1000+ переменных) (переменные вручную)
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//               0   1   2   3   4   5   6   7   8
int [] array = {11, 21, 31, 41, 51, 16, 17, 18, 85}; 
// array[0] = 12;   //присвоили нулевой переменной значение 12

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(result);
*/



