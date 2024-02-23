//문제 설명 길이가 슬슬 과하다
//결국 양 선수 같은 양의 음식과 종류를 주는 것
//물 = 0은 항상 중간에 1회
//즉 2로 나눈 뒤 물까지 가는 수를 구하고 이를 뒤집어서 0 이후 더하면 같은 결과
//그렇기에 첫 for문에서 food의 갯수만큼 i를 돌려주고 나온 수를 2로 나누어주면 절반 완성

using System;
using System.Linq;

public class Solution {
    public string solution(int[] food) {
       string answer = "";
        string str = "";
        
        for(int i = 1; i < food.Length; i++)
        {
            for(int j = 0; j < food[i] / 2; j++)
            {
                answer += i.ToString();
            }
        }
        //Concat = string 연결 / reverse로 뒤집기
        str = String.Concat(answer.Reverse());
        return answer + "0" + str;
    }
}