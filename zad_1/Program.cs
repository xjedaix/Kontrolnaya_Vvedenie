// Задача: написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["Hello", "2", "Wold", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// [Russia, Denmark, Kazan] -> []

using System;
class Program
{
static void Main(string[] args)
    {
    Console.Clear();
    Console.WriteLine("Введите элементы массива через запятую: ");
    string input = Console.ReadLine();
    string[] array = input.Split(',');
    string[] newArray = new string[array.Length];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
    if (array[i].Length <= 3)
     {
        newArray[count] = array[i];
        count++;
     }
    }
    Console.WriteLine("Новый массив: ");

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(newArray[i]);
    }
        Console.ReadLine();
    }
}