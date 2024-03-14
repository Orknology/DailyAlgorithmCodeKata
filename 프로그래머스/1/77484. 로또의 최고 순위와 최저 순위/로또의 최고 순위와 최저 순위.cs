//순서가 상관없는 점이 다행, 겹치는 수도 없다
//맞는 갯수를 세고 알아볼 수 없는 갯수를 세야함

using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        
        int correct = 0;
        int unrecognizableCount = 0;
        
        //로또 번호만큼 돌려서 0의 갯수와 맞는 갯수를 세기
        for(int i = 0; i < lottos.Length; i++)
        {
            if(lottos[i] == 0)
                unrecognizableCount++;
            if(lottos.Contains(win_nums[i]))
                correct++;
        }
        
        //최대(0이 다 맞는 상황), 최소 랭크(0이 다 틀릴 상황)
        //7에서 빼는 이유는 2개는 맞추어야 5등이기 때문
        int maxRank = 7 - (unrecognizableCount + correct);
        int minRank = 7 - correct;
        //테스트 돌려보니 모두 틀렸을 때는 7등이라는 수가 나와버려서
        //맞는 것이 0개가 되는 상황 때는 1을 빼주는 조건문
        if(maxRank == 7)
            maxRank -= 1;
        if(minRank == 7)
            minRank -= 1;
        
        int[] answer = new int[] {maxRank, minRank};
        return answer;
    }
}