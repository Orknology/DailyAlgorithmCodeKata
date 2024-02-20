//주의 : commands는 2차원 배열
using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        //commands를 2차원 배열의 행 갯수만큼 asnswer 배열 초기화
        int[] answer = new int[commands.GetLongLength(0)];
        //GetLongLength = https://learn.microsoft.com/en-us/dotnet/api/system.array.getlonglength?view=net-8.0
        
        //0부터 commands 2차원 배열의 행 갯수까지 반복
        for(int n = 0; n < commands.GetLongLength(0); n++)
        {
            //초기화
            int i = commands[n,0];
            int j = commands[n,1];
            int k = commands[n,2];
        
            //i번째 부터 j번째 까지 자른 배열 저장
            int[] temp = new int[j - i + 1];
        
            //temp 크기 만큼 반복하여 i번째 숫자부터 비교 대입
            for(int a = 0; a < temp.Length; a++)
            {
                temp[a] = array[a+i-1];
            }
        
            //배열 정렬
            Array.Sort(temp);
        
            //k번째 숫자 답에 전달
            answer[n] = temp[k-1];
        }
        return answer;
    }
}