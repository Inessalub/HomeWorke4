// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int []array = new int [123];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next (0, 1000);
    Console.Write (array[i] + " ");
}
Console.WriteLine();
for (int j = 0; j < array.Length; j++)
{
  if ( array[j] > 10 && array[j] < 99) count = count + 1;
}
Console.Write($"Массив содержит следующее количество элементов из отрезка [10,99] : {count} ");