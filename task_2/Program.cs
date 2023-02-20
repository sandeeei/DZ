// Назовем число интересным, если в нем разность максимальной и
//  минимальной цифры равняется средней по величине цифре. 
//  Напишите программу, которая определяет интересное число или нет. 
//  Если число интересное, следует вывести – «Число интересное» иначе 
//  «Число неинтересное».
// -> 954 - число интересное, средняя цифра - 5, разница: 9 - 4 = 5.
// Средняя цифра - цифра(962-6, 23456 - средняя 4)

Console.Write("Введите число более 2-х разрядов : ");

int N = Convert.ToInt32(Console.ReadLine());
// проверка на разрядность числа
while(N<100)
{
    Console.WriteLine("Введено число менее 2-х разрядов. Введите число более 2-х разрядов : ");
    N = Convert.ToInt32(Console.ReadLine());
}
//Преобразование числа в строку
string str = N.ToString();
//Преобразование строки в массив
char [] array = str.ToCharArray();
// Нахождение индекса максимального и минимального значения массива
int min =0, max = 0, i = 0,  imin = 0, imax = 0, size=array.Length;

while (i<size)
{
    if (array[i]<min)
    {
       min=array[i];
        imin=i;
    }
    i++;
}
i=0;
while (i<size)
{
    if (array[i]>max)
    {
        max=array[i];
        imax=i;
    }
    i++;
}
//Console.Write(imax+"  "+imin);

// int number;
// bool isNumber = int.TryParse(N, out number);

    
 
// else
// {
//     Console.WriteLine("Вами были введены символы введите число более 2-х разрядов : ");
//     var N  =  Console.ReadLine();
//     bool isNumber = int.TryParse(N, out number);
// }
