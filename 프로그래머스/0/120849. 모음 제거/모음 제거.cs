using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public string solution(string my_string) 
    {
        HashSet<char> hash = new HashSet<char>(){'a', 'e', 'i', 'o', 'u'};
        return new string(my_string
            .ToCharArray()
            .Where(x => !hash.Contains(x))
            .ToArray());
    }
}