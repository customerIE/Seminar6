// Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Если кол-во элементов нечетное, то элемент посередине не учитывать.
// Результат сложения вывести на экран.
int sum = 0;
Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Random rnd = new Random();
for(int i=0; i < N; i++)
{
    array[i]=rnd.Next(1,10);
    Console.Write(" " + array[i]);
}
for(int i=0; i < N; i++)
{
    if (i < (N-1-i))
    {
        int temp = array[i] * array[N-1-i];
        sum = sum + temp;
    }   
}
Console.WriteLine("\nСумма произведений пар чисел = " + sum);



