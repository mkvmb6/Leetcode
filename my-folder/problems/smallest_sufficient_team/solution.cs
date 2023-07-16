public class Solution {
    private List<int> result = new List<int>();
    public int[] SmallestSufficientTeam(string[] req_skills, IList<IList<string>> people) {
        result = new List<int>();
        var skillMap = new Dictionary<string, int>();
        var len = req_skills.Length;
        for(int i=0; i < len; i++){
            skillMap[req_skills[i]] = i;
        }
        var target = (1 << len) - 1;
        var peopleSkills = new int[people.Count];
        for(int i=0;i<people.Count;i++){
            foreach(var skill in people[i]){
                peopleSkills[i] |= 1 << skillMap[skill];
            }
        }
        var set = new Dictionary<string, int>();
        FindPeople(0, peopleSkills, target, 0, new List<int>(), set);
        return result.ToArray();

    }

    void FindPeople(int idx, int[] peopleSkills, int target, int skillMask, List<int> tempResult, Dictionary<string, int> set){
        if(idx >= peopleSkills.Length){
            if(skillMask == target){
                if(result.Count == 0 || tempResult.Count < result.Count){
                    result = tempResult.ToList();
                }
            }
            return;
        }
        if(result.Count != 0 && tempResult.Count > result.Count){
            return;
        }

        var key = idx+""+skillMask;
        if(set.ContainsKey(key) && set[key] < tempResult.Count){
            return;
        }

        FindPeople(idx + 1, peopleSkills, target, skillMask, tempResult, set);
        if((peopleSkills[idx] | skillMask) != skillMask){
            skillMask |= peopleSkills[idx];
            tempResult.Add(idx);
            FindPeople(idx + 1, peopleSkills, target, skillMask, tempResult, set);
            tempResult.Remove(idx);
        }
        set[key]=tempResult.Count;     
    }
}