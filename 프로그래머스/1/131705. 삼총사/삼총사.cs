//배열 자체에 이를 위한 기능은 없을까?
//3중 for문으로 배열에 0, 1, 2 번째 부터 확인하면서
//if 조건문으로 i+j+K == 0 이 되는 상황을 찾는 것으로 가능할까
using System;

public class Solution {
    public int solution(int[] number) {
        int answer = 0;
        
        for(int i = 0; i < number.Length; i++)
            for(int j = 1; j < number.Length; j++)
                for(int k = 2; k < number.Length; k++)
                    //i < j < k로 같은 수 제외 및 크기 구분
                    if(i < j && j < k)
                        if((number[i] + number[j] + number[k]) == 0)
                            answer++;
        
        return answer;
    }
}