using System.Text;

Solution Solution = new Solution();


Solution.LengthOfLongestSubstring("qrsvbspk");
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0) return 0;
        if (s.Length == 1) return 1;

        int maxLenght = 1;

        char[] chars = new char[1];
        chars[0] = s[0];

        for (int i = 1; i < s.Length; i++)
        {
            if (chars.Contains(s[i]))
            {
                char[] newChars = new char[chars.Length - 1];
                chars = chars.Skip(1).ToArray();
                if (!chars.Contains(s[i]))
                {
                    Array.Resize(ref chars, chars.Length + 1);
                    chars[chars.Length - 1] = s[i];
                }
                else
                {
                    int index = Array.IndexOf(chars, s[i]);
                    chars = chars.Skip(index+1).ToArray();

                    Array.Resize(ref chars, chars.Length + 1);
                    chars[chars.Length - 1] = s[i];

                }

            }
            else
            {
                Array.Resize(ref chars, chars.Length + 1);
                chars[chars.Length - 1] = s[i];
                if (maxLenght < chars.Length) maxLenght = chars.Length;
            }

        }

        return maxLenght;
    }


}