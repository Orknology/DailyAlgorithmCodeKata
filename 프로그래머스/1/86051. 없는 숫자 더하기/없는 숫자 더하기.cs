using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 45 - numbers.Sum();
        return answer;
    //혹은
    //var numberArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //return numberArray.Except(numbers).Sum();
    }
}
