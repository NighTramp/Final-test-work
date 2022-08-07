/*
Задача:
Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длинна которых меньше либо 
равна 3 символа. Первоначальный массив можно ввести с 
клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
*/
namespace Task
{
    class Program
    {
        static void Main(string[] asgs)
        {
            string[] inputArray = { "123", "12", "1234", "1", "12", "123456", "123" };
            string[] sortedArray = QuickSort.QSort(inputArray, 0, inputArray.Length - 1);
            Console.WriteLine($"Sorted array: {string.Join(", ", sortedArray)}");
        }
    }
}