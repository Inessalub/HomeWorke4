﻿// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int [] array =  new int [12];
int sum = 0;

for (int i = 0; i < array.Length; i ++ )
{
    array [i] = new Random().Next(0, 10);
    Console.Write (array[i] +" ");
}
for (int j = 0; j < array.Length; j ++ )

   if (j % 2 == 1) sum = sum + array[j];
   
   Console.WriteLine();
   Console.WriteLine($" Сумма чисел  стоящих на нечетной позиции равна: {sum}");