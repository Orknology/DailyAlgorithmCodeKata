//문제 길이가 아침부터 안읽힌다.
//문제 내용은 결국 모든 파일을 드래그해서 삭제하려는데
//이때 최소한의 이동 지점을 return하라는 문제
//역시 문제는 무시하고 입출력 예부터 보는게 편하다...

//격자판 특성상 배열을 이용하는 것이 좋아보인다.
//처음엔 조건문으로 따지는 구조를 생각했지만,
//다른사람의 답안에서 Max/MinValue 이용하는 것을 보고
//간략화하기 좋은 것 같아 몰래 베껴왔다...

using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[]{int.MaxValue, int.MaxValue, int.MinValue, int.MinValue};

        // 배열의 행
        for (int i = 0; i < wallpaper.Length; i++)
        {
            // 현재 행의 문자
            for (int j = 0; j < wallpaper[i].Length; j++)
            {
                // 파일이 있는 칸인지 체크
                if (wallpaper[i][j] == '#')
                {
                    // 드래그 지점의 최소 행과 열
                    answer[0] = Math.Min(answer[0], i);
                    answer[1] = Math.Min(answer[1], j);
                    
                    // 드래그 지점의 최대 행과 열
                    // 행과 열 좌표에 1을 더하기 = 드래그 지점의 너비와 높이를 고려
                    answer[2] = Math.Max(answer[2], i + 1);
                    answer[3] = Math.Max(answer[3], j + 1);
                }
            }
        }         
        return answer;
    }
}