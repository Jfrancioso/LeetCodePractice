// //Two Sum Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

// You may assume that each input would have exactly one solution, and you may not use the same element twice.

// You can return the answer in any order.

 //for this solution, we will use two variables {i , j}, the sum of these variables will be compared to the target to check if the same
Public class Solution{
 public int[] TwoSum(int[] nums, int target){
     for(int i = 0; i < nums.Length; i++){
     for(int j = i+1; i < nums.Length; i++){
         if(nums[i] + nums[j] == target){
             return new int[] = {i,j};
         }
     }
 }
 return new int[0]; //else return an empty array
 }
 }