// Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите прогрумму, которая покажет количество чётных чисел в массиве.


int[] num = new int[10];
FillMainay(num);
PrintMainay(num);
int count = 0;

for (int a = 0; a < num.Length; a++)
if (num[a] % 2 == 0)
count++;

Console.WriteLine($"{count} чётных");

void FillMainay(int[] num)
{
    for(int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100,1000);
    }
}
void PrintMainay(int[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечетных позициях.

void FillArray(int[] array){
    for (int i = 0; i < array.Length; i++) 
    array[i] = new  Random().Next(0, 50);
}
void PrintArray(int[] array){
    for (int i=0; i< array.Length; i++)
    Console.WriteLine($"{array [i] }");
     Console.WriteLine();}

int Summ(int [] array){
    int sum = 0;
    int i = 1;
    while(i < array.Length){
        sum = sum+array[i];
        i=i+2;
    }
    return sum;
}
Console.WriteLine("Введите размерность массива");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] num = new int[n];

    FillArray(num);
    PrintArray(num);

Console.WriteLine($"{Summ(num)}");


// Задайте массив вещественных чисел. Найдите разницу между максимальных и минимальным элементом массива.
// [3,7,22,2,78] -> 76

void FillArray (double[] array){
    for(int i = 0; i < array.Length; i++)
    array[i] = Convert.ToDouble(new Random().Next(1,10))/Convert.ToDouble(new Random().Next(1,10));
}
void PrintArray(double[] array){
for (int i = 0; i < array.Length; i++) Console.WriteLine($"{array[i]} ");
Console.WriteLine();
}
double Min(double[] array)
{
    double min = array[0];
    int i = 1;
    while (i < array.Length){
        if (array[i] < min) 
        min = array[i];
        i++;
    }
    return min;
}

double Max(double[] array)
{
    double max = array[0];
    int i = 1;
    while (i < array.Length){
        if (array[i] > max) 
        max = array[i];
        i++;
    }
    return max;
}

Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt16(Console.ReadLine());
double[] numbers = new double[n];

FillArray(numbers);
PrintArray(numbers);
Console.WriteLine($"Максимальный {Max(numbers)}");
Console.WriteLine($"Максимальный {Min(numbers)}");
Console.WriteLine($"Разница {Max(numbers)-Min(numbers)}");
