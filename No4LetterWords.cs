// No4LetterWords – Remove 4 letter words from a list 
 
// Problem:Create a list of type string method called No4LetterWords that takes in an array of type string "strings". Given an array of strings, return a list containing the same strings in the same order except for any words that contain exactly 4 characters. 

// Example: 

// Input: ["hello", "code", "world", "java", "python"]  

// Output: ["hello", "world", "python"] 

 

Public List<string> No4LetterWords(string[] strings){ 
//initialize a new list to store the result 

List<string> resultList = new List<string>(); 

//iterate through the input array 

//(foreach is used because it is more concise and we don't need the index) 

Foreach(string word in strings){ 

//check if the word has exactly 4 characters 

If(word.Length != 4){ 

//add the word to the result list if it doesn't have 4 characters 

Result.Add(word); 

//return the list 

Return resultList; 

}
}
}; 