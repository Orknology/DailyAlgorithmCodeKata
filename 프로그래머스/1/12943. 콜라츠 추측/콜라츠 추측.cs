public class Solution {
    public long solution(long num) {
        long answer = 0;
        long x = num;
        while (answer <= 500)
        {
            if (x == 1)
                return answer;
            answer++;
            x = (x % 2 == 0) ? x / 2 : x * 3 + 1;
        }
        return -1;
    }
}