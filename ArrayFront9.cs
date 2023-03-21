//create a bool method called ArrayFront9 that checks whether the front 4 elements contains a 9, take in an int[] called nums, if it does return true, otherwise return false. Length of array may be less than 4.

public bool ArrayFront9(int[] nums){
    int checkLength = Math.Min(nums.Length; 4);
    bool nine = false;
    for(int i = 0; i < checkLength; i++){
        if(nums[i] == 9){
            nine = true;
        }
    }
    return nine;
}