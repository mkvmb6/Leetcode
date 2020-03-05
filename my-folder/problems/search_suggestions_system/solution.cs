using System.Collections.Generic;
using System.Linq;
public class Solution {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        
            var listOfResultList = new List<IList<string>>();
            var currentList = products.Where(p => p.Length > 0).Where(p => p[0] == searchWord[0]).ToList();
            currentList.Sort();
            listOfResultList.Add(currentList.Take(3).ToList());
            for (int i = 1; i < searchWord.Length; i++)
            {
                currentList = currentList.Where(p => p.Length > i).Where(p => p[i] == searchWord[i]).ToList();
                listOfResultList.Add(currentList.Take(3).ToList());
            }
            return listOfResultList;
    }
}