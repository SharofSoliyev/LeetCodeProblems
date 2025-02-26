public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        if (Reverse(x) == x) return true;

        else return false;
    }

    public int Reverse(int x)
    {
        int reversed = 0;
        int tempX = x;
        while (tempX != 0)
        {
            int temp = tempX % 10;

            reversed = reversed * 10 + temp;

            tempX = tempX / 10;
        }
        return reversed;
    }

}