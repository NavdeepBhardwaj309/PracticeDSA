int[] arr={5,2,0,0,3,0,0,4,1,0,0,0,6};
// T-O(N) S-O(1)
int [] leftAlignZeros(int[] arr)
{
    int i=arr.Length-1;
    int j=arr.Length-1;
    while(i>=0)
    {
        if(arr[i]!=0)
        {
            arr[j]=arr[i];
            j--;
        }
        i--;
    }
    while(j>=0)
    {
        arr[j]=0;
        j--;
    }
    return arr;
    
}

int [] RightAlignZeros(int[] arr)
{
    int i=0;
    int j=0;
    while(i<arr.Length)
    {
        if(arr[i]!=0)
        {
            arr[j]=arr[i];
            j++;
        }
        i++;
    }
    while(j<arr.Length)
    {
        arr[j]=0;
        j++;
    }
    return arr;

}