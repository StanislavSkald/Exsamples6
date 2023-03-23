 // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write ($" Введите размер массива ");
int i = Convert.ToInt32 (Console.ReadLine ());
int[] newArray = newint();
Console.WriteLine(string.Join(" ", newArray));
Console.Write ($" Чисел больше 0 ввёл пользователь = {count ()}");

int[] newint()
{
     int[] array = new int[i];
     for (int j = 0; j < i; j++)
     {
        Console.WriteLine($"Введите число с индексом {j}");
        int number = Convert.ToInt32 (Console.ReadLine ());
        array[j] = number;
     }
     return array;
}

int count ()
{
    int cou = 0;
    int[] array = newArray;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > 0)
        {
            cou += 1;
        }
    }
    return cou;
}