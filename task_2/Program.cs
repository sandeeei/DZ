// Назовем число интересным, если в нем разность максимальной и
//  минимальной цифры равняется средней арефметической числа. 
//  Напишите программу, которая определяет интересное число или нет. 
//  Если число интересное, следует вывести – «Число интересное» иначе 
//  «Число неинтересное».
// -> 954 - число интересное, средняя цифра - 5, разница: 9 - 4 = 5.
// Средняя цифра - цифра(962-6, 23456 - средняя 4)

Console.Write("Введите число более 2-х разрядов : ");
int N = Convert.ToInt32(Console.ReadLine());

// // проверка на разрядность числа
 while(N<100)
 {
     Console.WriteLine("Введено число менее 2-х разрядов. Введите число более 2-х разрядов : ");
     N = Convert.ToInt32(Console.ReadLine());
 }
 
  //Преобразование числа в строку
 string str = N.ToString();
 Console.WriteLine(str);

//Преобразование строки в массив
//char[] arr = str.ToCharArray();
int[] arr = str.Select(x => x - '0').ToArray();

// Нахождение  максимальной и минимальной цифры числа 
int min , max, i = 1, size=arr.Length, sum=0;

Array.Sort(arr);
min = arr[0];
max = arr[arr.Length - 1];

Console.WriteLine($"Максимальная цифра числа  {N} : {max},  минимальная цифра :  {min} " );
Console.WriteLine($"Разница максимальной и минимальной цифры этого числа :  {max-min}");

// Нахождение среднеарефметического значения массива
 i=0;
 while (i<size)
  {
     sum=sum+arr[i];
     i++;
  }
  int com = sum/size;

 Console.WriteLine($"Среднеарефметическое числа: {N} = {com}");
 if (max-min==com)
 {
    Console.WriteLine($"Число :  {N}  интересное");
 }
 else
 {
    Console.WriteLine($"Число :  {N}  НЕ интересное");
 }



