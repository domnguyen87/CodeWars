// You are given the array paths, where paths[i] = [cityAi, cityBi] means there exists a direct path going from cityAi to cityBi. Return the destination city, that is, the city without any path outgoing to another city.
// It is guaranteed that the graph of paths forms a line without any loop, therefore, there will be exactly one destination city.

// Example 1:
// Input: paths = [["London","New York"],["New York","Lima"],["Lima","Sao Paulo"]]
// Output: "Sao Paulo" 
// Explanation: Starting at "London" city you will reach "Sao Paulo" city which is the destination city. Your trip consist of: "London" -> "New York" -> "Lima" -> "Sao Paulo".

public class Solution 
{
    public string DestCity(IList<IList<string>> paths)
    {
        ISet<string> fromSet = new HashSet<string>();
        foreach(var p in paths)
        {
            fromSet.Add(p[0]);
        }   

        foreach (var p in paths)
        {
            if(!fromSet.Contains(p[1]))
            {
                return p[1];
            }
        } 

        returns "";
    }
}