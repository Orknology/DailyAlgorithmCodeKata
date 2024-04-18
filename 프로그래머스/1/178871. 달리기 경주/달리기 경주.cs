//추월은 순위가 한 번에 하나씩만 바뀌기에 한 개의 딕셔너리 내에서 해결 가능
using System;
using System.Collections.Generic;

public class Solution {
       public string[] solution(string[] players, string[] callings) {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        
        for(int i = 0; i < players.Length; i++) { dict.Add(players[i], i); }
        
        foreach(string call in callings)
        {
            int rank = dict[call];
            string overtake = players[rank - 1];
            
            players[rank - 1] = call;
            players[rank] = overtake;
            
            dict[call] = rank - 1;
            dict[overtake] = rank;
        }
        return players;
    }
}