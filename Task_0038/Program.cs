// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRnddouble(int size, int min, int max)
{
    var array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double rndnum = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(rndnum, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}. ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");

    
}


void NewArray(double[] array)
{
double min = Int32.MaxValue;
    double max = Int32.MinValue;

    for (int z = 0; z < array.Length; z++)
    {
        if (array[z] > max)
        {
            max = array[z];
        }
        if (array[z] < min)
        {
            min = array[z];
        }
    }
    double resault = max - min;
    double res = Math.Round(resault, 1);
    Console.WriteLine($" -> {res}");
}

double[] arr1 = CreateArrayRnddouble(5, 1, 100);
PrintArray(arr1);
NewArray(arr1);