//처음에는 그냥 풀어보고 있다가
//다른 사람 풀이를 통해 훨씬 간소화 해봤다가
//Linq를 이용해 푸는 풀이를 또 보게 되었는데
//Linq를 이용하는 것이 가장 짧았다. 이곳에는 그 풀이를 참고하여 적는다.
using System; 
using System.Linq;
 
public class Solution {
    public string solution(string s, string skip, int index) {
          string answer = "";
            string a = new string("abcdefghijklmnopqrstuvwxyz".Where(x => !skip.Contains(x)).ToArray());
            // skip이 x값을 포함하지 않고 있다면
            // skip이 가지고 있지 않은 알파벳으로 새로운 배열
        
            foreach (var t in s)
            {
                answer += a[(a.IndexOf(t.ToString()) + index) % a.Length];
            //배열 a에서 t가 포함된 인덱스 순서 찾기. 이후, index만큼 추가
            //a.Length만큼 나눠서 만약 배열 값보다 커지면, 다시 a부터 값을 찾도록
            }
            return answer;
    }
}