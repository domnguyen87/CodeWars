// Given an array nums of size n, return the majority element.
// Input: nums = [3,2,3]
// Output: 3

/**
 * @param {number[]} nums
 * @return {number}
 */
 var majorityElement = function(nums) {
    
    let frequencyCounter = {}, averagePoint = Math.floor(nums.length/2)

    for ( let num of nums) {
        frequencyCounter[num] = (frequencyCounter[num] || 0 ) + 1
    }

    for ( let i in frequencyCounter ) {
        if(frequencyCounter[i] > averagePoint) {
            return + i
        }
    }

    return 0
};

var majorityElement2 = function(nums) {
    let obj = {}
    for( let i = 0 ; i < nums.length; i++) {
        if(!obj[nums[i]]) {
            obj[nums[i]] = 0
        }

        ob[nums[i]] +=1
    }

    return Object.keys(obj).reduce((a,b) => obj[a] ? a : b)
  
};