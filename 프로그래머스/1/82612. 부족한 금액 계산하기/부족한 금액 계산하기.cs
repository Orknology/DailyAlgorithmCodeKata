using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long totalPrice = 0;
        for(int i = 0; i <= count; i++)
        {
            totalPrice += price * i;
        }
        if(totalPrice > money)
        {
            return totalPrice - money;
        }
        else
            return 0;
    }
}