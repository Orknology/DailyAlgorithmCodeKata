//오랜만에 봐도 문제 설명이 쉽지않다. 예시가 없다면 이해하기 어려웠을 것
//어떤 형식으로 분해를 시켜야 할까 고민하다 너무 지저분한 코드가 되어가서
//다른 답안을 참고하게 되었다. 여기서는 인덱스를 세분화한 것과
//bool체크를 통한 것이 다른 점이다.
//코드가 복잡해지던 원인이 새로운 문자의 시작지점을 판단하는 것이었는데
//이러한 체크가 더 깔끔해진 것이다.

public class Solution {
    public int solution(string s) {
        int answer = 0; // 분해한 문자열의 개수
        int sameIdx = 0; // 같은 문자열 개수
        int diffIdx = 0; // 다른 문자열 개수
        char word = ' '; // 현재 단어
        bool start = true; // 시작지점 판단
        
        for(int i = 0; i < s.Length; i++)
        {
            if(start == true) // 시작지점으로 판단될 때
            {
                word = s[i]; // 현재 단어 저장
                sameIdx++; // 같은 문자열 개수를 +
                start = false; // 시작지점 false로
            }
            else
            {
                if(s[i] == word)
                {
                    sameIdx++; // 같은 문자일 때 sameIdx에 +
                }
                else
                {
                    diffIdx++; // 다른 문자일 때 diffIdx에 +
                }
            }
            
            if(sameIdx == diffIdx) 
            // 다른 글자들이 나온 횟수가 같아지는 순간
            {
                // 답에 + 를 해주며 나머지 인덱스 초기화
                answer++;
                sameIdx = 0;
                diffIdx = 0;
                start = true; //다시 시작지점을 돌려준다
            }
            if(i == s.Length - 1) { if(start == false) { answer++; } } //마지막 지점에 도달했음에도 횟수가 같지 않다면 끊고 답에 + 해주는 조건문
        }
        return answer;
    }
}