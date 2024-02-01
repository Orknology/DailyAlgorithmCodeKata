//주의점 : 2차원 배열, 행렬 길이 GetLength
//배열의 덧셈은 어떻게? 고민해보다가 for문을 이중으로 사용하는 예시들-
//이번엔 혼자 하기보단 자료를 많이 찾아봐야했다.

public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        //2차원 배열의 길이 설정
        int[,] answer = new int[arr1.GetLength(0),arr2.GetLength(1)];
        
        //더하기
        for(int i = 0; i < arr1.GetLength(0); i++)
        {
            for(int j = 0; j < arr1.GetLength(1); j++)
            {
                answer[i,j] = arr1[i,j] + arr2[i,j];
            }
        }
        return answer;
    }
}