//복잡하게 생각해서 찾아보니 매우 간단했다.
public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "Yes";
        int index1 = 0;
        int index2 = 0;
        
        for(int i = 0; i < goal.Length; i++)
        {
            if(index1 < cards1.Length && goal[i] == cards1[index1])
            {
                index1++;
                continue;
            }
            else if(index2 < cards2.Length && goal[i] == cards2[index2])
            {
                index2++;
                continue;
            }
            else
            {
                return "No";
            }         
        }
        
        return answer;
    }
}