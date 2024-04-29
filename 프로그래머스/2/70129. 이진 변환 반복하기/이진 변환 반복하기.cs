//먼저 솔루션을 검색을 해보았다. 뭔가 이런 용도에 필요한 메서드를 찾을 수 있을 것 같아서
//역시나 string.Replace()를 이용해 여기에 Empty값이 들어갈 수 있다는 사실을 새로 알게 되었다.
//이를 이용해 0값을 지운 문자열을 새로 만들어 인수로 들어온 문자열의 길이에서 빼서 그 값을 더하고
//사이클을 돌기 전 s값을 0값을 지운 문자열 길이를 2진수로 변환한 문자열로 변경해준다
//이 2진수로의 변경은 Convert.ToString(문자열.length,2)를 통해 간으하다

using System;

public class Solution {
    public int[] solution(string s) {
        int zeroCount = 0;
        int loopCount = 0;
        while(s != "1")
        {
            string replaceStr = s.Replace("0", string.Empty);
            int lengthDiff = s.Length - replaceStr.Length;
            zeroCount += lengthDiff;
            loopCount++;
            s = Convert.ToString(replaceStr.Length, 2);
        }
        
        int[] answer = new int[] {loopCount, zeroCount};
        return answer;
    }
}