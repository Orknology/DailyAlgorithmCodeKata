//문자열을 일정하게 Char배열로 저장(소문자로)
//첫번째 char값을 대문자 변환
//숫자는 ToUpper, ToLower로 값이 변경되지 않으니
//굳이 예외처리 하지 않는다.
//뒷부분 부터는 해당 값 앞에 공백이 있다면 대문자 변환

public class Solution {
    public string solution(string s) {
        char[] charArr = s.ToLower().ToCharArray();
        charArr[0] = char.ToUpper(charArr[0]);
        for(int i = 1; i < charArr.Length; i++)
        {
            if(charArr[i - 1] == ' ')
            {
                charArr[i] = char.ToUpper(charArr[i]);
            }
        }
        string answer = string.Join(string.Empty, charArr);
        return answer;
    }
}