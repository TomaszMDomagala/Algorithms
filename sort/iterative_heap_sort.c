#include <stdio.h>

void buildMaxHeap(int arr[], int n)
{
    for (int i = 1; i < n; i++) {
        if (arr[i] > arr[(i - 1) / 2]) {
            int j = i;

            while (arr[j] > arr[(j - 1) / 2]) {
                int temp=arr[j];
                arr[j]=arr[(j-1)/2];
                arr[(j-1)/2]=temp;
                j = (j - 1) / 2;
            }
        }
    }
}

void heapSort(int arr[], int n)
{
    buildMaxHeap(arr, n);

    for (int i = n - 1; i > 0; i--)
    {
        int temp=arr[0];
        arr[0]=arr[i];
        arr[i]=temp;

        int j = 0, index;

        do
        {
            index = (2 * j + 1);

            if (arr[index] < arr[index + 1] &&
                                index < (i - 1))
                index++;

            if (arr[j] < arr[index] && index < i)
            {
                int tem1=arr[j];
                arr[j]=arr[index];
                arr[index]=tem1;
            }

            j = index;

        } while (index < i);
    }
}

int main()
{
    int arr[] = {10, 20, 15, 17, 9, 21};
    int n = sizeof(arr) / sizeof(arr[0]);

    printf("Given array: ");
    for (int i = 0; i < n; i++)
        printf("%d ", arr[i]);

    printf("\n\n");

    heapSort(arr, n);

    printf("Sorted array: ");
    for (int i = 0; i < n; i++)
        printf("%d ", arr[i]);

    return 0;
}