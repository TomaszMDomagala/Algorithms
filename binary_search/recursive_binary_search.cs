using System;

class RecursiveBinarySearch
{
    static int binarSearch(int[] arr, int left, int right, int x)
    {
        int (right >= left)
        {
            int middle = left + (right - 1) / 2;
            if (arr[middle] == x) return middle;
            if (arr[middle] > x) return binarSearch(arr, left, middle - 1, x);
            return binarSearch(arr, middle + 1, right, x);
        }

        return -1;
    }

    public static void Main()
    {
        int[] arr = {2, 3, 4, 10, 40, 60, 100};
        int n = arr.Length;
        int x = 10;
        int result = binarySearch(arr, 0, n - 1, x);
 
        if (result == -1)
            Console.WriteLine("Element is not present in array");
        else
            Console.WriteLine("Element is present at index "+ result);
    }

}