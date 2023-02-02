/*Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/

int InputInt(string message)
{
    System.Console.WriteLine(message + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] InputNumbers(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        System.Console.WriteLine($"Введите {i + 1}ое число. После ввода числа нажмите клавишу Enter.");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int M = InputInt("Укажите количество чисел");
System.Console.WriteLine($"Количество введённых чисел больше 0 = {PositiveNumbers(InputNumbers(M))}");