//arr[i] = price on day i
//max profit: buy at minimum and sell at highest.
// sell can happen only after buy
int[] arr={7,1,5,3,6,4};

 int MaxProfit(int[] arr)
{
    int minPrice=int.MaxValue;
    int maxProfit=0;
    for(int i=0; i < arr.Length; i++)
    {
       minPrice=Math.Min(minPrice, arr[i]);
       int profit=arr[i]-minPrice;
       maxProfit=Math.Max(maxProfit,profit);
    }

    return maxProfit;
}


int  result= MaxProfit(arr);
Console.WriteLine("max profit is {0}", result);