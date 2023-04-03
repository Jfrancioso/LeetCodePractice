Title: No14 - Check if an Array Contains No 1's and No 4's 

  

Problem: Create a boolean method called No14 that takes in an integer array "nums". Given an array of ints, return true if it contains no 1's and it contains no 4's. 

  

Solution: 

  

public bool No14(int[] nums) { 

    bool seen1 = false; 

    bool seen4 = false; 

  

    // Iterate through the array 

    for (int i = 0; i < nums.Length; i++) { 

        // Check if the current element is 1 

        if (nums[i] == 1) { 

            seen1 = true; 

        } 

        // Check if the current element is 4 

        else if (nums[i] == 4) { 

            seen4 = true; 

        } 

    } 

  

    // If both 1 and 4 are not seen, return true; otherwise, return false 

    return !seen1 && !seen4; 

} 