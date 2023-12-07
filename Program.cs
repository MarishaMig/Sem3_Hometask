/*Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, 
значения которых лежат в отрезке [20,90].
массив [10 21 14 93 23] => 2 */

/*Console.Write("Введите размер массива: ");
int num=Convert.ToInt32(Console.ReadLine());
int[] array = new int [num];
Console.Write("массив [");
int count=0;
for (int i=0; i<array.Length; i++)
{
    array[i] = new Random().Next(1,101);  
    Console.Write(array[i] +" ");
    if (array[i]>19 && array[i]<=90)
    {
        count++;
    }
}
Console.Write("] => "+count);*/



/*Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество четных чисел в массиве.

массив [6 7 19 34 3 1 4 7 9 1] => 3 
массив [1 8 43 4 55 60 3 2 1 3] => 4*/

/*int[] array = new int [10];
Console.Write("массив [");
int count=0;
for (int i=0; i<10; i++)
{
    array[i] = new Random().Next(0,100);  
    Console.Write(array[i] +" ");
    if (array[i]%2==0)
    {
        count++;
    }
}
Console.Write("] => "+count);*/


/*Задайте массив из вещественных чисел с ненулевой дробной частью. 
Найдите разницу между максимальным и минимальным элементов массива.
массив [2.2 0.4 9.11 7.2 78.98] => 78.58 
массив [1.22 4.5 3.33] => 3.28 */

/*Console.Write("Введите размер массива: ");
int num=Convert.ToInt32(Console.ReadLine());
double [] array = new double [num];
Console.Write("массив [");
for (int i=0; i<array.Length; i++)
{
    array[i] = new Random().NextDouble()+ new Random().Next(0,20);  
    Console.Write(array[i] +" ");
}
double min=array[0]; double max=array[0];
for  (int i=1; i<array.Length; i++)
{   
    if (array[i]>max)
    {
        max=array[i];
    }
    if (array[i]<min)
    {
        min=array[i];
    }
}
Console.Write($"] => {max-min}");*/



/*Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
Размер массива должен быть равен количеству цифр.
425 => [4 2 5] 
8741 => [8 7 4 1] 
4 => [4] */


/*Console.Write("Введите натуральное число в диапазоне от 1 до 100 000: ");
int N=Convert.ToInt32(Console.ReadLine());
if (N>0 && N<=100000)
{
    Console.Write(N+" => [");
    if (N<10)
    {
        Console.Write($"{N}]");
    }
    else
    {
        int car=N; int size=0;
        while (car>0)
        {
            car/=10;
            size++;
        }
        int[] array = new int[size];
        int div=1;
        for (int index=1; index<size; index++)
        {
            div=div*10;
        }
        for (int i=0; i<array.Length; i++)
        {
            array[i]=N/div;
            Console.Write(array[i]+" ");
            N=N%div;
            div=div/10;
        }        
        Console.Write("]");
    }
}
else
{
   Console.WriteLine("введите другое число!");
}
*/

//2 способ решения 4 задачи:

Console.Write("Введите натуральное число в диапазоне от 1 до 100 000: ");
int N=Convert.ToInt32(Console.ReadLine());
if (N>0 && N<=100000)
{
    Console.Write(N+" => [");
    string s=Convert.ToString(N);
    char[] array =s.ToCharArray();
    if (array.Length>1)
    {
        int i=0;
        while (i < array.Length-1)
        {    
            Console.Write(array[i]+" ");
            i++;
        }
        Console.Write(array[array.Length-1]);
    }
    else
    {
   
        Console.Write(array[0]);
    }
    Console.Write("]");
    }
else
{
   Console.WriteLine("введите другое число!");
}

