namespace LeetCode.Problems;

public class Most_Common_Word : ILeetCodeProblem
{
    public string ProblemLink => "https://leetcode.com/problems/most-common-word/description/";
    
    public string MostCommonWord(string paragraph, string[] banned)
    {
        var bannedSet = new HashSet<string>();
        foreach (var word in banned)
        {
            bannedSet.Add(word);
        }
        
        var words = paragraph.Split(new []{' ', '!', '?', '\'', ',', ';', '.'}, StringSplitOptions.RemoveEmptyEntries);
        var wordFrq = new Dictionary<string, int>();
        foreach (var word in words)
        {
            wordFrq[word.ToLower()] = wordFrq.GetValueOrDefault(word.ToLower(), 0) + 1;
        }
        
        var max = 0;
        var ans = "";
        foreach (var (word, frq) in wordFrq)
        {
            if (frq <= max || bannedSet.Contains(word)) continue;
            max = frq;
            ans = word;
        }

        return ans;
    }
}