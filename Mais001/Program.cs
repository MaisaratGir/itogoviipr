// // Задача : Написать программу, которая из имеющегося массива строк формирует
// массив из сток ,длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями,
//  лучше обойтись исключительно массивами


string[] massiv1 = new string[5] { "234", "34", "hello", "world", "res" };
string[] massiv2 = new string[massiv1.Length];

void SecondArrayWithIF(string[] massiv1, string[] massiv2)
{
    int count = 0;
    for (int i = 0; i < massiv1.Length; i++)
    {
        if (massiv1[i].Length <= 3)
        {
            massiv2[count] = massiv1[i];
            count++;
        }
    }
}
void PrintArray(string[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"{massiv[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(massiv1, massiv2);
PrintArray(massiv2);

