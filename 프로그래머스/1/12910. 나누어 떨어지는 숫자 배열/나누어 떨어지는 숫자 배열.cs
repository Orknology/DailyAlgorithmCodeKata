using System;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = new int[arr.Length];
        int temp = 0;
        
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] % divisor == 0)
            {
                //answer배열에 temp로 i값을 저장하고 다음 index로
                answer[temp] = arr[i];
                temp++;
            }
        }
        if(temp == 0)
        {
            //배열에 -1 담아 반환
            Array.Resize(ref answer, 1); //배열 길이 1로 리사이즈
            answer[0] = -1;
        }
        else
        {
            Array.Resize(ref answer, temp); //0값들을 제거하기 위해 리사이즈
            Array.Sort(answer);
        }
        return answer;
    }
}