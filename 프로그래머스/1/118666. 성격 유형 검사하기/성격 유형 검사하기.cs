// 처음엔 switch문을 이용해 케이스를 정해야 하나 생각하며 풀어갔지만
// 내용이 많이 거칠어져서 보기에도 구조적으로도 별로인 것 같아
// 인터넷을 찾아보다 더 깔끔하고 정리가 잘된 내용을 발견하여 이를 기반으로 정리

// 문제 키워드 =
// 4가지 지표, 각 2개의 유형 존재, 총 16개 성격유형
// 검사 선택지 7개, 1가지 지표
// 질문에 따라 같은 답변이 네오와 어피치형으로 바뀔 수 있다
// 유형점수가 같으면 사전 순으로 빠른 것
// survey : 4가지 지표 2개 유형 문자열 배열, choices : 각 질문별 선택한 선택지 정수 배열
// 검사자의 결과 지표번호 순서대로 리턴
        
public class Solution
{
    public string solution(string[] survey, int[] choices)
    {
        string answer = "";
        string[,] keys = new string[4, 2]
        {
            // 4가지 지표 2가지 유형 초기화
            {"R", "T" }, {"C", "F" }, {"J","M"}, {"A","N"}
        };
        int[,] values = new int[4, 2];

        for (int i = 0; i < survey.Length; i++)
        {
            string sSurvey = "";
            int choice = 0;

            if (choices[i] > 4) // 선택지가 동의쪽이면
            {
                sSurvey = survey[i][1].ToString(); //survey의 두번째 캐릭터를 sServey에 저장
                choice = (-1) * (4 - choices[i]); // choice에 양수(1,2,3 중 하나)를 저장
            }
            else // 비동의 쪽이면
            {
                sSurvey = survey[i][0].ToString(); // survey의 첫번째 캐릭터를 sServey에 저장
                choice = 4 - choices[i]; // choice에 양수(0,1,2,3 중 하나)를 저장
            }
            
            for (int j = 0; j < 4; j++) // 첫번째 인덱스
            {
                for (int k = 0; k < 2; k++) // 두번째 인덱스
                {
                    if (keys[j, k] == sSurvey) // key배열의 요소와 sServey에 들어온 캐릭터가 일치하면
                    {
                        values[j, k] += choice; // 해당 인덱스 value배열 위치에 choice값 추가 
                    }
                }
            }
        }

        for (int i = 0; i < 4; i++) // 주어진 점수를 가지고 구성하기
        {
            if (values[i, 0] >= values[i, 1]) // value배열의 첫번째 캐릭터의 값이 두번째보다 크면
                answer += keys[i, 0]; // 정답에 키값에 첫번째 캐릭터 추가
            else if (values[i, 0] < values[i, 1]) // 작으면
                answer += keys[i, 1]; // 두번째 캐릭터 추가
        }
        return answer;
    }
}
