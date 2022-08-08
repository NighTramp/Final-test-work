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
        public UserInterface()
        {
            Console.Clear();
            row = Console.CursorTop;
            col = Console.CursorLeft;
        }
    }
}