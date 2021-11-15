using System.Collections.Generic;

namespace LeetCodeProblems.DailyTemperatures
{
    public class Solution {
        public int[] DailyTemperatures(int[] temperatures) {
            int n = temperatures.Length;
            Stack<int> days = new Stack<int>();
            int[] answer = new int[n];
            for(int i = 0; i<n; i++){
                var temp  = temperatures[i];
                while (days.Count > 0 && temperatures[days.Peek()] > temp){
                    var day = days.Pop();
                    answer[day] = i - day;
                }
                days.Push(i);
            }
            return answer;
        }
    }  
}