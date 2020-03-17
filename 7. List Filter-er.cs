//Create a function that takes a list of non-negatives int and strings and return a new list with the strings filtered out

//ListFilterer.GetIntegersFromList(new List<object>() {1,2, "a", "b"}) =>{1,2}
//ListFilterer.GetIntegersFromList(new List<object>() {1,2, "a", "b", 0, 15}) =>{1,2, 0, 15}
//ListFilterer.GetIntegersFromList(new List<object>() {1,2, "a", "b", "asd", "1", "123", 231}) =>{1,2, 231}

Using Systems;

public class ListFilterer
{
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        return listOfItems.OfType<int>();
    }
}
