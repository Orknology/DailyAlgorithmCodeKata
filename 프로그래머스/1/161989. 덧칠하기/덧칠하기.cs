using System;

public class Solution {
   public int solution(int n, int m, int[] section)
        {
            int answer = 0;
            int num = 0; //칠할 구역
       
            //벽의 길이 만큼 for문
            for (int i = 0; i < section.Length; i++)
            {
                //칠할 구역은 벽의 길이보다 짧아야함
                if (section[i] > num)
                {
                    num = (section[i] + m) - 1;
                    answer++;
                }
            }
            return answer;
        }
}