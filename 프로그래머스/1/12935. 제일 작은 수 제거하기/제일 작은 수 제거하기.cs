//배열의 최솟값, 특정값 구하는 방법이 필요.
//Where 내부에 arr.Min을 선언하면 매 원소마다 최솟값을 찾아야함.
using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        int[] emptyArr = new int[] { -1 };
        
        if (arr.Length < 2)
            return emptyArr;
        
        int min = arr.Min();
        int[] newArr = arr.Where(num => num != min).ToArray();
        return newArr;
    }
}