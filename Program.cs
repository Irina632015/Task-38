// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.WriteLine("Размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] num = new double[size];
FillArrayRandomNumbers(num);
Console.WriteLine("массив: ");
PrintArray(num);
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int х = 0; х < num.Length; х++)
{
    if (num[х] > max)
        {
            max = num[х];
        }
    if (num[х] < min)
        {
            min = num[х];
        }
}
Console.WriteLine($"всего {num.Length} чисел. Макс. значение = {max}, мин. значение = {min}");
Console.WriteLine($"Разница между макс. и мин. значением = {max - min}");

void FillArrayRandomNumbers(double[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = Convert.ToDouble(new Random().Next(10,100)) / 10;
        }
}

void PrintArray(double[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}