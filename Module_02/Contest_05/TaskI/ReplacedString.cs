public class ReplacedString
{
    private string replacedString;

    public ReplacedString(string s, string initialSubstring, string finalSubstring)
    {
        while (s.Contains(initialSubstring))
        {
            if (s.Replace(initialSubstring, finalSubstring) == s)
            {
                break;
            }
            else 
            {
                s = s.Replace(initialSubstring, finalSubstring); 
            }
        }
        replacedString = s;
    }

    public override string ToString()
    {
        return replacedString;
    }
}