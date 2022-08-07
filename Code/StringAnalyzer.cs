namespace Task
{
    static class StringAnalyzer
    {
        public static string[] GetStringLowerParam(string[] array, int param)
        {
            string[] tempArray = new string[CalcLengthOutputArray(array, param)];
            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = array[i];
            }
            return tempArray;
        }
        private static int CalcLengthOutputArray(string[] array, int param)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > param) return i;
            }
            return 0;
        }
    }
}