//Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[o]...nums[i])
//return the running sum of nums

Public class Solution{
    public int[] RunningSums(int[] nums){
        int[] results = new int[nums.Length];
        results[0] = nums[0];
        for(int i = 1; i < nums.Length; i++){
            results[i] = nums[i] + results[i - 1];
        }
        return results;
    }
}
