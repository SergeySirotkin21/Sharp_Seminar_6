
// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.
// “Hello my world” => “world my Hello”


string str = "Hello my World"; 
string[] strs1 = str.Split(' ');
Array.Reverse(strs1);
System.Console.WriteLine(string.Join(" ", strs1));