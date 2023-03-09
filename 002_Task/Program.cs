// a = 25, b = 5 -> да
// a  = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9-> нет

Console.WriteLine("Введите число 'a'");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 'b'");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA == numberB * numberB)
{
    Console.WriteLine("This is true");  
}
else
{
    Console.WriteLine("This is folce");
}

// если  в решении всего одно условие можно не использовать фигурные скобки
// if(numberA == numberB * numberB)
// Console.WriteLine("This is true");  
// else
// Console.WriteLine("This is folce");
