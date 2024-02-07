//배열을 이용한 문제풀이를 해보자
//Split() 메소드를 사용해서 공백기준으로 나눠서 배열에 저장
//for문으로 각 배열을 불러오고 이중 for문으로 각 배열마다 문자를 한 글자 씩 검사
//각 한 글자 씩 검사하기 때문에 char형태라 Char.ToUpper / Char.ToLower 메소드 이용
using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        //공백 기준 나누기
        string[] arr = s.Split();
        
        //각 배열 호출
        for (int i = 0; i < arr.Length; i++)
        {
            //이중 for문
            for (int j = 0; j < arr[i].Length; j++)
            {
                //0은 자동 대문자
                if ( j == 0 )
                {
                    answer += Char.ToUpper(arr[i][j]);
                    //컨티뉴 안 넣으면 안돼 크아악
                    continue;
                }
                //홀수 짝수 구분
                if ( j % 2 == 0)
                {
                    answer += Char.ToUpper(arr[i][j]);
                }
                else 
                {
                    answer += Char.ToLower(arr[i][j]);
                }
            }
            //한 글자 씩 출력하기 때문에 띄어쓰기가 무시된다
            //이 부분을 for문 중에 추가해주어야 하는데,
            //문장에 마지막에 추가될 경우에는 결괏값이 달라지기에
            //마지막 전에 끊어주어야 하는 조건이 필요하다
            if (i != arr.Length-1)
                {
                    answer += " ";
                }
        }
        return answer;
    }
}
