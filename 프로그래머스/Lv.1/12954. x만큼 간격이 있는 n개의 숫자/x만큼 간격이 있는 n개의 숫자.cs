public class Solution {
    public long[] solution(int x, int n) {
        long[] answer = new long[n]; //배열 길이 미리 지정
        long y = 0; //x값 받아 줄 함수 선언
        for(int i = 0; i < n; i++)
        {
            y += x;
            answer[i] = y;
        }
        return answer;
    }
}