// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int [] array = new int [12];
int oddEvenNumber = 0;
int evenNumber = 0;

for (int i = 0; i< array.Length; i++)
{
array [i] = new Random().Next (100, 999);
Console.Write (array[i] +"");
}
Console.WriteLine();
for (int j = 0; j <array.Length; j++)
{
    if (array [j] % 2 == 0) evenNumber = evenNumber +1;
    else oddEvenNumber = oddEvenNumber +1;
}
Console.WriteLine ($"Количество четных чисел в массиве {evenNumber}");
Console.WriteLine ($"Количество нечетных чисел в массиве {oddEvenNumber}");