
// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные. 
// “aBcD1ef!-” => “abcd1ef!-”

System.Console.Write("Введите строку содержащую латинские буквы в обоих регистрах: ");
string? str = Console.ReadLine();
System.Console.Write(str + "  =>  ");
System.Console.WriteLine(str!.ToLower());
