//로직을 어떤 식으로 짜야할 지 어려움이 있었기에 인터넷 검색을 하였고
//문제풀이를 보며 같은 식으로 작성해보았습니다.

using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        //각 수포자의 패턴, 이부분이 하드코딩이지만 문제풀이는 더 간단해진다.
        int[] supo1 = new int[5] {1, 2, 3, 4, 5};
        int[] supo2 = new int[8] {2, 1, 2, 3, 2, 4, 2, 5};
        int[] supo3 = new int[10] {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        int[] score = new int[3] {0, 0, 0};
        int max = 0;
        List<int> nList = new List<int>();
        
        for(int i = 0; i < answers.Length; i++)
        {
            //각 수포자가 선택한 답이 맞는지 체크하는 for문
            if(supo1[i % 5] == answers[i]) { score[0]++; }
            if(supo2[i % 8] == answers[i]) { score[1]++; }
            if(supo3[i % 10] == answers[i]) { score[2]++; }
        }
        //산출된 점수들 중에서 가장 높은 값을 찾는 역할
        for(int i = 0; i < 3; i++) { if(max < score[i]) { max= score[i]; } }
        //그 가장 높은 값을 낸 수포자를 찾는 역할
        for(int i = 0; i < 3; i++) { if(max == score[i]) { nList.Add(i+1); } }
        
        return nList.ToArray();
    }
}