// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

System.Console.Write("Введите строку для проверки на полиндром: ");
string? str = Console.ReadLine();
char[] char1 = new char[str!.Length];
for (int i = 0; i < str.Length; i++)
{
    char1[i] = str[str.Length -1 -i];
}
string str2 = new string(char1);
System.Console.Write(str);
if (str == str2)
System.Console.WriteLine(" => Да");
else
System.Console.WriteLine(" => Нет");

