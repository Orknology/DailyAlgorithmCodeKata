using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        
        //총 3개의 수를 더해야 하므로 for문 3번 반복
        for(int i=0; i<nums.Length-2; i++)
        {
            for(int j=i+1; j<nums.Length-1; j++)
            {
                for(int k=j+1; k<nums.Length; k++)
                {
                     // 세 숫자를 더함
                    int n = nums[i] + nums[j] + nums[k];
                    
                    // n이 소수인지 확인하기 위한 변수
                    int count=0;
                    
                    // 2부터 n까지의 숫자로 나눠 소수인지 확인
                    for(int t=2; t<=n; t++)
                    {
                        if(n%t==0) count++; // 나머지가 0이면 count 증가
                    }

                    // count가 1이면 소수이므로 answer 증가
                    if(count==1) answer++;
                }
            }
        }
        return answer;
    }
}