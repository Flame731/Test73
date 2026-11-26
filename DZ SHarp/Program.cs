using System;

Console.WriteLine("Выберите условие:");
Console.WriteLine("1 Добавить книгу:");
Console.WriteLine("2 Показать книгу:");
Console.WriteLine("3 Выйти:");

string text = Console.ReadLine();

switch (text)
{
    case "1":
    Console.WriteLine("Книга добавлена");
    break;

    case "2":
    Console.WriteLine("Вы выбрали книгу");
    break;

    case "3":
    Console.WriteLine("Вы вышли");
    return;

    default:
    Console.WriteLine("Выбирите 1, 2 или 3");
    break;
}

Console.WriteLine("Конец");