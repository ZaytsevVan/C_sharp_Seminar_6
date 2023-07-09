// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] FillArray(string text)
{
    int[] array = Array.ConvertAll(text!.Split(), int.Parse);
    return array;
}

int NumbersGreaterThanZero (int[] array)
{
    int sumNumbers = 0;
    for(int i = 0; i < array.Length; i++)
    {   
        if(array[i] > 0)
        {
            sumNumbers += 1;
        }
    }
    return sumNumbers;
}

string EnterTheNumbers()
{
    Console.WriteLine("Введите различные положительные и отрицательные числа через пробел: ");
    string text = Console.ReadLine();
    return text;
}

string text = EnterTheNumbers();
int[] array = FillArray(text);
int sum = NumbersGreaterThanZero(array);
Console.WriteLine(sum);