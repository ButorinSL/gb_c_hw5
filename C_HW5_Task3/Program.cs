// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Функция запроса и считывания данных введенных пользователем
int ReadInt(string msg)
{
    System.Console.Write($"{msg} > ");
    return int.Parse(Console.ReadLine());
}


//Функция создания массива с указанием длинны (количества элементов) и мин и макс возможных случайных значений
int[] CreateArray(int length, int minRnd, int maxRnd)
{
    int[] array = new int[length];    // объявляем массив с указанием длинны
    Random rnd = new Random();      //объявляем локальную переменную *rnd* равную случайному числу от minRnd до maxRnd (объявленных выше (в параметрах функции)
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minRnd, maxRnd + 1);
    }
    return array;
}


// Функция вывод на печать массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

//Функция поиска максимального числа в массиве
int MaxDigit(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i = i + 1)
    {
        if (array[i] > max)
        {
        max = array[i];
        }
       
    }
    return max;
}

//Функция поиска минимального числа в массиве
int MinDigit(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i = i + 1)
    {
        if (array[i] < min)
        {
        min = array[i];
        }
       
    }
    return min;
}


int length = ReadInt("Введите длинну массива = ");
int minRnd = ReadInt("Введите минимальное значение в массиве = ");
int maxRnd = ReadInt("Введите максимальное значение в массиве = ");
int[] array = CreateArray(length, minRnd, maxRnd);

int deltaMaxMin = MaxDigit(array) - MinDigit(array);

PrintArray(array);

System.Console.WriteLine();

System.Console.WriteLine($"Разность между максимальным и минимальным значениями в массиве = {deltaMaxMin}");

