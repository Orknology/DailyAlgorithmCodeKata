//문자열의 원하는 부분만 가져오기?
//생각나는 방법은 for문 Length-4
//string에 바로 덧셈이 들어가나? 생각해보니 안해본듯

public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        for (int i = 0; i < phone_number.Length; i++)
        {
            if (i < phone_number.Length - 4)
                answer += "*";
            else
                answer += phone_number[i];
        }
        return answer;
    }
}