
using System;
using System.Linq;

public class Solution {
    public int solution(int[] diffs, int[] times, long limit) {
        int min = diffs[0];
        int max = diffs.Max();
        int level;
        while (true)
        {
            if (min == max)
            {
                level = min;
                break;
            }

            level = (min + max) / 2;
            if (CanSolve(level, diffs, times, limit))
            {
                max = max == level ? level - 1 : level;
            }
            else
            {
                min = min == level ? level + 1 : level;    
            }
        }
        return level;
    }

    private bool CanSolve(int level, int[] diffs, int[] times, long limit)
    {
        long time = 0;
        for (int i = 0; i < diffs.Length; i++)
        {
            time += Solve(diffs[i], level, times[i], i > 0 ? times[i - 1] : 0);
        }
        return time <= limit;
    }

    private long Solve(int diff, int level, int time_cur, int time_prev)
    {
        int difficulty = diff - level;
        difficulty = difficulty > 0 ? difficulty : 0;
        return time_cur + difficulty * (time_cur + time_prev);
    }
}