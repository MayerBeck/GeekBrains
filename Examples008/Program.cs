﻿int Max(int arg1, int arg2, int arg3)   // Функция называется Max и имеет на входе три аргумента
{
    int result = arg1;                  // В переменную result присваиваем арг1
    if(arg2 > result) result = arg2;    // Если арг2 больше result, то result теперь арг2
    if(arg3 > result) result = arg3;    // Если арг3 больше result, то result теперь арг3
    return result;                      // Вызвращаем result
}
// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;
// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;
// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;
int max1 = Max(a1, b1, c1);             // В переменную max1 присваиваем значение из фунции Max, которая вычислила максимальное число из трех арг. 
int max2 = Max(a2, b2, c2);             // В переменную max2 присваиваем значение из фунции Max, которая вычислила максимальное число из трех арг.
int max3 = Max(a3, b3, c3);             // В переменную max3 присваиваем значение из фунции Max, которая вычислила максимальное число из трех арг.
int max  = Max(max1, max2, max3);       // В переменную max присваиваем значение из max1, max2 и max3.

Console.WriteLine(max);