public class Solution {
    public string SortVowels(string s) {
        var len = s.Length;
        var arrVovel = new bool[len];
        var vovels = new List<char>();
        for(int i=0;i<len;i++){
            if(isVovel(s[i])){
                arrVovel[i]=true;
                vovels.Add(s[i]);
            }
        }
        vovels.Sort();
        
        var arr = new char[len];
        var j = 0;
        for(int i=0;i<len;i++){
            if(arrVovel[i]){
                arr[i]=vovels[j++];
            }
            else{
                arr[i]=s[i];
            }
        }
        return new string(arr);
    }
    
    bool isVovel(char ch){
        ch = Char.ToLower(ch);
        return ch == 'a' ||ch == 'e' ||ch == 'i' ||ch == 'o' ||ch == 'u';
    }
}