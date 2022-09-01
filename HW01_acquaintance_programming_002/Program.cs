//Домашнее задание 1 (Знакомство с языками программирования)
// Задача 2
// программу, которая на вход принимает два числа и
// выдаёт, какое число большее, а какое меньше


Console.WriteLine("Введите число а");
int number_a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b");
int number_b = int.Parse(Console.ReadLine());

Console.WriteLine($"Число {number_b} больше числа {number_b}");

if (number_a == number_b)
{
    Console.WriteLine("Введённые числа равны");
}

if (number_a > number_b)
{
    Console.WriteLine($"Число а={number_a} больше числа b={number_b} ");
}
else
{
    Console.WriteLine($"Число b= {number_b} больше числа a= {number_a} ");
}