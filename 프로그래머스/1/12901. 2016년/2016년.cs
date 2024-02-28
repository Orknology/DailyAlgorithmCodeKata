//요일이 들어가 있는 배열 필요
//1년 366일(윤년)?으로 체크?
//월마다 일수로 체크? 
//생각보다 기준 잡기와 계산 방식이 생각이 어렵다.

public class Solution {
    public string solution(int a, int b) {
        //a = 월 b = 일 => 월을 받아서 그 날짜 수 만큼 먼저 총합일수 하고 + b를 해주기
        string answer = "";
        
        //금요일부터 시작하는 요일 배열, 요일은 7로 나눈 나머지의 배열 순으로 체크 가능할 듯
        string[] day = new string[] { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU"};
        //1월부터 12월까지 해당 일 수
        int[] month = new int[] {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        
        //입력 날짜까지의 총 일수 함수
        int daysSum = 0;
        
        for(int i = 0; i < a-1; i++)
        {
            daysSum += month[i];
        }
        daysSum += b - 1;
        //a와 b에 -1은 배열의 시작이 0부터 이기에
        
        
        return answer = day[daysSum % 7];
    }
}