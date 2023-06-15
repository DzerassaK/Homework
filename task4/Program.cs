// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22



Console.WriteLine("введите первое число:");
string? FirstStringNum = Console.ReadLine();
Console.WriteLine("введите второе число:");
string? SecondStringNum = Console.ReadLine();
Console.WriteLine("введите третье число:");
string? ThirdStringNum = Console.ReadLine();
int FirstIntNum = Convert.ToInt32(FirstStringNum);
int SecondIntNum = Convert.ToInt32(SecondStringNum);
int ThirdIntNum = Convert.ToInt32(ThirdStringNum);
int max = FirstIntNum;
if (max < SecondIntNum) max = SecondIntNum;
if (max < ThirdIntNum) max = ThirdIntNum;
{
    Console.WriteLine($"максимальное значение = {max}");
}