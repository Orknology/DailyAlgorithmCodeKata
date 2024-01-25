using System;

//배열을 서로 순서대로 불러서 곱하고 더하면 된다.
//string이 아니니까 그냥 for문으로 순서대로 불러내면?
public class Solution {
    public int solution(int[] a, int[] b) {
        int answer = 0;
        for (int i = 0; i < a.Length; i++)//a,b의 길이는 동일
        {
            answer += a[i] * b[i];
        }
        return answer;
    }
}