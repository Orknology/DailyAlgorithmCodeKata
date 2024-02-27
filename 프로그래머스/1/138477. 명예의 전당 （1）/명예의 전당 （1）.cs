//리스트를 만들어야할 것
//리스트.Count가==k일 때 리스트가 오름차 순이라면
//리스트[0]과 score[i]의 값을 비교하여 [i]가 더 높다면
//리스트에서 지우는 메소드 찾아보니 RemoveAt[0]
//[i]를 Add하고 [i]가 [0]보다 높은 것 과는 별개로 다른 것들 보다 높을 수 있으니
//재정렬 한번 해야함
//answer를 score.Length로 잡아줘야 하는 듯

using System;
using System.Collections.Generic; //리스트에 필요
using System.Linq;


public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> ranking = new List<int>();
        
        for(int i = 0; i < score.Length; i++)
        {
            if(ranking.Count == k)
            {
                if(ranking[0] > score[i])
                {
                    answer[i] = ranking[0];
                    continue;
                }
                ranking.RemoveAt(0);
            }
            ranking.Add(score[i]);
            ranking.Sort();
            answer[i] = ranking[0];
        }
        return answer;
    }
}