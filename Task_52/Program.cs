// Задача 52: 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadNumber(string messageToUser) // метод преобразования строки заданной пользователем в число
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[, ] GetRandomMatrix(int rows, int columns, int leftBorder = 0, int rightBorder = 10) // метод по созданию матрицы

{
    int [, ] matrix = new int[rows, columns]; // выделяем память под массив

  for(int i = 0; i < matrix.GetLength(0); i++) // цикл по созданию строк
  
  {
      for(int j = 0; j < matrix.GetLength(1); j++) // цикл по созданию столбцов 
      {
        matrix [i, j] = Random.Shared.Next(leftBorder, rightBorder + 1); // создаем рандомную матрицу
      }
  }
  return matrix;

}

void PrintMatrix (int[,] matrix) // метод PrintMatrix печатающий нашу матрицу на экран
{
  for(int i = 0; i < matrix.GetLength(0); i++) 
  {
      for(int j = 0; j < matrix.GetLength(1); j++)
      {
        Console.Write(matrix [i, j] + " "); // выводим матрицу на экран
      }
      Console.WriteLine(); // после обработки сроки по вышеуказанному циклу и до перехода к следующей выводим обработанную строку
  }
}

int m = ReadNumber("Введите колличество строк:");
int n = ReadNumber("Введите колличество столбцов:");
int [,] myMatrix = GetRandomMatrix(m, n); // создаем матрицу методом описанным выше
PrintMatrix(myMatrix); // распечатали матрицу при помощи метода

double average = 0;

for (n = 0; n < myMatrix.GetLength(1); n++)
{
    average = 0;
    for (m = 0; m < myMatrix.GetLength(0); m++)
    {
        average += myMatrix[m, n];
        
    }
    average = average / myMatrix.GetLength(0);
    Console.WriteLine($"Среднее значение для всех чисел столбца {average:f2}");
}
