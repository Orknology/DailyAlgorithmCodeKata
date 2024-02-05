//최대 공약수 최소 공배수를 구하는 방식부터 설정
//기본 개념 : 최대 공약수 x 서로소 = 최소 공배수
//유클리드 호제법이 존재하는 상황, 그대로 쓰라는 의도일까?
//다른 방법을 써보려던 건 무지 비효율 적으로 보이니 다시 호제법 사용

public class Solution {
    public int[] solution(int n, int m) {
        //answer 배열 2개 선언
        int[] answer = new int[2];
        //최대 공약수 && 최소 공배수 결과 값 받을 함수
        int gcdAnswer;
        int lcmAnswer;
        //결과 값 구하기
        gcdAnswer = gcd(n, m);
        lcmAnswer = (n * m) / gcdAnswer;
        //배열에 입력
        answer[0] = gcdAnswer;
        answer[1] = lcmAnswer;
        return answer;
    }
    //계산 법
    public int gcd(int n, int m)
    {
        if(m == 0) 
            return n;
        else 
            return gcd(m, n%m);
    }
}