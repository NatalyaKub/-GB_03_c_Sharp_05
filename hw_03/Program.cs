// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] ArraySet (int length){
    int index = 0;
    int[] array = new int[length];
    Console.WriteLine("Задаем массив");
    while (index < length){
        array[index] = new Random().Next(0,100);
        index++;
    }
    Console.WriteLine();
    return array;
}

void ArrayPrint(int[] col){
    int l = col.Length;
    int index = 0;
    Console.Write("[ ");
    while (index < l){
        Console.Write($"{col[index]}, ");
        index++;
    }
    //Console.Write($"|array[array.length-1]|");
    Console.Write("]");
    Console.WriteLine();

}

// Find max and min
int Max(int length, int[] array){
    int max = array[0];
    for (int index = 0; index < length; index++){
        if (array[index] > max){
            max = array[index];
        }
    }
    return max;
}

int Min(int length, int[] array){
    int min = array[0];
    for (int index = 0; index < length; index++){
        if (array[index] < min){
            min = array[index];
        }
    }
    return min;
}

// Разница
int DiffMaxMin(int maxArray, int minArray){
    int diff =  maxArray - minArray;
    return diff;
}

Console.WriteLine("Задайте размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = ArraySet(length);

ArrayPrint(array);
//QuantityEvenNumbers();

int maxArray = Max(length, array);
Console.WriteLine($"Максимальное число в массиве: {maxArray}");

int minArray = Min(length, array);
Console.WriteLine($"Минимальное число в массиве: {minArray}");

int diffMaxMin = DiffMaxMin(maxArray, minArray);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {diffMaxMin}");