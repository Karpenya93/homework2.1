Console.Write("Введите размер массива ");
int countmassive = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[countmassive];
Random rand = new Random();
int[] numer= new int[] {} ;
int maxvalue = 0;
int minvalue = 0;
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(-100, 100);
    Console.WriteLine(numbers[i]);
}
int s = 0;
for (int i = 0; i < numbers.Length; i++)
{
    s += numbers[i];
}
for (int i = 0; i < numbers.Length; i++)
{
    if (maxvalue < numbers[i])
    {
        maxvalue = numbers[i];
    }
    if (minvalue > numbers[i])
    {
        minvalue = numbers[i];
    }
 
}

Console.WriteLine($"Сумма всех чисел в массиве {s}");
float b = s / (float)countmassive;
Console.WriteLine($"Средне значение всех чисел в массиве {b}");
Console.WriteLine($"Наибольшее значение в массиве {maxvalue}");
Console.WriteLine($"Наименьшее значение в массиве {minvalue}");
