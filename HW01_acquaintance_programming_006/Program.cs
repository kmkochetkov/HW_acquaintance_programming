// программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число для проверки на чётность: ");
int number = int.Parse(Console.ReadLine());

if (number%2==0)
{
    Console.WriteLine($"введённое число {number} - чётное");
}
else
{
    Console.WriteLine($"введённое число {number} - нечётное");
}