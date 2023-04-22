// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


//Функция запроса и считывания данных введенных пользователем
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

int chetnoe (int[] array)
{
    int chek = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0)
        {
            chek++;
        }
    }
    return chek;
}

int length = ReadInt("Введите длинну массива = ");
int minRnd = ReadInt("Введите минимальное значение в массиве = ");
int maxRnd = ReadInt("Введите максимальное значение в массиве = ");
int[] array = CreateArray(length, minRnd, maxRnd);
PrintArray(array);

System.Console.WriteLine();

System.Console.WriteLine($"Количество четных чисел в массиве = {chetnoe(array)}");
