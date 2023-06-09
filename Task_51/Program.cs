﻿//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1+9+2 = 12

int ReadNumber(string messageToUser) // используем метод перевода строки введенной пользователем в в число, в скобках пишутся используемые аргументы
{
  Console.WriteLine(messageToUser);
  int value = Convert.ToInt32(Console.ReadLine());
  return value;
}

int[,] GetRandomMatrix(int rows, int columns, int leftBorder = 0, int rightBorder = 10) // задаем параметры (опции) нашей матрицы, для этого в скобочках прописываем 
//новые переменные int 1 строки, 2 столбцы. Далее добавляем пораметры для создания рандомных чисел int leftBorder, int rightBorder, либо можно их задать по умолчанию, тогда в вызывающей матрице не надо будет их вставлять, и отдельно делать под них переменные
{
  int[,] matrix = new int[rows, columns]; // создаем двумерный массив, выделяем под него память, 
                                          //указываем после слов new int [колличество строк, колличество столбцов], передавая те переменные которые мы задали в опциях к матрице

  for (int i = 0; i < matrix.GetLength(0); i++) // цикл который все массивы(строки), под вторым условием можно написать и rows, Иван сказал что будет тоже работаnь
  // но он решил нас познакомить с методом, который будет получать от матрицы колличество строк GetLength(0)
  {
    for (int j = 0; j < matrix.GetLength(1); j++) // создаем внутренний(вложенный) цикл который будет перебирать элементы 
                                                  //внутри стоки(столбцы) GetLength(1) выдаст нам именно колличество столбцов, тут надо просто запомнить что 0 для строк, 1 для столюцов
    {
      matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1); // обращаемся к нашему элементу по i и j создаем рандомные значения, задав диапазон
    }
  }

  return matrix;

}

int SumOfPos(int [,] matrix)
{
  int sum = 0; //вводим счетчик (сумму индексов)
  //for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1)) данное условие означает что наш счетчик i будет идти до тех пор,
  //пока она не превысит одн из элементов
  //{
    //sum += matrix[i,i]; решаем задачу в один цикл, на главной диагонали индексы равны, поэтому мы используем  i два раза
  //} 

  for (int i = 0; i < matrix.GetLength(0); i++) // цикл который все массивы(строки), под вторым условием можно написать и rows, Иван сказал что будет тоже работаnь
  // но он решил нас познакомить с методом, который будет получать от матрицы колличество строк GetLength(0)
  {
    for (int j = 0; j < matrix.GetLength(1); j++) // создаем внутренний(вложенный) цикл который будет перебирать элементы 
                                                  //внутри стоки(столбцы) GetLength(1) выдаст нам именно колличество столбцов, тут надо просто запомнить что 0 для строк, 1 для столюцов
    {
      if(i==j) // условие задачи
      {
        sum += matrix[i,j]; // накопление суммы 
      }
    }
  }
  return sum;
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

int m = ReadNumber("Ввдеите колличество строк:");
int n = ReadNumber("Ввдеите колличество столбцов:");
int[,] myMatrix = GetRandomMatrix(m, n); // вызывающая матрица, суть в то что если указать сюда только значения для первых двух пераметров
// они и будут использваться, а 3 и 4 парамет использваться не будет, если я вставлю туда какие-нибудь другие цифры, то они будут 
//использоваться несмотря на то что уже цифры заданы в методе, при этом не обязательно их два сразу задавать, можно задать только один

//Console.WriteLine(string.Join(",", myMatrix)); // пытаемся вывести двухмерную матрицу в строку,но данный метод это делать не умеет

PrintMatrix(myMatrix); // печатаем получившуюся матрицу на экран
int sum = SumOfPos(myMatrix); // объявляем новую переменную int и вызываем метод по расчету суммы
Console.WriteLine($"Сумма элементов, находящихся на главной диагонали равна: {sum}"); // вывод на экран получившуюся сумму