/*
Задача 38: 
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
double[] GetArray (int size, int minValue, int maxValue)
{
    double[] resultArray = new double [size];
    for (int i = 0; i < size; i++) // i < size = i < resultArray.Length
    {
        resultArray[i] = Convert.ToDouble(new Random ().Next(minValue, maxValue + 1))/100;
    }
    return resultArray;
}

Console.Write("Введите количество элементов массива: ");
int sizeElement = Convert.ToInt32(Console.ReadLine());
double[] array = GetArray (sizeElement, 0, 999);
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");

double indexMax = array[0];
double indexMin = array[1]; 
for (int i = 0; i < array.Length; i ++) // i < size = i < array.Length
{
    if (indexMax >= array[i])
    {
            if (indexMin > array[i])
        {
            indexMin = array[i]; 
        } 
    }
    else
    {
        indexMax = array[i];
    }
}    
Console.WriteLine($"Максимальный элемент массива : {indexMax}");
Console.WriteLine($"Минимальный элемент массива : {indexMin}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {indexMax} - {indexMin} = {indexMax - indexMin}");