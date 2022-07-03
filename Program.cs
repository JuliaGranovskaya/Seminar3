// Поиск четверти по координатам
// void coordinate()
// {
//     int[] Input()
//     {
//         int[] Array = new int[2];
//         Console.WriteLine("Введите координату X: ");
//         int x = Convert.ToInt32(Console.ReadLine());
//         Array[0] = x;
//         Console.WriteLine("Введите координату Y: ");
//         int y = Convert.ToInt32(Console.ReadLine());
//         Array[1] = y;
//         return Array;
//     }
//     int[] mini = Input();
//     while (mini[0] == 0 || mini[1] == 0)
//     {
//         Console.WriteLine("Точка находится на оси");
//         mini = Input();
//     }

//     if (mini[0] > 0 && mini[1] > 0)
//     {
//         Console.WriteLine("Точка находится в первой четверти");
//     }

//     if (mini[0] > 0 && mini[1] < 0)
//     {
//         Console.WriteLine("Точка находится в четвертой четверти");
//     }

//     if (mini[0] < 0 && mini[1] > 0)
//     {
//         Console.WriteLine("Точка находится во второй четверти");
//     }

//     else if (mini[0] < 0 && mini[1] < 0)
//     {
//         Console.WriteLine("Точка находится в третьей четверти");
//     }
    
//     }
// coordinate();

// Вывод возможных координат по номеру четверти
// void quarter()
// {
//     Console.Write("Введите номер четверти: ");
//     int q = Convert.ToInt32(Console.ReadLine());

//     if (q > 4 || q < 1)
//     {
//         Console.WriteLine("Некорректное значение");
//     }
//     if (q == 1)
//     {
//         Console.WriteLine("X > 0, Y > 0");
//     }
//     if (q == 2)
//     {
//         Console.WriteLine("X < 0, Y > 0");
//     }
//     if (q == 3)
//     {
//         Console.WriteLine("X < 0, Y < 0");
//     }
//     if (q == 4)
//     {
//         Console.WriteLine("X > 0, Y < 0");
//     }
// }
// quarter();

// Найти расстояние между двумя точками
// void distance()
// {
//     Console.Write("Введите X координату первой точки: ");
//     int Ax = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите Y координату первой точки: ");
//     int Ay = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите X координату второй точки: ");
//     int Bx = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите Y координату второй точки: ");
//     int By = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(Math.Sqrt((Ax - Bx)*(Ax - Bx) + (Ay - By)*(Ay - By)));
// }
// distance();

// Вывод таблицы квадратов чисел от 1 до N
// void squares()
// {
// Console.Write("Number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write(""+ N +" -> ");
// if (N > 0)
// {
//     for (int count = 1; count <= N; count ++)
//         Console.Write(count * count + " ");
// }
// else
// {
//     for (int count = 0; count >= N; count --)
//         Console.Write(count * count + " ");
// }
// }
// squares();

// Домашнее задание
// Принять на вход пятизначное число и проверить являетсяли оно палиндромом
// void palindrome()
// {
//     Console.WriteLine("Введите пятизначное число: ");
//     int number1 = Convert.ToInt32(Console.ReadLine());
//     if (number1 > 9999 && number1 < 100000)
//         {
//             int number2 = number1 % 10 * 10000 + (number1 % 100 - number1 % 10) * 100 + (number1 % 1000 - number1 % 100) + (number1 % 10000 - number1 % 1000) / 100 + (number1 % 100000 - number1 % 10000) / 10000;
//             if (number1 == number2)
//                 {
//                     Console.WriteLine(number1 + "-> да");
//                 } 
//             else
//                 {
//                     Console.WriteLine(number1 + "-> нет");
//                 }    
//         }
//     else
//         {
//             Console.WriteLine("Введено некорректное значение");
//         }
// }
// palindrome();

// Принять на вход координаты двух точек и найти расстояние между ними в 3D пространстве
// void lenght()
// {
//     Console.Write("Введите X координату первой точки: ");
//     int Ax = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите Y координату первой точки: ");
//     int Ay = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите Z координату первой точки: ");
//     int Az = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите X координату второй точки: ");
//     int Bx = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите Y координату второй точки: ");
//     int By = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите Z координату второй точки: ");
//     int Bz = Convert.ToInt32(Console.ReadLine());

//     double distance = Math.Round(Math.Sqrt(Math.Pow((Ax - Bx), 2) + Math.Pow((Ay - By), 2) + Math.Pow((Az - Bz), 2)), 2);
//     Console.WriteLine("A"+ (Ax, Ay, Az) +"; B"+ (Bx, By, Bz) +" -> "+ distance);
// }
// lenght();

// Принять на вход число N и выдать таблицу кубов чисел от 1 до N
// void cube()
// {
// Console.Write("Number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write(""+ N +" -> ");
// if (N > 0)
// {
//     for (int count = 1; count <= N; count ++)
//         Console.Write(Math.Pow(count, 3) + " ");
// }
// else
// {
//     for (int count = 0; count >= N; count --)
//         Console.Write(Math.Pow(count, 3) + " ");
// }
// }
// cube();