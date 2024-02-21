using System;
using System.Collections.Generic; //List를 위함
using System.Linq; //Distinct를 위함 <= 중복되는 값을 제거



public class Solution {
    public int[] solution(int[] numbers) {
        //리스트 기능들 쓰기 위해 리스트로
        List<int>answer = new List<int>{};
        //2개의 수를 정하는 이중 반복문
        for(int i = 0; i < numbers.Length; i++)
        {
            for(int j = i + 1; j < numbers.Length; j++)   
            {
                answer.Add(numbers[i] + numbers[j]);
            }
        }
        //오름차 정렬
        answer.Sort();
        //배열화 밑 중복 제거
        return answer.Distinct().ToArray();
    }
}