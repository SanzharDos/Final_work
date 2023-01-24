// Задача:
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам.

void Array(int size, string temp)
{
    string[] array = new string[size];
    string count = string.Empty;
    Console.Write("{ ");
    for (int i = 0; i < size; i++)
    {
        int random = new Random().Next(1, 9);
        for (int j = 0; j < random; j++)
        {
            int pos = new Random().Next(0, temp.Length - 1);
            array[i] = array[i] + temp[pos];
        }
        if (array[i].Length < 4)
        {
            count = array[i] + " " + count;
        }
        if (i < size - 1) Console.Write($"{array[i]} ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine(" }");
    Console.WriteLine("Сформирован массив из строк, длина которых меньше либо равна 3 символам:");
    Console.Write("{ ");
    Console.Write($"{count}");
    Console.Write("}");
}

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
string temp = "0123456789abcdefghijklmopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ`~!@#$%^&*()_+|=?';:/-№";
string[] array = new string[size];
Console.WriteLine("Сгенерирован массив из случайных символов: ");
Array(size, temp);