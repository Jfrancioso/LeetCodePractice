Title: Start1 - Count Arrays with 1 as First Element 

  

Problem: Create an integer method called Start1 that takes in two integer arrays called "a" and "b". Start with 2 int arrays, a and b, of any length. Return how many of the arrays have 1 as their first element. 

  

Solution: 

  

public int Start1(int[] a, int[] b) { 

    int count = 0; 

  

    // Check if the first element of array 'a' is 1 

    if (a.Length > 0 && a[0] == 1) { 

        count++; 

    } 

  

    // Check if the first element of array 'b' is 1 

    if (b.Length > 0 && b[0] == 1) { 

        count++; 

    } 

  

    // Return the total count of arrays with 1 as their first element 

    return count; 

} 