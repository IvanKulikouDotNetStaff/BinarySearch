public class Search
{
    public static void Main()
    {

    }

    public int BinarySearch(int[] numArray, int item)
    {
        if(numArray is null)
        {
            throw new ArgumentNullException(nameof(numArray));
        }

        int low = 0;
        int high = numArray.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int guess = numArray[mid];

            if (guess == item)
            {
                return mid;
            }

            if (guess > item)
            {
                high = mid - 1;
            }

            if (guess < item)
            {
                low = mid + 1;
            }
        }

        throw new ArgumentOutOfRangeException(nameof(item));
    }
}