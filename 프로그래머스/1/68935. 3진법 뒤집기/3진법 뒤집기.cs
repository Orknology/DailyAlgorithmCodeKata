//공부한 결과 2가지 방법이 존재한다. 하나는 1대1로 과정을 따라하는 것. 하나는 while문을 이용하는 것
//1대1로 따라하는 것은 10진수를 3진법으로 -> 3진수를 10진법으로 변환하는 모든 과정을 따라서 만드는 것. 불가능 하지 않으나 시도해보다가 굉장히 길어졌다.
//다음 방법인 while문은 이 과정을 짧게 표현한 것으로 좀 복잡한 개념이 필요하다.
//answer값이 0으로 시작하는 점을 이용해 n에서 나머지가 나올 때 까지 n값만이 while문에서 3으로 나눠지는 점을 이용
//이후 나머지를 받고 n이 0이 될 때까지 반복, 리턴되는 결과값이 처음 방법과 같다.
using System;

public class Solution {
    public int solution(int n) {
        int answer=0;
    while(n>0)
    {
        answer*=3;
        answer+=n%3;
        n/=3;
    }
    return answer;
    }
}