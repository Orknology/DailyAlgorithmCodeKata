//이번에는 어느정도 구조는 생각이 나지만
//그걸 구현하는 방법을 모르겠어서 찾아보니 아스키 코드로 푸는 방법도 있었다.
using System;

public class Solution {
    public string solution(string s, int n) {
        string answer = "";

        //문자열을 우선 char 배열로 저장
        char[] arr = s.ToCharArray();
        
        for(int i = 0; i < arr.Length; ++i)
        {
            //공백은 공백으로 남겨야함
            if(arr[i] == ' ')
                continue;
            
            //n만큼 문자를 밀어내기
            int num = Convert.ToInt32(arr[i]) + n;
        
            //대문자를 밀어낼 때 순서 상 소문자 영역으로 밀려나기도 함
            //이를 방지하기 위한 조건문 필요
            //원본 문자를 확인하여 소문자인지 대문자인지 체크하는 조건문
        
            if((arr[i]) >= 'A' && arr[i] <= 'Z')
            {
                if(num > 'Z')
                    num -= 26;
            }
            else
            {
                if(num > 'z')
                    num -= 26;
            }
            arr[i] = Convert.ToChar(num);
        }
        
        answer = new string(arr);
        
        return answer;
    }
}