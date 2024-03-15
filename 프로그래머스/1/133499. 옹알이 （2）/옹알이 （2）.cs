//이번에는 인터넷에 검색해서 방법을 찾아봐야했다.
//초기 구상하던 구조는 비효율적이었다.
//https://jypgamepro.tistory.com/entry/%ED%94%84%EB%A1%9C%EA%B7%B8%EB%9E%98%EB%A8%B8%EC%8A%A4-%EC%98%B9%EC%95%8C%EC%9D%B42C

using System;

public class Solution {
    public int solution(string[] babbling) 
    {
    string[] sample = { "aya", "ye", "woo", "ma" };
    int answer = 0;

	for (int i = 0; i < babbling.Length; i++)
            {
                for (int j = 0; j < sample.Length; j++)
                {
                    if (!babbling[i].Contains(sample[j] + sample[j]))
                    babbling[i] = babbling[i].Replace(sample[j], " ");
                }

                babbling[i]= babbling[i].Trim();
                if (babbling[i] == "")
                    answer++;
            }
        return answer;
    }
}