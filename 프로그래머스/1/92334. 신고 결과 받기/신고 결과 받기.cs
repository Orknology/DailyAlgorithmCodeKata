//신고가 중복되지 않도록 처리 => 신고 기록 저장해서 Contains 등 메서드 이용
//신고 당한 유저<Key>의 신고 유저 목록<List>을 알면 중복 메일도 신고 당한 유저 Key의 리스트에서 신고한 유저의 신고 횟수를 1회 늘리는 방식
//신고 당한 유저를 Key, 신고한 유저 목록을 List 형식의 Value로 딕셔너리
//Split()을 통해 report에 존재하는 값 중 신고한 유저를 give, 당한 유저를 tale
//신고 당한 유저가 딕셔너리에 Key로 존재하지 않으면 새로 생성
//존재할 경우 딕셔너리[take]로 신고한 유저 목록을 가져와서 이미 신고한 유저의 이름이 포함되어 있는지 비교 처리
//id_list에서 해당 리스트의 카운트가 신고 커트라인인 k보다 높거나 같은지 확인 

using System;
using System.Collections;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(string[] id_list, string[] report, int k) 
    {
        int[] answer = new int[id_list.Length];

        Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

        for (int i = 0; i < report.Length; i++)
        {
            string[] str = report[i].Split(' ');

            string give = str[0];
            string take = str[1];

            if (!dic.ContainsKey(take))
            {
                List<string> list = new List<string>();
                list.Add(give);
                dic.Add(take, list);
                continue;
            }

            if (!dic[take].Contains(give))
            {
                dic[take].Add(give);
            }
        }

        for (int i = 0; i < id_list.Length; i++)
        {
            foreach (KeyValuePair<string, List<string>> item in dic)
            {
                if (item.Value.Contains(id_list[i]))
                {
                    if (item.Value.Count >= k)
                    {
                        answer[i] = ++answer[i];
                    }
                }                
            }
        }

        return answer;
    }
}