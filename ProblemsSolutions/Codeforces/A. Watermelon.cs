namespace ICPC2024.Codeforces;

public class A__Watermelon : ICodeforcesProblem
{
    public string ProblemLink => "https://codeforces.com/problemset/problem/4/A";

    public void Solve()
    {
        var watermelonSize = int.Parse(Console.ReadLine()!);
        if (watermelonSize % 2 == 0 && watermelonSize > 2)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}