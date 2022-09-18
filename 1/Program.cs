// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int randomNumber()
{
    int number = new Random().Next(100, 999);
    return number;
}

bool checkNumber(int num)
{
    if (num % 2 == 0)
    {
        return true;
    }
    return false;
}

void printResult(int[] array2)
{
    int col = 0;
    Console.Write("Ваш массив: [");
    for(int i = 0; i<4; i++)
    {
        if(checkNumber(array2[i]))
        {
            col++;
        }
        if(i != 3)
        {
            Console.Write(array2[i] + ", ");
        }
        else {
            Console.WriteLine(array2[i] + "]");
        }
    }
    Console.WriteLine("Количество чётных чисел в массиве: " + col);
}

void foo()
{
    int[] array1 = new int[4];
    int[] array2 = new int[4];
    for(int i = 0; i < 4; i++)
    {
        Console.Write("Введите положительное трёхзначное число: ");
        array1[i] = int.Parse(Console.ReadLine());
        array2[i] = randomNumber();
    }
    Console.WriteLine("Введенный Вами массив: ");
    printResult(array1);
    Console.WriteLine("Рандомный массив: ");
    printResult(array2);

}

foo();