using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int solution(string[] spell, string[] dic) 
    {
        HashSet<char> hash = new HashSet<char>(string.Join("", spell).ToCharArray());
        return dic
            .Select(x => x.Where(y => hash.Contains(y)).Distinct().ToArray())
            .Where(x => hash.Count == x.Length)
            .Count() > 0 ? 1 : 2;
    }
}