//https://leetcode.com/problems/two-sum/

<<<<<<< HEAD
using System;

int[] TwoSumReview(int[] nums, int target){
  Dictionary<int, int> numsDictionary = new Dictionary<int, int>();

  for (int i = 0; i < nums.Length; i++){
    int num = nums[i];

    // You can uncomment this if nums are all positive
    //if (num > target) { continue; }

    if (numsDictionary.TryGetValue(target - num, out int index)){          
      return new [] { index, i }; 
    }

    numsDictionary[num] = i;
  }

  return null;
}
=======
// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// You can return the answer in any order.

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] sum = new int[2];
        for(int i = 0; i < nums.Length; i++){
        }
        return sum;
    }
}

//TODO
>>>>>>> d5a87e865e64b813d65ac2cb490ee31c7c93213a
