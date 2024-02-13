//제한 사항 p 길이를 보면 int 말고 long 필요
//p와 값을 비교시키기 위해선 long.Parse(p)와 비교 시켜야함
//세글자로 묶는걸 삼총사 풀이랑 비슷하게 해야하나
//Substring이란걸 찾았다. 이걸 써봐야 할지도.

//필요사항 :
//Substring은 배열에서 자를 위치 / 자를 길이를 받아야함
//자를 길이는 p.Length로 가능해보임. 자를 위치는?
//t에서 p.Length만큼 묶이는게 멈출때까지 한글자씩 앞으로 가야함 -> 우선 for문으로
//마지막에 묶이고 멈추려면 t.Length에서 p.Length를 뺀 수치만큼 진행해야함.

using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        long long_p = long.Parse(p);
        
        for(int i = 0; i <= t.Length - p.Length; i++)
        {
            long long_t = long.Parse(t.Substring(i, p.Length));
            if(long_t <= long_p)
                answer++;
        }
        
        return answer;
    }
}