//https://leetcode.com/problems/two-sum/

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