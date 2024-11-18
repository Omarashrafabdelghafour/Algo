using System;
///
namespace Problem
{
    public static class PROBLEM_CLASS
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static int Partition(int[] data, int low, int high)
        {
            int pivot = data[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (data[j] <= pivot)
                {
                    i++;
                    Swap(ref data[i], ref data[j]);
                }
            }
            Swap(ref data[i + 1], ref data[high]);
            return i + 1;
        }

        static void QuickSortAlgorithm(int[] data, int low, int high)
        {
            if (low < high)
            {
                int p = Partition(data, low, high);
                QuickSortAlgorithm(data, low, p - 1);
                QuickSortAlgorithm(data, p + 1, high);
            }
        }

        public static int[] RequiredFunction(int[] numbers, int k)
        {
            if (k >= numbers.Length || k < 0)
            {
                Console.WriteLine("Invalid k");
                return null;
            }

            int[] kth = new int[k];
            int orginalLength = numbers.Length;
            QuickSortAlgorithm(numbers, 0, orginalLength - 1);

            Console.WriteLine("The top k elements are:");
            for (int i = orginalLength - 1, j = 0; j < k; i--, j++)
            {
                kth[j] = numbers[i];
                Console.WriteLine(kth[j]);
            }
            return kth;
        }
    }
}
