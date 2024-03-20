//3가지 배열이 생기게 됨 - 학생 번호 별 / 도난 당한 학생 / 여벌을 가진 학생 
//여벌 체육복의 학생은 도난 당해도 한 개만 당해 본인은 처리 가능

using System;

public class Solution
{
    public int solution(int n, int[] lost, int[] reserve)
    {
        int answer = 0;
        
        // 학생 번호에 따라 배열 생성
        int[] intArray = new int[n];
        
        // 유형 별 반복문으로 가진 체육복의 개수 체크
        for(int i = 0; i < intArray.Length; i++)
            intArray[i] = 1;
        for(int i = 0; i < lost.Length; i++)
            intArray[lost[i] - 1]--;
        for(int i = 0; i < reserve.Length; i++)
            intArray[reserve[i] - 1]++;
        
        // 체육복 빌리는 과정
        for(int i = 0; i < intArray.Length; i++)
        {
            if(intArray[i] == 0)
            {
                if(i > 0 && intArray[i - 1] == 2)
                {
                    intArray[i - 1] = 1;
                    intArray[i] = 1;
                }
                else if(i < intArray.Length - 1 && intArray[i + 1] == 2) 
                {
                    intArray[i] = 1;
                    intArray[i + 1] = 1;
                }
            }
        }
        
        // 체육복을 가지게 된 학생의 수
        for(int i = 0; i < intArray.Length; i++)
            if(intArray[i] > 0)
                answer++;
        
        return answer;
    }
}