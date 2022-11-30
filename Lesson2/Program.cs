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

//Часть 2. Используем метод (функцию)

int Max (int arg1, arg2, arg3) //Это функция (МЕТОД), который исполняется для своих внутренних аргументов (арг1 и тд) и возвращает указанную переменную.
{
int result = arg1;
if(arg2 > result) result = arg2;
if(arg3 > result) result = arg3;
return result;
}


