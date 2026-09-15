public static class FindEqualSumIndex{


// timecomplexity =o(n)+o(n)= o(n)
    public static void findIndex()
    {
        Console.WriteLine("Enter array elements separated by space:");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int result = FindPivotIndex(arr);
        Console.WriteLine("Equilibrium Index: " + result);
    }
    public static int FindPivotIndex(int[] arr)
    {
        int totalSum = 0;
        foreach (int num in arr)
            totalSum += num;

        int leftSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            // right sum = totalSum - leftSum - arr[i]
            int rightSum = totalSum - leftSum - arr[i];

            if (leftSum == rightSum)
                return i;

            leftSum += arr[i];
        }

        return -1; // no equilibrium index found
    }
}