/*

dotnet new console  -   Создать новый проект
dotnet run  -   Запустить проект

Console.Write и Console.WriteLine   -   Вывода информации в консоль




*/

Console.WriteLine("Введите имя пользователя");
string username1 = Console.ReadLine();
Console.WriteLine("Введите фамилию пользователя");
string username2 = Console.ReadLine();
Console.WriteLine("Введите отчество пользователя");
string username3 = Console.ReadLine();
Console.WriteLine($"Приветствую тебя, {username2} {username1} {username3}");