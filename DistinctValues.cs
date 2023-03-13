//Create a List<string> method called DIstinctValues that takes in a List<string> strings. Given a list of strings, return a list that contains the ditinct values. (You can use HashSet if you want)

public List<string> DistinctValues(List<string> strings){
    List<string> results = new List<string>();
    foreach(string s in strings){
        if(!strings.Contains(s)){
            results.Add(s);
        }
    }
    return results;
}

//---------OR----------- "HASHSET"

public List<string> DIstinctValues(List<string> strings)
{
    HashSet<string> uniqueStrings = new HashSet<string>(strings);
    return uniqueStrings.ToList();
}