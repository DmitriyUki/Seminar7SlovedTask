// Задача 50: Напишите программу, которая на вход принимате позиции элемента в двумерном массиве, 
//и возвращает значение каждого элемента или же указание что такого элемента нет.
//1 4 7 2 
//5 9 2 3 
//8 4 2 4

//17- такого числа в массиве нет


int ReadNumber(string messageToUser)
{
  Console.WriteLine(messageToUser);
  int value = Convert.ToInt32(Console.ReadLine());
  return value;
}

int[,] GetRandomMatrix(int rows, int columns, int leftBorder = 0, int rightBorder = 10)
{
  int[,] matrix = new int[rows, columns];

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1); // обращаемся к нашему элементу по i и j создаем 
                                                                      //рандомные значения, задав диапазон
    }
  }
  return matrix;
}

void MatrixSquare(int[,] matrix, int row, int column) // создаем метод который будет определять элемент  матрице
{
  if (row >= matrix.GetLength(0) - 1 || column >= matrix.GetLength(1) - 1) // проверка условия 
  {
    Console.WriteLine("Такого элемента в матрице нет");
  }
  else
  {
    Console.WriteLine($"значение элемента равно {matrix[row, column]}");
  }
}

void PrintMatrix(int[,] matrix) // метод PrintMatrix печатающий нашу матрицу на экран
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i, j] + " "); // выводим матрицу на экран
    }
    Console.WriteLine(); // после обработки сроки по вышеуказанному циклу и до перехода к следующей выводим обработанную строку
  }
}

int rowsCount = ReadNumber("Введите колличество строк:");
int columnsCount = ReadNumber("Введите колличество столбцов:");
int userRow = ReadNumber("Введите индекс строки нужного элемента");
int userColumn = ReadNumber("Введите индекс стобца нужного элемента");

int[,] myMatrix = GetRandomMatrix(rowsCount, columnsCount);

PrintMatrix(myMatrix); // вызываем метод по распечатке и распечатываем получившуюся матрицу
Console.WriteLine(); // делаем строчку чтоб выведенные матрицы не сливались

MatrixSquare(myMatrix, userRow, userColumn);