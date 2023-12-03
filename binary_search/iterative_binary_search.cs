using System;

class IterativeBinarySearch
{
    static int binarySearch(int[] arr, int x)
    {
        int left = 0, right = arr.Length -1;
        while (left <= right)
        {
            int middle = left + (right - 1) / 2;
            if (arr[middle] == x)
                return middle;
            if (arr[middle] < x)
                left = middle + 1;
            else
                right = m - 1;
        }

        return -1;
    }

    public static void Main()
    {
        int[] arr = {2, 3, 4, 10, 40, 60, 100};
        int n = arr.Length;
        int x = 10;
        int result = binarySearch(arr, x);
        if (result == -1)
        {
            Console.WriteLine("Element is not present in array");
        }
        else
        {
            Console.WriteLine("Element is present at index " + result);
        }
    }
}