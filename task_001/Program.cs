
// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива
// a b c => “abcdef”
// d e f
 
char[,] array = {{'a','b','c'},{'d','e','f'}};
char[] arr1 = new char[array.GetLength(1)];
char[] arr2 = new char[array.GetLength(1)];
for (int i  =0; i < array.GetLength(0); i++ )
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
    arr1[j] = array[0,j];
    arr2[j] = array[1,j];
    }
}
string str1 = new string(arr1);
string str2 = new string(arr2);

System.Console.WriteLine(string.Join("", str1, str2));


