    public class Solution
    {
        public bool solution(int x)
        {
            int sumChar = 0;
            string temp = x.ToString();
            foreach (char i in temp)
            {
                sumChar += i - '0';
            }

            if(x % sumChar == 0)
                return true;
            return false;
        }
    }