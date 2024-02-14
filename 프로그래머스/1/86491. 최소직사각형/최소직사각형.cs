//이번엔 지금 수준에서 풀기 어려운 내용이다.
//Math기능은 거의 다뤄본 적이 없어 인터넷을 찾아봐야 했으며
//풀이를 보고 공부한 내용을 정리하겠다.
using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        //가로와 세로 길이 중 최대값을 저장하는 함수
        int max1 = 0;
        int max2 = 0;
        //배열 sizes를 순회하면서 가로와 세로 길이를 비교, 최댓값을 구함
        for(int i = 0; i < sizes.GetLength(0); i++)
        {
            //명함 가로와 세로 길이 둘 중 더 큰 값을 Math.Max를 사용 비교, 큰 값이 max1
            max1 = Math.Max(max1, Math.Max(sizes[i,0], sizes[i,1]));
            //명함 가로와 세로 길이 둘 중 더 작은 값을 Math.Min으로 비교, "더 큰"값이 max2
            max2 = Math.Max(max2, Math.Min(sizes[i,0], sizes[i,1]));
        }
        //위 과정 후에는 명함 가로 길이 중 가장 큰 값 max1과 가장 작아질 수 있는 세로 max2 
        
        //지갑 크기 계산
        answer = max1 * max2;
        return answer;
    }
}