// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int size = 10;
int []array = new int [size];
for (int i = 0; i< array.Length; i ++)
{
    array [i]= new Random().Next (0, 10);
    Console.WriteLine (array [i] + " ");
}
Console.WriteLine();

int j = array.Length - 1;
for (int i = 0; i < (array.Length + 1) / 2; i++)

    Console.Write(array[i] * array[j] + " ");
    j--;

