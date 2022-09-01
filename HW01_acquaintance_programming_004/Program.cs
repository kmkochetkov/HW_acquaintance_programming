//Домашнее задание 1 (Знакомство с языками программирования)
// Задача 4
// программа, принимает на вход три числа и выдаёт
// максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int numberFirst = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberSecond = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число");
int numberThird = int.Parse(Console.ReadLine());

int numberMax = numberFirst;

if (numberSecond > numberMax)
{
    numberMax = numberSecond;
}

if (numberThird > numberMax)
{
    numberMax = numberThird;
}

Console.WriteLine($"Максимальное число: {numberMax}");

