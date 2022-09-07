//Программа запрашивает натуральное число M, пользователь вводит с клавиатуры
// M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int col=0;
Console.Write("Введите натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
for (int i=0; i<array.Length; i++)
{
    Console.Write($"Введите число с индексом {i}:  ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if(array[i]>0)
    {
        col ++;
    }
}
Console.WriteLine("Количество чисел > 0 = " + col);



