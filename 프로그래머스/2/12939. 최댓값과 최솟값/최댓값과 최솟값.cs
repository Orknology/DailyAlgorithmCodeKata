//Linq에서 Select기능이 있어 짧게 만들 수 있음
//Select : 어떤 것을 가져올 것인지, 특정 형식으로 변환 가능 
//하지만 메모리 상으로는 Linq를 쓰는 것이
//알고리즘을 수동작성 하는 것보다 무겁다고 하니,
//유니티에서는 지금처럼 Linq를 쓰기보다
//min, max값을 배열에서 foreach문으로 구하는 방식이
//메모리적으로는 더 유리할 것

using System.Linq;

public class Solution {
    public string solution(string s) {
            string answer = "";

            int[] array = s.Split(' ').Select(int.Parse).ToArray();
            answer = array.Min().ToString() + " " + array.Max().ToString();

            return answer;
    }
}