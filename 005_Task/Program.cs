// Напишите прогу, которая принимает на вход трёхзанчные числа и на выходе показывает последнюю цифру этого числа
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("ВВедите трехдначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int div = 0;

if(num >= 100 && num < 1000)
{
    div = num % 10;
    Console.WriteLine(div);
}
else 
{
    Console.WriteLine("ВВедите обязательно трехзначное число");
}
