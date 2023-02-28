// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int[,,] GenerateMatrix()
{
    Random rand = new Random();
    int[,,] matrix = new int[2, 2, 2];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rand.Next(10, 100);
            }
        }
    }
    return matrix;
}

void Znachenie(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.WriteLine();
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write($"{matrix[i, j, k]} = ({i},{j},{k}) ");
            }
        }
    }
}

var myMatrix = GenerateMatrix();
Znachenie(myMatrix);