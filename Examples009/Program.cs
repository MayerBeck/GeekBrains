int Max(int arg1, int arg2, int arg3)   // Функция называется Max и имеет на входе три аргумента
{
    int result = arg1;                  // В переменную result присваиваем арг1
    if(arg2 > result) result = arg2;    // Если арг2 больше result, то result теперь арг2
    if(arg3 > result) result = arg3;    // Если арг3 больше result, то result теперь арг3
    return result;                      // Вызвращаем result обратоно
}

int [] array = {11, 21, 31, 41, 15, 61, 17, 18, 19,};

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(result);