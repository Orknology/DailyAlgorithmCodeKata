using System;
public class Solution {
    public string solution(string[] seoul) {
        string kim = "Kim";
        int index = Array.IndexOf(seoul, kim);
        string answer = $"김서방은 {index}에 있다";
        return answer;
    }
}