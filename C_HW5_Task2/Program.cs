// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumNeChet(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int length = ReadInt("Введите длинну массива = ");
int minRnd = ReadInt("Введите минимальное значение в массиве = ");
int maxRnd = ReadInt("Введите максимальное значение в массиве = ");
int[] array = CreateArray(length, minRnd, maxRnd);
PrintArray(array);

System.Console.WriteLine();

System.Console.WriteLine($"Сумма чисел на нечетных позициях в массиве = {SumNeChet(array)}");