﻿// Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввёд пользователь
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3

// Console.WriteLine("Введите числа");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
// int count = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if(arr[i]>0){
//         count++;
//     }
// }
// Console.WriteLine($"Количество положительных чисел {count}");

// Напишите программму, которая найдет точку пересечения двух прямых, заданных уравнениями у=k1*х+b1, y=k2*x+b2;
// значения b1, k1, b2 и k2 задаются пользователем
// b1=2, k1=5, b2=4, k2=9 -> (-0,5;-0,5)

// Console.WriteLine("Введите k1:");
// var k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите b1:");
// var b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите k2:");
// var k2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите b2:");
// var b2 = Convert.ToDouble(Console.ReadLine());

// var x = -(b1-b2)/(k1-k2);
// var y = k1*x+b1;
// x = Math.Round(x,3);
// y = Math.Round(y,3);

// Console.WriteLine($"Пересечение в точке: ({x};{y})");