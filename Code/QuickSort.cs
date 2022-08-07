namespace Task
{
    static class QuickSort
    {
        public static string[] QSort(string[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);
            QSort(array, minIndex, pivotIndex - 1);
            QSort(array, pivotIndex + 1, maxIndex);
            return array;
        }
        private static int GetPivotIndex(string[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;
            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (array[i].Length < array[maxIndex].Length)
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }
            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }
        private static void Swap(ref string leftItem, ref string rightItem)
        {
            string temp = leftItem;
            leftItem = rightItem;
            rightItem = temp;
        }
    }
}