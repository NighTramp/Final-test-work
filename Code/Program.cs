﻿/*
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
            UserInterface app = new UserInterface();
            Console.SetCursorPosition(117,1);
            Console.ReadKey();
            Console.SetCursorPosition(0,30);
        }
    }
}
