// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] ArraySet (int length){
    int index = 0;
    int[] array = new int[length];
    Console.WriteLine("Задаем массив");
    while (index < length){
        array[index] = new Random().Next(100,1000);
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
    Console.Write(" ]");
    Console.WriteLine();

}

int QuantityEvenNumbers(int length, int[] array){
    int counts = 0;
    int index = 0;
    while (index < length){
        if (array[index] % 2 == 0){
            counts = counts + 1;
        }
        index++;        
    }
    return counts;
}


Console.WriteLine("Задайте размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = ArraySet(length);

ArrayPrint(array);
//QuantityEvenNumbers();

int countArray = QuantityEvenNumbers(length, array);
Console.WriteLine($"Количество элементов: {countArray}");