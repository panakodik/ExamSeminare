// Даны два числа. Показать большее и меньшее числа.
Console.WriteLine("Введите последовательно два числа. Программа определит большее и меньшее из этих чисел ");
Console.WriteLine("Введите значение первого числа ");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение второго числа ");
double numberB = Convert.ToDouble(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine($"Первое число *{numberA}* больше второго *{numberB}*");
}
else
{
    Console.WriteLine($"Второе число *{numberB}* больше первого *{numberA}*");
}