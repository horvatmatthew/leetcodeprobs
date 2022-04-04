public class Solution
{
    public string ReverseWords(string s)
    {
        var words = s.Split(" ", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

        StringBuilder sb = new StringBuilder();
        for(int i = words.Length - 1; i >= 0; i--)
        {
            sb.Append(words[i] + " ");
        }

        return sb.ToString().TrimEnd();
    }
}