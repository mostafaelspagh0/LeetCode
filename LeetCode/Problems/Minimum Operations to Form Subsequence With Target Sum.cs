namespace LeetCode.Problems;

// ReSharper disable once UnusedType.Global
// ReSharper disable once InconsistentNaming
#pragma warning disable SA1600
public class Minimum_Operations_to_Form_Subsequence_With_Target_Sum : ILeetCodeProblem
{
    public string ProblemLink { get; set; } =
        "https://leetcode.com/problems/minimum-operations-to-form-subsequence-with-target-sum/description/";
    public int MinOperations(IList<int> nums, int target)
    {
        long sum = 0;
        foreach (var num in nums)
        {
            sum += num;
        }
        if (sum < target)
        {
            return -1;
        }
        int[] numsFrq = new int[35];
        int[] targetFrq = new int[35];
        int ans = 0;
        foreach (var num in nums)
        {
            int i = 0;
            int numC = num;
            while (numC > 0)
            {
                if ((numC & 1) == 1)
                {
                    numsFrq[i]++;
                }
                numC >>= 1;
                i++;
            }
        }

        {
            int i = 0;
            int numC = target;
            while (numC > 0)
            {
                if ((numC & 1) == 1)
                {
                    targetFrq[i]++;
                }
                numC >>= 1;
                i++;
            } 
        }
        
        for (int i = 0; i < 32; i++)
        {
            if (targetFrq[i] <= numsFrq[i])
            {
                numsFrq[i] -= targetFrq[i];
                numsFrq[i + 1] += numsFrq[i] / 2;
                numsFrq[i] = numsFrq[i] % 2;
            }
            else
            {
                while (numsFrq[i] < targetFrq[i])
                {
                    int nearestOne = -1;
                    for (int j = i + 1; j < 32; j++)
                    {
                        if (numsFrq[j] != 0)
                        {
                            nearestOne = j;
                            break;
                        }
                    }

                    while (nearestOne > i)
                    {
                        numsFrq[nearestOne]--;
                        numsFrq[nearestOne - 1] += 2;
                        ans++;
                        nearestOne--;
                    }
                }
                numsFrq[i] -= targetFrq[i];
                numsFrq[i + 1] += numsFrq[i] / 2;
                numsFrq[i] = numsFrq[i] % 2;
            }
        }

        return ans;
    }
}