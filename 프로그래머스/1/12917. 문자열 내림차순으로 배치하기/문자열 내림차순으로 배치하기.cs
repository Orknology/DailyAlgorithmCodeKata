using System;
//정수 내림차순으로 배치하기 때 사용한 방법이 그대로 가능 할 것

public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] temp = s.ToCharArray();
        Array.Sort(temp);
        Array.Reverse(temp);
        answer = new string(temp);
        return answer;
    }
}