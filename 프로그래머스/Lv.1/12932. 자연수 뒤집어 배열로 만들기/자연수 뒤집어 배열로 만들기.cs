public class Solution {
    public int[] solution(long n) {
        string temp = n.ToString();
        int[] answer = new int[temp.Length];
        
        for (int i = 0; temp.Length > i; i++)
        {
            answer[i] = (int)(n%10);
            n /= 10;
            //배열에서 뒷부분 부터 잡으려면 10으로 나머지를 잡는 방법
        }
        return answer;
    }
}