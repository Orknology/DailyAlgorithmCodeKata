//배열 strings를 OrderBy()를 통해 정렬 
//한번 더 OrderBy()를 사용하여 x[n]을 기준으로 정렬 
//ToArray()로 다시 배열로

using System.Linq;

public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = new string[] {};
        
        answer = strings.OrderBy(x => x).OrderBy(x => x[n]).ToArray();
        return answer;
    }
}