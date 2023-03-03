using System;

public class MyProgram
{
    private static Random random = new Random();
    
    public static void Main(string[] args)
    {
        int sum;
        double midle;
        int flag;
        int flagX;
        int option;
        int x;
        int ii;
        int index;
        int max;
        int max2;
        int maxIndex;
        int max2Index;
        int min;
        int min2;
        int minIndex;
        int min2Index;
        int bufer;
        int buferI;
        
        Console.WriteLine("Введите размер Массива >= 3:");
        x = (int) inputValue();
        int[] massiv = new int[x];
        
        Console.WriteLine("Указан размер Массива -= " + x + " =- ");
        if (x >= 3)
        {
            Console.WriteLine("Искать вторые по величени Max & Min ? Введите *0 -  Нет* или *1 - Да*:");
            flagX = (int) inputValue();
            if (flagX == 0 || flagX == 1)
            {
                flag = 1;
                if (flagX == 1)
                {
                    Console.WriteLine("Указан -= " + flagX + " =- будет осуществлён поиск вторых по величение Max & Min!");
                    Console.WriteLine("***");
                }
                else
                {
                    Console.WriteLine("Указан -= " + flagX + " =- поиск вторых по величение Max & Min производиться не будет!");
                    Console.WriteLine("***");
                }
                Console.WriteLine("Введите *0 - для Рандомных значений* или *1 - для Ручного ввода значений* Массива:");
                option = (int) inputValue();
                Console.WriteLine("***");
                if (option == 0 || option == 1)
                {
                    for (index = 0; index <= massiv.Length - 1; index++)
                    {
                        if (option == 0)
                        {
                            massiv[index] = random.Next(101) - 50;
                        }
                        else
                        {
                            Console.WriteLine("Введите значение массива №: " + index + " =");
                            massiv[index] = (int) inputValue();
                        }
                    }
                    for (index = 0; index <= massiv.Length - 1; index++)
                    {
                        Console.WriteLine("1-Массив № " + index + "(" + massiv[index] + ")");
                    }
                }
                else
                {
                    Console.WriteLine("ОШИБКА !!! - Указано не коректное значение -= " + option + " =- выбор ввода значений Массива!!!");
                }
            }
            else
            {
                flag = 0;
                Console.WriteLine("ОШИБКА !!! - Указано не коректное значение -= " + flagX + " =- поиск второго Max & Min!!!");
            }
        }
        else
        {
            Console.WriteLine("ОШИБКА !!! - Указано не коректное значение -= " + x + " < 3 =- размер Массива!!!");
        }
        sum = 0;
        max = 0;
        maxIndex = 0;
        max2 = 0;
        max2Index = 0;
        min = 0;
        minIndex = 0;
        min2 = 0;
        min2Index = 0;
        bufer = 0;
        do
        {
            if (flag == 1)
            {
                
                // Обработка данных первого массива
                for (index = 0; index <= massiv.Length - 1; index++)
                {
                    if (massiv[index] == 0)
                    {
                    }
                    else
                    {
                        if (massiv[index] > 0)
                        {
                            
                            // Значения со знаком "+"
                            for (ii = 0; ii <= massiv.Length - 1; ii++)
                            {
                                
                                // Поиск +Max
                                if (massiv[ii] > max)
                                {
                                    bufer = massiv[ii];
                                    max = massiv[ii];
                                    maxIndex = ii;
                                    buferI = ii;
                                }
                            }
                            for (ii = 0; ii <= massiv.Length - 1; ii++)
                            {
                                
                                // Поиск +Min
                                if (massiv[ii] <= bufer)
                                {
                                    bufer = massiv[ii];
                                    min = massiv[ii];
                                    minIndex = ii;
                                    buferI = ii;
                                }
                                else
                                {
                                    if (ii == massiv.Length - 1)
                                    {
                                        min = bufer;
                                        minIndex = buferI;
                                    }
                                }
                            }
                        }
                        else
                        {
                            
                            // Значения со знаком "-"
                            for (ii = 0; ii <= massiv.Length - 1; ii++)
                            {
                                
                                // Поиск -Min
                                if (massiv[ii] < min)
                                {
                                    bufer = massiv[ii];
                                    min = massiv[ii];
                                    minIndex = ii;
                                    buferI = ii;
                                }
                            }
                            for (ii = 0; ii <= massiv.Length - 1; ii++)
                            {
                                
                                // Поиск -Max
                                if (massiv[ii] >= bufer)
                                {
                                    bufer = massiv[ii];
                                    max = massiv[ii];
                                    maxIndex = ii;
                                    buferI = ii;
                                }
                                else
                                {
                                    if (ii == massiv.Length - 1)
                                    {
                                        max = bufer;
                                        maxIndex = buferI;
                                    }
                                }
                            }
                        }
                    }
                }
                
                // Отчёт по обработке данных первого массива
                Console.WriteLine("ИТОГО 1-Массив: Макс = № " + maxIndex + "(" + max + ") ; Мин = № " + minIndex + "(" + min + ").");
                for (index = 0; index <= massiv.Length - 1; index++)
                {
                    sum = sum + massiv[index];
                }
                Console.WriteLine("ИТОГО 1-Массив: Сумма = " + sum);
                midle = (double) sum / massiv.Length;
                Console.WriteLine("ИТОГО 1-Массив: Средняя = " + midle);
                Console.WriteLine("***");
                flag = flag + flagX;
            }
            else
            {
                
                // Передача данных из первого во второй массив
                int[] massiv2 = new int[massiv.Length - 2];
                
                ii = 0;
                for (index = 0; index <= massiv.Length - 1; index++)
                {
                    if (index == maxIndex || index == minIndex)
                    {
                    }
                    else
                    {
                        massiv2[ii] = massiv[index];
                        Console.WriteLine("2-Массив № " + ii + "(" + massiv2[ii] + ")");
                        ii = ii + 1;
                    }
                }
                
                // Обработка данных второго массива
                for (index = 0; index <= massiv2.Length - 1; index++)
                {
                    if (massiv2[index] == 0)
                    {
                    }
                    else
                    {
                        if (massiv2[index] > 0)
                        {
                            
                            // Значения со знаком "+"
                            for (ii = 0; ii <= massiv2.Length - 1; ii++)
                            {
                                
                                // Поиск +Max2
                                if (massiv2[ii] > max2)
                                {
                                    bufer = massiv2[ii];
                                    max2 = massiv2[ii];
                                    max2Index = ii;
                                    buferI = ii;
                                }
                            }
                            for (ii = 0; ii <= massiv2.Length - 1; ii++)
                            {
                                
                                // Поиск +Min2
                                if (massiv2[ii] <= bufer)
                                {
                                    bufer = massiv2[ii];
                                    min2 = massiv2[ii];
                                    min2Index = ii;
                                    buferI = ii;
                                }
                                else
                                {
                                    if (ii == massiv2.Length - 1)
                                    {
                                        min2 = bufer;
                                        min2Index = buferI;
                                    }
                                }
                            }
                        }
                        else
                        {
                            
                            // Значения со знаком "-"
                            for (ii = 0; ii <= massiv2.Length - 1; ii++)
                            {
                                
                                // Поиск -Min2
                                if (massiv2[ii] < min2)
                                {
                                    bufer = massiv2[ii];
                                    min2 = massiv2[ii];
                                    min2Index = ii;
                                    buferI = ii;
                                }
                            }
                            for (ii = 0; ii <= massiv2.Length - 1; ii++)
                            {
                                
                                // Поиск -Max2
                                if (massiv2[ii] >= bufer)
                                {
                                    bufer = massiv2[ii];
                                    max2 = massiv2[ii];
                                    max2Index = ii;
                                    buferI = ii;
                                }
                                else
                                {
                                    if (ii == massiv2.Length - 1)
                                    {
                                        max2 = bufer;
                                        max2Index = buferI;
                                    }
                                }
                            }
                        }
                    }
                }
                
                // Отчёт по обработке данных второго массива
                Console.WriteLine("ИТОГО 2-Массив: Макс = № " + max2Index + "(" + max2 + ") ; Мин = № " + min2Index + "(" + min2 + ").");
                sum = 0;
                for (index = 0; index <= massiv2.Length - 1; index++)
                {
                    sum = sum + massiv2[index];
                }
                Console.WriteLine("ИТОГО 2-Массив: Сумма = " + sum);
                midle = (double) sum / massiv2.Length;
                Console.WriteLine("ИТОГО 2-Массив: Средняя = " + midle);
                Console.WriteLine("***");
                flag = flag + flagX;
            }
        }
        while (flag == 2);
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
