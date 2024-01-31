//문자열이 숫자인지 확인하는 법 필요
//콘솔 과제때 잘썼던 int TryParse를 이용 가능하지 않을까
public class Solution {
    public bool solution(string s) {
        bool answer = false;
        if(s.Length == 4 || s.Length == 6)
        {
            answer = int.TryParse(s, out int result);
        }
        return answer;
    }
}