//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] GetCubeTable(int N)
{
    int[] cub = new int[N + 1];
    for (int i = 1; i < cub.Length; i++)
    {
        cub[i] = i * i * i;
    }
    return cub;
}

void PrintCubs(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($"{i} в степени 3 = ");
        Console.WriteLine(array[i]);
    }
}

int[] TableCube = GetCubeTable(N);
PrintCubs(TableCube);