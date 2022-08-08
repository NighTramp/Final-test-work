namespace Task
{
    class UserInterface
    {
        private int row;
        private int col;

        public void WriteAt(string str, int x, int y)
        {
        try
            {
                Console.SetCursorPosition(col+x, row+y);
                Console.Write(str);
            }
        catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
        private void ResetOutput()
        {
            for (int i = 13; i < 27; i++)
            {
                WriteAt(new string(' ', 112), 4, i);
            }
        }
        private void Initializer()
        {
            System.Threading.Thread.Sleep(300);
            WriteAt("> Для начала работы введите команду start или start random", 4, 13);
            System.Threading.Thread.Sleep(300);
            WriteAt("> Для выхода из приложения введите exit", 4, 14);
            System.Threading.Thread.Sleep(300);
            WriteAt(">                                                 ", 4, 15);
            Console.SetCursorPosition(6,15);
            string str = Console.ReadLine();
            System.Threading.Thread.Sleep(300);
            switch (str)
            {
                case "start":
                    StaticMethod();
                    ResetOutput();
                    Initializer();
                    break;
                case "start random":
                    RandomMethod();
                    ResetOutput();
                    Initializer();
                    break;
                case "exit":
                    WriteAt("> Пока", 4, 16);
                    break;
                default:
                    WriteAt("> Неизвестная команда "+str, 4, 16);
                    System.Threading.Thread.Sleep(2000);
                    ResetOutput();
                    Initializer();
                    break;
            }
        }
        public UserInterface()
        {
            Console.Clear();
            row = Console.CursorTop;
            col = Console.CursorLeft;
            DrawMainWindow();
            Console.SetCursorPosition(0,0);
            Initializer();
        }
        private void DrawMainWindow()
        {
            WriteAt("+" + new string('-', 118) + "+", 0, 0);
            for (int i = 1; i < 29; i++)
            {
                WriteAt("|", 0, i);
                WriteAt("|", 119, i);
            }
            WriteAt("+" + new string('-', 118) + "+", 0, 29);
            WriteAt("+" + new string('-', 118) + "+", 0, 2);

            WriteAt("Контрольная работа. Реснянский Георгий.", 2, 1);
            
            WriteAt("+" + new string('-', 114) + "+", 2, 3);
            for (int i = 4; i < 9; i++)
            {
                WriteAt("|", 2, i);
                WriteAt("|", 117, i);
            }
            WriteAt("+" + new string('-', 114) + "+", 2, 5);
            WriteAt("+" + new string('-', 114) + "+", 2, 9);

            WriteAt("Задача:", 4, 4);
            WriteAt("Написать программу, которая из имеющегося"+
                    " массива строк формирует массив из строк,"+
                    " длинна которых меньше либо", 4, 6);
            WriteAt("равна 3 символа. Первоначальный массив"+
                    " можно ввести с клавиатуры, либо задать"+
                    " на старте выполнения алгоритма.", 4, 7);
            WriteAt("При решении не рекомендуется пользоваться"+
                    " коллекциями, лучше обойтись исключительно"+
                    " массивами.", 4, 8);

            WriteAt("+" + new string('-', 114) + "+", 2, 10);
            for (int i = 11; i < 28; i++)
            {
                WriteAt("|", 2, i);
                WriteAt("|", 117, i);
            }
            WriteAt("+" + new string('-', 114) + "+", 2, 12);
            WriteAt("+" + new string('-', 114) + "+", 2, 28);

            WriteAt("Решение:", 4, 11);

            
        }   
        private void StaticMethod()
        {
            string[] inputArray = { "123", "12", "1234", "1", "12", "123456", "123" };
            WriteAt($"> Входной массив: [ \"{string.Join("\", \"", inputArray)}\" ]", 4, 16);
            inputArray = QuickSort.QSort(inputArray, 0, inputArray.Length - 1);
            string[] outputArray = StringAnalyzer.GetStringLowerParam(inputArray, 3);
            WriteAt($"> Выходной массив: [ \"{string.Join("\", \"", outputArray)}\" ]", 4, 17);
            WriteAt("> Для продолжения нажмите любую кнопку...", 4, 18);
            Console.ReadKey();
        }
        private void RandomMethod()
        {
            string[] randomArray = StringGenerator.RandomStringArray();
            WriteAt($"> Входной массив: [ \"{string.Join("\", \"", randomArray)}\" ]", 4, 16);
            randomArray = QuickSort.QSort(randomArray, 0, randomArray.Length - 1);
            string[] outputArray = StringAnalyzer.GetStringLowerParam(randomArray, 3);
            WriteAt($"> Выходной массив: [ \"{string.Join("\", \"", outputArray)}\" ]", 4, 17);
            WriteAt("> Для продолжения нажмите любую кнопку...", 4, 18);
            Console.ReadKey();
        }
        
    }
}