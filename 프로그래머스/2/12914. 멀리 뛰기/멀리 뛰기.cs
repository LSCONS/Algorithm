using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System;



public class Solution
{
    public long solution(int n)
    {
        const int MOD = 1234567;
        long answer = 0;

        // dp[j] 는 현재 i행에서 C(i, j) % MOD 를 저장
        int[] dp = new int[n + 1];
        dp[0] = 1;  // C(0,0)=1

        for (int i = 1; i <= n; i++)
        {
            // 뒤에서부터 갱신해야 이전 dp[j-1] 값이 그대로 남습니다
            for (int j = i; j >= 1; j--)
            {
                dp[j] += dp[j - 1];
                if (dp[j] >= MOD) dp[j] -= MOD;
            }

            int k = n - i;
            if (i >= k)  // i >= n-i 인 경우에만 C(i, k) 를 더함
            {
                answer += dp[k];
                if (answer >= MOD) answer -= MOD;
            }
        }

        return answer;
    }
}