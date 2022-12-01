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

//Часть 3 (Ex 9). Массивы.

/*
int Max(int arg1, int arg2, int arg3) //Это функция (МЕТОД), который исполняется для своих внутренних аргументов (арг1 и тд) и возвращает указанную переменную.
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

//Зададим массив
int [] massiv = {111,21,32,4,15,16,71,18,91};

int max = Max(
    Max(massiv[0], massiv[1], massiv[2]), 
    Max(massiv[3], massiv[4], massiv[5]), 
    Max(massiv[6], massiv[7], massiv[8]));

Console.WriteLine(max);
*/


//Часть 4 (Example 10). Поиск определенного элемента массива, кот равен значению find.


/*
int[] array = { 1, 32, 11, 5, 4, 11, 7, 8 };

int n = array.Length; //определили предел для счетчика

int find = 11;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine("Индекc первого элемента массива, который равен значению find это " + index + ", по счету это " + (index + 1) + " элемент");
        break;
    }
    index++;
}
*/



//Часть 5 (Example 11). Поиск определенного элемента массива, кот равен значению find,
//но используем ген сл чисел, массивы в методах.




void FillMassiv(int[] collection) //создаем новый метод с массивом внутри на месте аргумента.
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;


    }

}
// void это методы, которые НЕ возвращают значения. А другие возвращают, например выше, где искали максимум трех чисел, там метод начинался просто с типа переменной (int) и возвращал значение для дальн использования видимо.
void PrintMassiv(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection2, int find)
{
    int count = collection2.Length;
    int index = 0;
    int position = -1; // -1 ставим, для того, чтобы идентифицировать результат, когда ни одного значения равного find нет, иначе если оставить 0, то это индекс первого значения массива.

    while (index < count)
    {
        if (collection2[index] == find)
        {
            position = index;
            break; //добавляем, чтобы после нахождения первого элемента, который равен find дальше поиск не шел.
        }
        index++;
    }
    return position;
}

int[] massiv = new int[10]; // конструкция new int[10] значит (примерно дословно) "создать новый массив, в котором будет 10 элементов".

FillMassiv(massiv);
PrintMassiv(massiv);
Console.WriteLine();// вывод пустой строчки, чтобы в терминале не путаться с выводом массива (у нас же вон сначла выводится сгенерированный массив).

int pos = IndexOf(massiv, 4);
Console.WriteLine("Индекc первого элемента массива, который равен значению find это " + pos);

