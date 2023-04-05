// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Console.Write(" Rows ");

// int rows =  Convert.ToInt32(Console.ReadLine());
// Console.Write(" columns ");
// int columns =  Convert.ToInt32(Console.ReadLine());
// double[,] newMatrix = GetMatrix ( rows, columns, 0 , 4);
// double[,]GetMatrix  ( double n, double m, double min, double max )

// {
//     double[,] Matrix = new double[(int) m , (int ) n ];

//     for (int i = 0; i < Matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < Matrix.GetLength(1); j++)
//         {
//             Matrix[i, j] = Math.Round(new Random().NextDouble(), 2 );
//         }
//     }
//     return Matrix;
// }
// PrintMatrix(newMatrix);
// void PrintMatrix( double[,] inputMatrix)
// {

//         for (int i = 0; i < inputMatrix.GetLength(0); i++)
//         {
    
//             for (int j = 0; j < inputMatrix.GetLength(1); j++)
//             {
             
//               Console.Write(inputMatrix[i, j] + "\t" );
            
//             }
//             Console.WriteLine();
//         }

// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Console.Write( "rows; ");

// int rows = Convert.ToInt32( Console.ReadLine());

// Console.Write( " columns ");

// int columns = Convert.ToInt32( Console.ReadLine());

// Console.WriteLine(" rows Index "); 

// int rowsIndex = Convert.ToInt32( Console.ReadLine());

// Console.Write(" columns Index ");

// int  columnsIndex = Convert.ToInt32(Console.ReadLine());
// int[,] newMatrix = GetMatrix(rows, columns, 2 , 10);
// int[,] GetMatrix(int m , int n , int min, int max)
// {
//     int[,] Matrix = new int [m,  n ] ;

//     for (int i = 0; i < Matrix.GetLength(0) ; i++)
//     {
//       for (int j = 0; j <  Matrix.GetLength(1); j++)
//       {
        
//          Matrix[i, j] =new Random().Next(min , max + 1);

//       }  
//     }
//     return Matrix;
// }
//   PrintMatrix(newMatrix);
// void PrintMatrix(int[,] inputMatrix)  
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
    
//          for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
           
//              Console.Write(inputMatrix[i, j ] + "\t" );
//         }
//         Console.WriteLine();
//     }
// }
// SearchNumber(newMatrix );
// void SearchNumber(int[,] inputMatrix)  
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
    
//          for (int j = 0; j < inputMatrix.GetLength(1); j++)
//         {
//            if (rowsIndex == i && columnsIndex == j)
//            {
//                 Console.WriteLine($" {rowsIndex }, {columnsIndex} = {inputMatrix[i, j]}");
//            }
//             else
//             {
//                 Console.WriteLine($"{ rowsIndex }, {columnsIndex} =  NO NUMBERS" );
//             }
//         }
       
//     }
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// // // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



// // Двумерный массив = табличка = матрица (табличка, состоящая из m строк и n столбцов)
// // Одномерный массив = строчка
// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array2D = GetMatrix(rows, columns, 0, 10); // Создалась матрица
// // int[,] testMatrix = GetMatrix(2,2, -10,10);
// // int[,] secondTestMatrix = GetMatrix(3,3, -10,10);
// // m - строчки, n - столбцы
// // int[,] GetMatrix(int m, int n)
// // {
// //     int[,] matrix = new int[m, n]; // [rows, columns]
// //     for (int i = 0; i < matrix.GetLength(0); i++) //  matrix.GetLength(0) = m - строчки
// //     {
// //         // i, j , m , k
// //         for (int j = 0; j < matrix.GetLength(1); j++) //  matrix.GetLength(1) = n - столбцы
// //         {
// //             matrix[i, j] = i + j;
// //         }
// //     }
// //     return matrix;
// // }
// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n]; // [rows, columns]
//     for (int i = 0; i < matrix.GetLength(0); i++) //  matrix.GetLength(0) = m - строчки
//     {
//         // i, j , m , k
//         for (int j = 0; j < matrix.GetLength(1); j++) //  matrix.GetLength(1) = n - столбцы
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }
// Console.WriteLine("исходный массив:");
// PrintMatrix(array2D);  // inputMatrix = array2D
// // Console.WriteLine("Вывод матрицы  2 на 2 для теста: ");
// // PrintMatrix(testMatrix); // inputMatrix = testMatrix
// // Console.WriteLine("Вывод матрицы  3 на 3 для теста: ");
// // PrintMatrix(secondTestMatrix); // inputMatrix = secondTestMatrix
// // Печатаем двумерный массив на экран
// void PrintMatrix(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++) // строчки
//     {
//         for (int j = 0; j < inputMatrix.GetLength(1); j++) // столбцы
//         {
//             Console.Write(inputMatrix[i, j] + "\t"); // "\t" - отступ между элементами   
//         }
//         Console.WriteLine(); // Переход на новую строчку
//     }
// }

// //  Задайте двумерный массив. 
// //  Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// // Метод, который берет матрицу, заполненную целыми числами и возводит в квадрат элементы
// // с четными индексами

// Console.WriteLine("Исходный массив, где элементы возведены в квадрат (четные индексы)");
// PrintMatrix(ChangeMatrix(array2D)); // matrix = array2D
// int[,] ChangeMatrix(int[,] matrix) // Чтобы возвести в квадрат элементы матрицы, получим матрицу :)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++) // строчки
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
//         {
//             if (i % 2 == 0 && j % 2 == 0) // если номер строчки и номер столбца дают остаток 0 при 
//             // делении на 2, то это четные индексы
//             {
//                 matrix[i,j] *= matrix[i,j]; // matrix[i,j] = matrix[i,j] * matrix[i,j]
//             }
//         }
//     }
//     return matrix; // Матрица, в которой эл-ты возвезедны в квадрат
// }
