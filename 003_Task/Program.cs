// Напишите прогу, которая будет выдавать название дня недели по заданному номеру
//3 -> Среда
//5 -> пятница


Console.WriteLine("Введите число, чтобы переименовать его в день недели");
int numberA = Convert.ToInt32(Console.ReadLine());
switch (numberA) {
    case 1:
        Console.WriteLine("Понедельник");
    break;
    case 2:
        Console.WriteLine("Вторник");
    break;
    case 3:
        Console.WriteLine("Среда");
    break;    
    case 4:
        Console.WriteLine("Четверг");
    break;
    case 5:
        Console.WriteLine("Пятница");
    break;
    case 6:
        Console.WriteLine("Суббота");
    break;
    case 7:
        Console.WriteLine("Воскресение");
    break;
    default:
        Console.WriteLine("Такого дня недели не существует!");
        break;
}
