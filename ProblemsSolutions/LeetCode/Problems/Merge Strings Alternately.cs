using System.Text;

namespace ICPC2024.LeetCode.Problems;

public class Merge_Strings_Alternately : ILeetCodeProblem
{
    public string ProblemLink =>
        "https://leetcode.com/problems/merge-strings-alternately/description/?envType=study-plan-v2&envId=leetcode-75";
    
    public string MergeAlternately(string word1, string word2)
    {
        StringBuilder s = new StringBuilder();
        
        for(int i = 0; i <=  Math.Min(word1.Length, word2.Length)- 1; i++)
        {
            s.Append(word1[i]);
            s.Append(word2[i]);
        }
        for(int i = Math.Min(word1.Length, word2.Length); i < Math.Max(word1.Length, word2.Length); i++)
        {
            if (word1.Length > word2.Length)
            {
                s.Append(word1[i]);
            }
            else
            {
                s.Append(word2[i]);
            }
        }

        return s.ToString();
    }
}