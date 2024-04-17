//필요내용 = 오늘 날짜, 유효기간을 비교하기
//예시 정보 = A라는 약관의 유효기간 6달이니까
//키값 = A와 밸류 6이라는 딕셔너리로 저장할 생각
//거의 안써본 구조체에 관해 알게 되었는데
//DateTime <= 날짜와 시간으로 한 순간을 나타내는 구조체

using System;
using System.Collections.Generic;

public class Solution {
    public List<int> solution(string today, string[] terms, string[] privacies) {
        List<int> answer = new List<int>{}; //답 추가하기 편하도록 배열에서 리스트로 변경
        
        DateTime currentDate = DateTime.Parse(today); 
        //DateTime 구조체에서 제공하는 현재 날짜 기능
        
        Dictionary<string, int> termsDict = new Dictionary<string, int>();
        //약관을 받을 딕셔너리로 약관 종류(스트링 값)를 키로 기간을 밸류료 받는다
        
        for (int i = 0; i < terms.Length; i++)
        {
            string[] termInfo = terms[i].Split(' '); 
            //스페이스를 기준으로 자르기
            termsDict.Add(termInfo[0], int.Parse(termInfo[1]));
            //딕셔너리에 유효기간 개월수를 넣고 int로 변환
        }
        
        for (int i = 0; i < privacies.Length; i++)
        {
            DateTime initDate = DateTime.Parse(privacies[i].Split(' ')[0]);
            //첫 개인정보 수집 일자
            int termDate = termsDict[privacies[i].Split(' ')[1]];
            //비교할 유효기간
            DateTime expireDate = initDate.AddMonths(termDate);
            //첫 수집 일자 + 유효기간 달 수를 더해 종료일 계산
            
            if (currentDate >= expireDate)
            {
                answer.Add(i+1);
            }
        }
        
        return answer;
    }
}