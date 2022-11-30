//Часть 1. Начало. Используем "стихийный" подход.
/*
int a1 = 132;
int b1 = 1;
int c1 = 102;
int a2 = 129;
int b2 = 612;
int c2 = 1234;
int a3 = 122;
int b3 = 152;
int c3 = 2;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);
*/

//Часть 2 (Example 8). Используем метод (функцию)
/*
int Max(int arg1, int arg2, int arg3) //Это функция (МЕТОД), который исполняется для своих внутренних аргументов (арг1 и тд) и возвращает указанную переменную.
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//теперь нам нужно использовать этот метод
int a1 = 132;
int b1 = 1;
int c1 = -11111;
int a2 = 29;
int b2 = 32;
int c2 = 1412;
int a3 = 12;
int b3 = 15;
int c3 = 26546;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);

//int max = Max(max1, max2, max3);
//А можно в строчке выше, вместо аргументов метода Max написать тоже методы Max:

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);
*/

//Часть 3 (Ex 9). Массивы

int Max(int arg1, int arg2, int arg3) //Это функция (МЕТОД), который исполняется для своих внутренних аргументов (арг1 и тд) и возвращает указанную переменную.
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//теперь нам нужно использовать этот метод
int a1 = 132;
int b1 = 1;
int c1 = -11111;
int a2 = 29;
int b2 = 32;
int c2 = 1412;
int a3 = 12;
int b3 = 15;
int c3 = 26546;

//А можно в строчке выше, вместо аргументов метода Max написать тоже методы Max:

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);