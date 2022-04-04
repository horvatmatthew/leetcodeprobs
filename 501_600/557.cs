public class Solution
{
    public string ReverseWords(string s)
    {
        var words = s.Split(" ", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < words.Length;i++)
        {
            for(int j = words[i].Length-1; j >= 0; j--)
            {
                sb.Append(words[i][j]);
            }
            sb.Append(" ");
        }

        return sb.ToString().TrimEnd();
    }
}