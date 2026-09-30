using myprogressapp1.Interfaces;

namespace myprogressapp1.Algorithms.DynamicProgramming
{
    public class ClimbingStairs:IProgramInterface
    {
        public void ExecuteProgram()
        {
            int n = 5; // Example input
            int[]dp=new int[n+1]  ;      
            int ways = ClimbStairs_TopDown(n,dp);

            Console.WriteLine($"Number of ways to climb {n} stairs: {ways}");
        }

        //febonacci series top down approach
        public int ClimbStairs_TopDown(int n, int[] dp)
        {
           if(n<=2)
           return n;
          if(dp[n]!=0) //memoization
          return dp[n];
          dp[n]=ClimbStairs_TopDown(n-1,dp)+ClimbStairs_TopDown(n-2,dp);
          return dp[n]; 
        }

        //febonacci series bottom up approach
        public int ClimbStairs_BottomUp(int n)
        {
            if(n<=2)
            return n;
            int[]dp=new int[n+1];
            dp[1]=1;
            dp[2]=2;
            for(int i = 3; i <= n; i++)
            {
                dp[i]=dp[i-1]+dp[i-2];
            }
            return dp[n];
        }
    }
}