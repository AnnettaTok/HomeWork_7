/*
 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

int[,] InitMatrix()
{
    int[,] array = new int[4, 4];

    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }

    return array;
}



void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }

    return result;
}






void GetFind(int[,] matrix, int number)
{

    for (int i = 1; i < matrix.GetLength(0); i++)
    {

        for (int j = 1; j < matrix.GetLength(1); j++)
        {

            if (matrix[i, j] == number)
            {
                Console.Write($"Такое число есть ");

            }

        }


    }
    Console.WriteLine($"Такого числа нет ");
}

int[,] matrix = InitMatrix();
int number = GetNumber("Введите число ");

PrintMatrix(matrix);

GetFind(matrix, number);


