namespace LeetCode.Problems;
using System.Collections;

// ReSharper disable once UnusedType.Global
// ReSharper disable once InconsistentNaming
#pragma warning disable SA1600
public class Last_Visited_Integers : ILeetCodeProblem
{
    public string ProblemLink { get; set; } = "https://leetcode.com/problems/last-visited-integers/description/";

    public IList<int> LastVisitedIntegers(int[] nums)
    {
        var seen = new List<int>();
        var ans = new List<int>();
        int k = 0;
        foreach (int num in nums)
        {
            if (num == -1)
            {
                k++;
                if (seen.Count >= k)
                {
                    ans.Add(seen[^k]);
                }
                else
                {
                    ans.Add(-1);
                }
            }
            else
            {
                k = 0;
                seen.Add(num);
            }

        }

        return ans;
    }
}