// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void foo()
{
    double[] mass1 = new double[4] {3, 7, 23, 12};
    double[] mass2 = new double[4] {-4, -6, 89, 6};
    double[] massRand = new double[4];
    for(int i=0; i<4 ; i++)
    {
        massRand[i]=randomNumber();
    }

    Console.WriteLine("Массив из примера 1:");
    printResult(mass1);
    SummElem(mass1);
    Console.WriteLine("Массив из примера 2:");
    printResult(mass2);
    SummElem(mass2);
    Console.WriteLine("Массив из случайных чисел:");
    printResult(massRand);
    SummElem(massRand);
}

double randomNumber()
{
    double n = new Random().Next(-99, 99);
    return n;
}

void printResult(double[] array2)
{
    Console.Write("[");
    for(int i = 0; i<4; i++)
    {
        if(i != 3)
        {
            Console.Write(array2[i] + ", ");
        }
        else {
            Console.WriteLine(array2[i] + "]");
        }
    }
}

void SummElem(double[] mass)
{
    double Summ=0;
    for(int i = 0; i<4 ; i++)
    {
        if(i % 2 != 0)
        {
            Summ = Summ + mass[i];
        }
    }
    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + Summ);
}

foo();