public static class ListExtensions
{
    // Binary Search
    public static int? FindIndexInSorted<T>(this IList<T> list, T itemToFind) where T: IComparable<T>
    {
        int leftBound = 0;
        int rightBound = list.Count - 1;

        while (leftBound <= rightBound)
        {
            int midIndex = leftBound + (rightBound - leftBound) / 2;
            if (itemToFind.Equals(list[midIndex]))
            {
                return midIndex;
            }
            else if (itemToFind.CompareTo(list[midIndex]) < 0)
            {
                rightBound = midIndex - 1;
            }
            else
            {
                leftBound = midIndex + 1;
            }
        }
        
        return null;
    }
}