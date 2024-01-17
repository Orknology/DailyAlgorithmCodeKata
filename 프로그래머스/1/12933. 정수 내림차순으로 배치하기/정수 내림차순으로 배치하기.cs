using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        char[] arr = n.ToString().ToCharArray(); //long -> string -> char배열 
        Array.Sort(arr); //배열 오름차순
        Array.Reverse(arr); //파워 뒤집기
        answer = long.Parse(arr);
        return answer;
    }
}