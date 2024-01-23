//string을 배열로 옮기는 것이 편하겠지?
//혹은 substring이 변환도 없이 빠르지 않을까 
//이러면 x(자르기 시작할 지점), y(받을 갯수)값을 받아야한다.
//y = 짝수일 때 2 / 홀수일 때 1
//x = 중간값 = s.Length / 2 와 s.Length / 2 -1
using System;

public class Solution {
    public string solution(string s) {
        string answer = ""; 
        int x = 0;
        int y = 0;
            
        if(s.Length % 2 == 1)
        {
            x = s.Length / 2;
            y = 1;
        }
        else
        {
            x = s.Length / 2 -1;
            y = 2;
        }

        return answer = s.Substring(x, y);
    }
}