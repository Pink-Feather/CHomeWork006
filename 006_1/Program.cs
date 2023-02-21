// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Какое количество чисел Вы хотите ввести? - ");
int size = int.Parse(Console.ReadLine()!);

int[] ReadMass()
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        Console.WriteLine("Введите число: ");
        result[i] = int.Parse(Console.ReadLine()!);
    }
    return result;
}

void PrintMass(int[] array) ///вернуть массив
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int PolNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count ++;
    }
    return count;
}

int[] array = ReadMass();
PrintMass(array);
PolNum(array);
Console.WriteLine($"Количество положительных чисел: {PolNum(array)}");
