public class Solution {
    public int solution(int num) {
        long x = num;
        for (int i = 0; i <= 500; i++)
        {
            if (x == 1)
                return i;
            x = (x % 2 == 0) ? x / 2 : x * 3 + 1;
        }
        return -1;
    }
}