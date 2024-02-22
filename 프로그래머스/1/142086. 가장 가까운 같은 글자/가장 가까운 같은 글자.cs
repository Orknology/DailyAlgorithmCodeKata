public class Solution {
    public int[] solution(string s) {
        //s의 길이만큼 int 배열 생성
        int[] answer = new int[s.Length];
        //기본 인덱스 넘버
        int index = -1;
        
        for(int i = 0; i < s.Length; i++)
        {
            //인덱스 넘버 초기화
            index = -1;
            //이전에 i와 같은 문자가 있는지 체크하는 j
            for(int j = i - 1; j >= 0; j--)
            {
                if(s[i] == s[j])
                {
                    index = i - j;
                    break;
                }
            }
            answer[i] = index;
        }
        return answer;
    }
}