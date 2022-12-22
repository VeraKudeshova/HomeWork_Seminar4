// Напишите программу, которая задаёт массив из 8 случайных чисел (-10, 10) и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]        //6, 1, 33 -> [6, 1, 33]

int [] numbers = new int[8];
Console.Write("[");

int Method (int a)
{
    return numbers[a];
}

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(-11, 11);
    Console.Write(" " + Method (i) + " ");
 }
Console.WriteLine("]");

