//아침 졸음에 문제 설명을 이해하기 쉽지 않아졌다.
//문제를 이해하기 위해서라도 인터넷을 검색해서 문제 설명을 보는 일이 많아졌다.
//물론 그런 과정에서 남의 풀이를 많이 보게되니 배우는 것도 있지만
//점차 시간문제로 내가 고뇌하며 푸는 것이 줄어들고 있는 느낌이 들기는 한다.
//첫 작성 시 이보다 훨씬 길었는데 인터넷 내용을 바탕으로 훨씬 짧아짐
//역시 잘하는 사람은 많다.

//문제의 요구는 X,와 Y에 동시에 존재하는 수 조합 중 가장 큰 정수를 찾는 것
//또한 짝궁이 없다면 -1, 0밖에 없다면 0을 리턴하는 조건
using System;
using System.Text;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        int[] a = new int[10];
        int[] b = new int[10];

        for(int i = 0; i < X.Length; i++) { a[(int)(X[i] - 48)]++; }
        for(int i = 0; i < Y.Length; i++) { b[(int)(Y[i] - 48)]++; }
        
        //StringBuilder는 변형할 수 없는 string이 아닌 변형 가능한 클래스로
        //반복문으로 string을 수정하려고 할 때, 보다 성능에 저하를 막을 수 있다.
        StringBuilder sb = new StringBuilder();

        for(int i = 9; i >= 0; i--)
        {
            while(a[i] > 0 && b[i] > 0)
            {
                sb.Append(i);
                a[i]--;
                b[i]--;
            }
        }
        
        if("".Equals(sb.ToString())) 
            answer = "-1";
        else if("0".Equals(sb.ToString().Substring(0, 1))) 
            answer = "0";
        else 
            answer = sb.ToString();
        return answer;
    }
}