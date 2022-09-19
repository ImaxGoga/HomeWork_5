// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void foo()
{
    double[] massExpl = new double[5] {3, 7, 22, 2, 78};
    double[] massRand = new double[5];
    for (int i = 0; i < 5; i++)
    {
        massRand[i] = new Random().Next(0, 99);
    }
    int len = massExpl.Length;
    Console.WriteLine("Проверочный массив: ");
    printResult(massExpl, len);
    Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + Max(massExpl, len));

    len = massRand.Length;
    Console.WriteLine("Случайный массив: ");
    printResult(massRand, len);
    Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + Max(massRand, len));
}

void printResult(double[] array2, int len)
{
    Console.Write("[");
    for(int i = 0; i<len; i++)
    {
        if(i != len -1)
        {
            Console.Write(array2[i] + ", ");
        }
        else {
            Console.WriteLine(array2[i] + "]");
        }
    }
}

double Max(double[] mass, int len)
{
    double Max = mass[0];
    double Min = mass[0];
    for(int i = 0; i < len; i++)
    {
        if(Max < mass[i])
        {
            Max = mass[i];
        }
        if(mass[i] < Min)
        {
            Min = mass[i];
        }
    }
    double Result = Max - Min;
    return Result;
}

foo();