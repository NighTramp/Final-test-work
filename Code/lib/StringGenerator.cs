namespace Task
{
    class StringGenerator
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ 0123456789";
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static string[] RandomStringArray()
        {
            int array_length = random.Next(0,11);
            string[] temp = new string[array_length];
            for (int i = 0; i < array_length; i++)
            {
                temp[i] = RandomString(random.Next(1,8));
            }
            return temp;
        }   
    }
}