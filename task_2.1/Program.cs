// Назовем число интересным, если в нем разность максимальной и
//  минимальной цифры равняется среднему по расположению числу. 
//  Напишите программу, которая определяет интересное число или нет. 
//  Если число интересное, следует вывести – «Число интересное» иначе 
//  «Число неинтересное».
// -> 954 - число интересное, средняя цифра - 5, разница: 9 - 4 = 5.
// Средняя цифра - цифра(962-6, 23456 - средняя 4)

Console.Write("Введите число с не четной разрядностью, но более одного : ");
int N = Convert.ToInt32(Console.ReadLine());

//Проверка на разрядность числа
if(N<10)
{
    Console.WriteLine("Вы ввели число не соответствующее условиям, введите число с не четной разрядностью, но более одного :  ");
}
//var str = (Console.ReadLine());
// int number;
// bool isNumber = int.TryParse(str, out number);
// while(number==0)
// {
//     Console.WriteLine("Вы ввели символы, введите число с не четной разрядностью, но более одного :  ");
//     str = (Console.ReadLine());
//     isNumber = int.TryParse(str, out number);
// }
string str = N.ToString();
int[] arr = str.Select(x => x - '0').ToArray();
int min=arr[0] , max=arr[0], i = 1, size=arr.Length;
while(size%2==0)
{
    Console.WriteLine("Вы ввели число не соответствующее условиям, введите число с не четной разрядностью, но более одного :  ");
    str = (Console.ReadLine());
    size=str.Length;
}

//Нахождение минимальной и максимальной цифры числа
Array.Sort(arr);
min = arr[0];
max = arr[arr.Length - 1];
Console.WriteLine($"Максимальная цифра числа  {N} : {max},  минимальная цифра :  {min} " );
Console.WriteLine($"Разница максимальной и минимальной цифры этого числа :  {max-min}");

i=0;
int j=i+size/2;
int cen = arr[j];
Console.WriteLine(cen);
