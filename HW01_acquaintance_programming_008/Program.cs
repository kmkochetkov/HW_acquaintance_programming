//Программа, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число N:");
int number = int.Parse(Console.ReadLine());

Console.Write($"Чётные числа в диапазоне [1 - {number}] : ");

for (int numberT=2; numberT<=number; numberT+=2)
{    
  Console.Write($" {numberT}");
}
Console.WriteLine();