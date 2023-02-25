// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int QuantityEvenNumbers(int length, int[] array){
    int sum = 0;
    int index = 0;
    while (index < length){
        if (index % 2 != 0){
            sum = sum + array[index];
        }
        index++;
    }
    return sum;
}


Console.WriteLine("Задайте размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = ArraySet(length);

ArrayPrint(array);
//QuantityEvenNumbers();

int sumArray = QuantityEvenNumbers(length, array);
Console.WriteLine($"Сумма элементов на нечетных позициях: {sumArray}");
